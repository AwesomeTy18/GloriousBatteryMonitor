using HidSharp;

namespace GloriousBatteryMonitor.Mice
{
    public interface IBatteryChecker
    {
        bool TryGetBatteryStatus(HidDevice device, out int batteryLevel, out bool isCharging);
    }
}