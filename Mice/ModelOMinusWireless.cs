namespace GloriousBatteryMonitor.Mice
{
    public class ModelOMinusWireless : BaseDevice
    {
        public override string DeviceName => "Model O Minus (Wireless)";
        public override int VendorId => 0x258A;
        public override int? WiredProductId => 0x2013;
        public override int? ReceiverProductId => 0x2024;
        public override IBatteryChecker BatteryChecker { get; }

        public ModelOMinusWireless()
        {
            BatteryChecker = new MouseV2ProBatteryChecker();
        }
    }
}