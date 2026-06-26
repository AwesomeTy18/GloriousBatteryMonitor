namespace GloriousBatteryMonitor.Mice
{
    public class PulsarX3CrazylightMini : BaseDevice
    {
        public override string DeviceName => "Pulsar X3 Crazylight Mini";
        public override int VendorId => 0x3710;
        public override int? WiredProductId => 0x3507;
        public override int? ReceiverProductId => 0x5406;
        public override IBatteryChecker BatteryChecker { get; }

        public PulsarX3CrazylightMini()
        {
            BatteryChecker = new MousePulsarBatteryChecker();
        }
    }
}