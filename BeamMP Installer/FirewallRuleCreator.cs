using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace BeamMP_Installer
{
    public class FirewallRuleCreator
    {
        public event EventHandler<string> LogMessage;
        public event EventHandler<bool> RuleCreated;

        public async Task Create_Outbound_FirewallRuleAsync(string exeFilePath, string firewallRuleName)
        {
            await Task.Run(() =>
            {
                string powerShellCommand = $"New-NetFirewallRule -DisplayName '{firewallRuleName}' -Direction Outbound -Program '{exeFilePath}' -Action Allow -Protocol Any";

                ProcessStartInfo processStartInfo = new ProcessStartInfo("PowerShell.exe", $"-Command \"{powerShellCommand}\"")
                {
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process process = new Process()
                {
                    StartInfo = processStartInfo
                };

                bool success = false;
                try
                {
                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    success = process.ExitCode == 0;
                    LogMessage?.Invoke(this, output);
                }
                catch (Exception ex)
                {
                    LogMessage?.Invoke(this, $"Error: {ex.Message}");
                }
                finally
                {
                    process.Dispose();
                }

                RuleCreated?.Invoke(this, success);
            });
        }

        public async Task Create_Inbound_FirewallRuleAsync(string exeFilePath, string firewallRuleName)
        {
            await Task.Run(() =>
            {
                string powerShellCommand = $"New-NetFirewallRule -DisplayName '{firewallRuleName}' -Direction Inbound -Program '{exeFilePath}' -Action Allow -Protocol Any";

                ProcessStartInfo processStartInfo = new ProcessStartInfo("PowerShell.exe", $"-Command \"{powerShellCommand}\"")
                {
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process process = new Process()
                {
                    StartInfo = processStartInfo
                };

                bool success = false;
                try
                {
                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    success = process.ExitCode == 0;
                    LogMessage?.Invoke(this, output);
                }
                catch (Exception ex)
                {
                    LogMessage?.Invoke(this, $"Error: {ex.Message}");
                }
                finally
                {
                    process.Dispose();
                }

                RuleCreated?.Invoke(this, success);
            });
        }
    }
}
