using HidSharp;

namespace GloriousBatteryMonitor.Mice
{
    public abstract class BaseDevice : IDevice
    {
        public abstract string DeviceName { get; }
        public abstract int VendorId { get; }
        public abstract int? WiredProductId { get; }
        public abstract int? ReceiverProductId { get; }
        public abstract IBatteryChecker BatteryChecker { get; }

        public BatteryStatusResult CheckDevice()
        {
            var deviceChecks = new[]
            {
                new { Name = "Wired", ProductId = WiredProductId },
                new { Name = "Wireless Receiver", ProductId = ReceiverProductId }
            };

            foreach (var check in deviceChecks)
            {
                if (!check.ProductId.HasValue) continue;

                var deviceList = DeviceList.Local.GetHidDevices(VendorId, check.ProductId.Value).ToArray();
                if (!deviceList.Any()) continue;

                foreach (var device in deviceList)
                {
                    if (BatteryChecker.TryGetBatteryStatus(device, out int level, out bool charging))
                    {
                        return new BatteryStatusResult
                        {
                            IsConnected = true,
                            DeviceName = DeviceName,
                            ConnectionType = check.Name,
                            BatteryLevel = level,
                            IsCharging = charging,
                            // When mouse is switched off and not plugged in or dead
                            IsTransient = check.Name == "Wireless Receiver" && level == 0
                        };
                    }
                }
            }
            return new BatteryStatusResult(); // Not found
        }
    }
}