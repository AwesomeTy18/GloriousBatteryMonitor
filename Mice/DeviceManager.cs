namespace GloriousBatteryMonitor.Mice;

public static class DeviceManager
{
    private static readonly List<IDevice> SupportedDevices = new List<IDevice>
    {
        new ModelD2Pro4k8kWireless(),
        new ModelD2ProWireless(),
        new ModelDMinusWireless(),
        new ModelDWireless(),
        new ModelO2Pro4k8kWireless(),
        new ModelO2ProWireless(),
        new ModelOMinusWireless(),
        new ModelOProWireless(),
        new ModelOWireless(),
        new SeriesOneProWireless(),
        new SeriesTwoProWireless()
    };

    public static async Task<BatteryStatusResult> GetCurrentBatteryStatus()
    {
        foreach (var deviceDef in SupportedDevices)
        {
            var result = await Task.Run(() => deviceDef.CheckDevice());
            if (result.IsConnected)
            {
                return result;
            }
        }
        return new BatteryStatusResult(); // Return default (not connected) if no device found
    }
}

public class BatteryStatusResult
{
    public bool IsConnected { get; set; } = false;
    public string DeviceName { get; set; } = "N/A";
    public string ConnectionType { get; set; } = "N/A";
    public int BatteryLevel { get; set; } = 0;
    public bool IsCharging { get; set; } = false;
    public bool IsTransient { get; set; } = false;
}