namespace GloriousBatteryMonitor.Mice
{
    public class ModelOProWireless : BaseDevice
    {
        public override string DeviceName => "Model O Pro";
        public override int VendorId => 0x258A;
        public override int? WiredProductId => 0x2015;
        public override int? ReceiverProductId => 0x2027;
        public override IBatteryChecker BatteryChecker { get; }

        public ModelOProWireless()
        {
            BatteryChecker = new MouseV2ProBatteryChecker();
        }
    }
}