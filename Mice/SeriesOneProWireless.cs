namespace GloriousBatteryMonitor.Mice
{
    public class SeriesOneProWireless : BaseDevice
    {
        public override string DeviceName => "Series One Pro";
        public override int VendorId => 0x258A;
        public override int? WiredProductId => 0x2018;
        public override int? ReceiverProductId => 0x2031;
        public override IBatteryChecker BatteryChecker { get; }

        public SeriesOneProWireless()
        {
            BatteryChecker = new MouseV2ProBatteryChecker();
        }
    }
}