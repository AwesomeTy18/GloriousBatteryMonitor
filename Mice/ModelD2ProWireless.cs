namespace GloriousBatteryMonitor.Mice
{
    public class ModelD2ProWireless : BaseDevice
    {
        public override string DeviceName => "Model D2 Pro";
        public override int VendorId => 0x258A;
        public override int? WiredProductId => 0x201A;
        public override int? ReceiverProductId => 0x2034;
        public override IBatteryChecker BatteryChecker { get; }

        public ModelD2ProWireless()
        {
            BatteryChecker = new MouseV2ProBatteryChecker();
        }
    }
}