using System.Diagnostics;
using GloriousBatteryMonitor.Mice;
using Microsoft.Toolkit.Uwp.Notifications;

namespace GloriousBatteryMonitor
{
    public partial class BatteryMonitorForm : Form
    {
        private System.Windows.Forms.Timer _refreshTimer = new System.Windows.Forms.Timer();
        private int _lastKnownBatteryLevel = -1;
        private bool _wasCharging = false;
        private bool _lowBatteryNotified = false;
        private string _lastConnectedDeviceName = "Device";

        public BatteryMonitorForm()
        {
            InitializeComponent();
            SetupAppIcon();
            LoadSettings();
        }

        private void BatteryMonitorForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.StartMinimized)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
                this.ShowInTaskbar = false;
            }
            DisplayLastChargeInfo();
            Task.Run(CheckBatteryStatusAsync);
        }

        private void SetupAppIcon()
        {
            this.Icon = IconFactory.CreateBatteryIcon(100, false, true);
            notifyIcon1.Icon = this.Icon;
        }

        private void LoadSettings()
        {
            _refreshTimer.Interval = Properties.Settings.Default.UpdateIntervalSeconds * 1000;
            _refreshTimer.Tick += async (s, args) => await CheckBatteryStatusAsync();
            _refreshTimer.Start();
            Debug.WriteLine($"Settings loaded.\n" +
                $"  Interval: {_refreshTimer.Interval}ms\n" +
                $"  Threshold: {Properties.Settings.Default.NotificationThreshold}%\n" +
                $"  Launch at Startup: {Properties.Settings.Default.StartWithWindows}\n" +
                $"  Start Minimized: {Properties.Settings.Default.StartMinimized}\n" +
                $"  Close to Tray: {Properties.Settings.Default.CloseToTray}");
        }

        private void DisplayLastChargeInfo()
        {
            string lastChargeTimeStr = Properties.Settings.Default.LastChargeTimeISO;
            int lastChargeLevel = Properties.Settings.Default.LastChargeLevel;

            if (!string.IsNullOrEmpty(lastChargeTimeStr) && lastChargeLevel > 0)
            {
                if (DateTime.TryParse(lastChargeTimeStr, out DateTime lastChargeTime))
                {
                    lblLastCharge.Text = $"Last charged to {lastChargeLevel}% on {lastChargeTime:D} at {lastChargeTime:t}";
                }
                else
                {
                    lblLastCharge.Text = "Last charge time: Not yet recorded.";
                }
            }
            else
            {
                lblLastCharge.Text = "Last charge time: Not yet recorded.";
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await CheckBatteryStatusAsync();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var settingsForm = new SettingsForm())
            {
                if (settingsForm.ShowDialog(this) == DialogResult.OK)
                {
                    Debug.WriteLine("Settings saved. Reloading timer.");
                    _refreshTimer.Stop();
                    LoadSettings();
                    Task.Run(CheckBatteryStatusAsync);
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var aboutForm = new AboutForm())
            {
                aboutForm.ShowDialog(this);
            }
        }

        private async void refreshNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await CheckBatteryStatusAsync();
        }

        private void BatteryMonitorForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.ShowInTaskbar = false;
            }
        }

        private void BatteryMonitorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && Properties.Settings.Default.CloseToTray)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
                this.ShowInTaskbar = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowForm();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowForm()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private async Task CheckBatteryStatusAsync()
        {
            Invoke((Action)(() =>
            {
                lblStatus.Text = "Checking for supported devices...";
                btnRefresh.Enabled = false;
            }));

            var result = await DeviceManager.GetCurrentBatteryStatus();

            Invoke((Action)(() =>
            {
                if (!result.IsConnected)
                {
                    lblStatus.Text = "No supported device found.";
                    lblDeviceName.Text = "Mouse: --";
                    lblBatteryLevel.Text = "Battery Level: --";
                    lblChargingStatus.Text = "Charging: --";
                    batteryProgressBar.Value = 0;
                    this.Icon = SystemIcons.Warning;
                    notifyIcon1.Icon = SystemIcons.Warning;
                    notifyIcon1.Text = "No supported device found";
                    _lastKnownBatteryLevel = -1;
                    _wasCharging = false;
                }
                else
                {
                    _lastConnectedDeviceName = result.DeviceName;
                    int batteryLevel = result.BatteryLevel;
                    bool isCharging = result.IsCharging;

                    if (result.IsTransient && _lastKnownBatteryLevel > 10)
                    {
                        batteryLevel = _lastKnownBatteryLevel > 0 ? _lastKnownBatteryLevel : 0;
                        lblStatus.Text = $"{result.DeviceName} ({result.ConnectionType}) found, but failed to get status.\n(Is the device on?)";
                        lblBatteryLevel.Text = $"Battery Level: {batteryLevel}% (Last known)";
                        notifyIcon1.Text = $"Battery: {batteryLevel}% (Last known)" + (isCharging ? " (Charging)" : "");
                    }
                    else
                    {
                        if (_wasCharging && !isCharging)
                        {
                            Properties.Settings.Default.LastChargeLevel = batteryLevel;
                            Properties.Settings.Default.LastChargeTimeISO = DateTime.Now.ToString("o");
                            Properties.Settings.Default.Save();
                            DisplayLastChargeInfo();
                            Debug.WriteLine($"Saved last charge: {batteryLevel}% at {DateTime.Now}");
                        }

                        lblStatus.Text = $"Device found ({result.ConnectionType}). Last updated: {DateTime.Now:T}";
                        lblBatteryLevel.Text = $"Battery Level: {batteryLevel}%";
                        _lastKnownBatteryLevel = batteryLevel;
                        notifyIcon1.Text = $"{result.DeviceName}: {batteryLevel}%" + (isCharging ? " (Charging)" : "");
                    }

                    _wasCharging = isCharging;

                    lblDeviceName.Text = $"Mouse: {result.DeviceName}";
                    batteryProgressBar.Value = batteryLevel;
                    batteryProgressBar.IsCharging = isCharging;
                    lblChargingStatus.Text = isCharging ? "Charging: Yes" : "Charging: No";

                    Icon newIcon = IconFactory.CreateBatteryIcon(batteryLevel, isCharging);
                    Icon? oldIcon = this.Icon;
                    this.Icon = newIcon;
                    notifyIcon1.Icon = newIcon;
                    if (oldIcon != SystemIcons.Application && oldIcon != SystemIcons.Warning)
                    {
                        oldIcon?.Dispose();
                    }

                    HandleLowBatteryNotification(batteryLevel, isCharging);
                }
                btnRefresh.Enabled = true;
            }));
        }

        private void HandleLowBatteryNotification(int currentLevel, bool isCharging)
        {
            int threshold = Properties.Settings.Default.NotificationThreshold;

            if (threshold != 100 && !isCharging && currentLevel > 0 && currentLevel <= threshold)
            {
                if (!_lowBatteryNotified)
                {
                    new ToastContentBuilder()
                        .AddText("Low Battery Warning")
                        .AddText($"{_lastConnectedDeviceName} battery is at {currentLevel}%. Charging recommended.")
                        .Show();
                    _lowBatteryNotified = true;
                }
            }
            else
            {
                _lowBatteryNotified = false;
            }
        }
    }
}