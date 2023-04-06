using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace BeamMP_Installer
{
    public class BeamMP_Utils
    {
        public static string GetBeamNgPath()
        {
            string rootPath = null;

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\BeamNG\BeamNG.drive"))
            {
                if (key != null)
                {
                    rootPath = (string)key.GetValue("rootpath");
                }
            }

            return rootPath + "Bin64\\BeamNG.drive.x64.exe";
        }

        public static bool CheckBeamNgKeyPresent()
        {
            bool keyExists = false;

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\BeamNG\BeamNG.drive"))
            {
                if (key != null)
                {
                    string rootPath = (string)key.GetValue("rootpath");
                    if (rootPath != null)
                    {
                        keyExists = true;
                    }
                }
            }

            return keyExists;
        }
    }
}
