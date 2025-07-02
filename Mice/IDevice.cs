namespace GloriousBatteryMonitor.Mice
{
    public interface IDevice
    {
        string DeviceName { get; }
        int VendorId { get; }
        int? WiredProductId { get; }
        int? ReceiverProductId { get; }
        IBatteryChecker BatteryChecker { get; }

        BatteryStatusResult CheckDevice();
    }
}