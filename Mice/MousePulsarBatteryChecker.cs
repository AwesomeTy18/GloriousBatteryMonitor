using System.Diagnostics;
using HidSharp;

namespace GloriousBatteryMonitor.Mice
{
    public class MousePulsarBatteryChecker : IBatteryChecker
    {
        public bool TryGetBatteryStatus(HidDevice device, out int batteryLevel, out bool isCharging)
        {
            batteryLevel = 0;
            isCharging = false;

            try
            {
                const byte REPORT_ID = 0x08;

                if (device.TryOpen(out var stream))
                {
                    using (stream)
                    {
                        var command = new byte[16];
                        command[0] = 0x04;
                        byte checksum = CalculateChecksum(command);
                        command[15] = (byte)((checksum - REPORT_ID) & 0xFF);

                        var outputReport = new byte[17];
                        outputReport[0] = REPORT_ID;
                        Buffer.BlockCopy(command, 0, outputReport, 1, command.Length);
                        Debug.WriteLine($"Sending command {BitConverter.ToString(command)}.");
                        stream.Write(outputReport);

                        Task.Delay(50).Wait();

                        var inputReport = new byte[17];
                        int bytesRead = stream.Read(inputReport);

                        if (bytesRead > 0)
                        {
                            Debug.WriteLine($"Received report {BitConverter.ToString(inputReport)}.");
                            if (inputReport[0] == REPORT_ID && inputReport[1] == 0x04)
                            {
                                batteryLevel = inputReport[6];
                                isCharging = inputReport[7] == 1;
                                Debug.WriteLine($"  Battery Level: {batteryLevel}%\n" +
                                    $"  Charging: {isCharging}");
                                return true;
                            }
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

        private byte CalculateChecksum(byte[] data)
        {
            int sum = 0;
            for (int i = 0; i < 15; i++)
            {
                sum += data[i];
            }

            sum &= 255;

            return (byte)((85 - sum) & 255);
        }
    }
}