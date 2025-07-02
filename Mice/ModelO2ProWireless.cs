namespace GloriousBatteryMonitor.Mice
{
    public class ModelO2ProWireless : BaseDevice
    {
        public override string DeviceName => "Model O2 Pro";
        public override int VendorId => 0x258A;
        public override int? WiredProductId => 0x2019;
        public override int? ReceiverProductId => 0x2033;
        public override IBatteryChecker BatteryChecker { get; }

        public ModelO2ProWireless()
        {
            BatteryChecker = new MouseV2ProBatteryChecker();
        }
    }
}