using Microsoft.Win32;

namespace GloriousBatteryMonitor
{
    public static class StartupManager
    {
        private const string AppName = "GloriousBatteryMonitor";
        private static readonly string RegistryPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

        public static void SetStartup(bool enabled)
        {
            RegistryKey? rk = Registry.CurrentUser.OpenSubKey(RegistryPath, true);

            if (enabled)
            {
                rk?.SetValue(AppName, Application.ExecutablePath);
            }
            else
            {
                rk?.DeleteValue(AppName, false);
            }
        }
    }
}