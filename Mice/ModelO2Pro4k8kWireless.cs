namespace GloriousBatteryMonitor.Mice
{
    public class ModelO2Pro4k8kWireless : BaseDevice
    {
        public override string DeviceName => "Model O2 Pro 4k/8k";
        public override int VendorId => 0x258A;
        public override int? WiredProductId => 0x201B;
        public override int? ReceiverProductId => 0x2035;
        public override IBatteryChecker BatteryChecker { get; }

        public ModelO2Pro4k8kWireless()
        {
            BatteryChecker = new MouseV2ProBatteryChecker();
        }
    }
}