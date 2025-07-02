using System.Diagnostics;
using HidSharp;

namespace GloriousBatteryMonitor.Mice
{
    public class MouseV2ProBatteryChecker : IBatteryChecker
    {
        public bool TryGetBatteryStatus(HidDevice device, out int batteryLevel, out bool isCharging)
        {
            batteryLevel = 0;
            isCharging = false;

            try
            {
                const byte REPORT_ID = 0x00;

                if (device.TryOpen(out var stream))
                {
                    using (stream)
                    {
                        var command = new byte[] { 0x00, 0x00, 0x00, 0x02, 0x02, 0x00, 0x83 };
                        var outputReport = new byte[device.GetMaxFeatureReportLength()];
                        Buffer.BlockCopy(command, 0, outputReport, 0, command.Length);
                        Debug.WriteLine($"  Sending command {BitConverter.ToString(command)} to device.");
                        stream.SetFeature(outputReport);

                        Task.Delay(50).Wait();

                        var inputReport = new byte[65];
                        inputReport[0] = REPORT_ID;
                        stream.GetFeature(inputReport);
                        Debug.WriteLine("  Received Report: " + BitConverter.ToString(inputReport));

                        if (inputReport[6] == 0x83)
                        {
                            isCharging = inputReport[7] == 1;
                            batteryLevel = inputReport[8];
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"  Error on {device.DevicePath}: {ex.Message}");
            }
            return false;
        }
    }
}