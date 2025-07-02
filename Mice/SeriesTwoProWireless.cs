namespace GloriousBatteryMonitor.Mice
{
    public class SeriesTwoProWireless : BaseDevice
    {
        public override string DeviceName => "Series 2 Pro";
        public override int VendorId => 0x258A;
        public override int? WiredProductId => 0x201D;
        public override int? ReceiverProductId => 0x2039;
        public override IBatteryChecker BatteryChecker { get; }

        public SeriesTwoProWireless()
        {
            BatteryChecker = new MouseV2ProBatteryChecker();
        }
    }
}