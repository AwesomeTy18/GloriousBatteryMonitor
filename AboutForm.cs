using System.Diagnostics;

namespace GloriousBatteryMonitor
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            lblVersion.Text = $"Version {Application.ProductVersion.Split('+')[0]}";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/AwesomeTy18/GloriousBatteryMonitor",
                UseShellExecute = true
            });
        }
    }
}