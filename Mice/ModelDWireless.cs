namespace GloriousBatteryMonitor.Mice
{
    public class ModelDWireless : BaseDevice
    {
        public override string DeviceName => "Model D (Wireless)";
        public override int VendorId => 0x258A;
        public override int? WiredProductId => 0x2012;
        public override int? ReceiverProductId => 0x2023;
        public override IBatteryChecker BatteryChecker { get; }

        public ModelDWireless()
        {
            BatteryChecker = new MouseV2ProBatteryChecker();
        }
    }
}