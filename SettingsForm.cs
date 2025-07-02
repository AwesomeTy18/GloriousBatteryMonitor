namespace GloriousBatteryMonitor
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            numThreshold.Value = Properties.Settings.Default.NotificationThreshold;
            numInterval.Value = Properties.Settings.Default.UpdateIntervalSeconds;
            chkStartWithWindows.Checked = Properties.Settings.Default.StartWithWindows;
            chkStartMinimized.Checked = Properties.Settings.Default.StartMinimized;
            chkCloseToTray.Checked = Properties.Settings.Default.CloseToTray;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.NotificationThreshold = (int)numThreshold.Value;
            Properties.Settings.Default.UpdateIntervalSeconds = (int)numInterval.Value;
            Properties.Settings.Default.StartWithWindows = chkStartWithWindows.Checked;
            Properties.Settings.Default.StartMinimized = chkStartMinimized.Checked;
            Properties.Settings.Default.CloseToTray = chkCloseToTray.Checked;
            Properties.Settings.Default.Save();

            StartupManager.SetStartup(chkStartWithWindows.Checked);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}