using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace BeamMP_Installer
{
    public class FirewallRuleChecker
    {
        public event EventHandler<string> LogMessage;
        public event EventHandler<bool> RuleExists;

        public async Task CheckFirewallRuleExistsAsync(string firewallRuleName)
        {
            await Task.Run(() =>
            {
                string powerShellCommand = $"Get-NetFirewallRule -DisplayName '{firewallRuleName}'";

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

                bool ruleExists = false;
                try
                {
                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    ruleExists = process.ExitCode == 0 && !string.IsNullOrWhiteSpace(output);
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

                RuleExists?.Invoke(this, ruleExists);
            });
        }
    }
}
