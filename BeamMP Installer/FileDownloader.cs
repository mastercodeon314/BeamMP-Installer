using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace BeamMP_Installer
{
    public class FileDownloader : IDisposable
    {
        private readonly HttpClient httpClient;

        public event EventHandler<double[]> DownloadProgressChanged;
        public event EventHandler<string> DownloadCompleted;

        public FileDownloader()
        {
            httpClient = new HttpClient();
        }

        public async Task DownloadFileAsync(string url, string filePath)
        {
            using (var response = await httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
            {
                response.EnsureSuccessStatusCode();

                var contentLength = response.Content.Headers.ContentLength ?? -1L;

                using (var stream = await response.Content.ReadAsStreamAsync())
                using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    var buffer = new byte[8192];
                    var totalBytesRead = 0L;
                    var bytesRead = 0;

                    while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    {
                        Thread.Sleep(0);
                        await fileStream.WriteAsync(buffer, 0, bytesRead);

                        totalBytesRead += bytesRead;

                        var progress = (double)totalBytesRead / contentLength;
                        DownloadProgressChanged?.Invoke(this, new double[] { progress, contentLength });
                    }
                }
            }

            DownloadCompleted?.Invoke(this, filePath);
        }

        public void Dispose()
        {
            httpClient.Dispose();
        }
    }
}
