using System;
using System.IO;
using System.ComponentModel;
using System.Diagnostics;

namespace RMS
{
    internal static class DatabaseHelper
    {
        // Ensure a single absolute path is used everywhere (exe directory)
        public static string DbPath { get; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "rms.db");

        public static string ConnectionString => $"Data Source={DbPath}";

        public static bool IsDesignMode
        {
            get
            {
                try
                {
                    if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                        return true;
                }
                catch { }

                try
                {
                    var pn = Process.GetCurrentProcess().ProcessName.ToLowerInvariant();
                    if (pn.Contains("devenv") || pn.Contains("xdesproc"))
                        return true;
                }
                catch { }

                return false;
            }
        }
    }
}
