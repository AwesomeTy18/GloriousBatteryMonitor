namespace GloriousBatteryMonitor.Mice
{
    public class ModelD2Pro4k8kWireless : BaseDevice
    {
        public override string DeviceName => "Model D2 Pro 4k/8k";
        public override int VendorId => 0x258A;
        public override int? WiredProductId => 0x201C;
        public override int? ReceiverProductId => 0x2036;
        public override IBatteryChecker BatteryChecker { get; }

        public ModelD2Pro4k8kWireless()
        {
            BatteryChecker = new MouseV2ProBatteryChecker();
        }
    }
}