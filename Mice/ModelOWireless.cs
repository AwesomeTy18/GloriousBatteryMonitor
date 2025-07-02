namespace GloriousBatteryMonitor.Mice
{
    public class ModelOWireless : BaseDevice
    {
        public override string DeviceName => "Model O (Wireless)";
        public override int VendorId => 0x258A;
        public override int? WiredProductId => 0x2011;
        public override int? ReceiverProductId => 0x2022;
        public override IBatteryChecker BatteryChecker { get; }

        public ModelOWireless()
        {
            BatteryChecker = new MouseV2ProBatteryChecker();
        }
    }
}