namespace GloriousBatteryMonitor.Mice
{
    public class ModelDMinusWireless : BaseDevice
    {
        public override string DeviceName => "Model D Minus (Wireless)";
        public override int VendorId => 0x258A;
        public override int? WiredProductId => 0x2014;
        public override int? ReceiverProductId => 0x2025;
        public override IBatteryChecker BatteryChecker { get; }

        public ModelDMinusWireless()
        {
            BatteryChecker = new MouseV2ProBatteryChecker();
        }
    }
}