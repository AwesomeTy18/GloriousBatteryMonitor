namespace GloriousBatteryMonitor
{
    partial class BatteryMonitorForm
    {
        private System.ComponentModel.IContainer components = null;
        private GloriousBatteryMonitor.BatteryProgressBar batteryProgressBar;
        private System.Windows.Forms.Label lblBattery;
        private System.Windows.Forms.Label lblChargingStatus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lblLastCharge;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            batteryProgressBar = new BatteryProgressBar();
            lblBattery = new Label();
            lblChargingStatus = new Label();
            btnRefresh = new Button();
            lblStatus = new Label();
            groupBoxStatus = new GroupBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            showToolStripMenuItem = new ToolStripMenuItem();
            refreshNowToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            lblLastCharge = new Label();
            groupBoxStatus.SuspendLayout();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // batteryProgressBar
            // 
            batteryProgressBar.IsCharging = false;
            batteryProgressBar.Location = new Point(17, 54);
            batteryProgressBar.Name = "batteryProgressBar";
            batteryProgressBar.Size = new Size(390, 23);
            batteryProgressBar.TabIndex = 1;
            batteryProgressBar.Text = "batteryProgressBar1";
            batteryProgressBar.Value = 0;
            // 
            // lblBattery
            // 
            lblBattery.AutoSize = true;
            lblBattery.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBattery.Location = new Point(17, 30);
            lblBattery.Name = "lblBattery";
            lblBattery.Size = new Size(35, 21);
            lblBattery.TabIndex = 2;
            lblBattery.Text = "--%";
            // 
            // lblChargingStatus
            // 
            lblChargingStatus.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChargingStatus.Location = new Point(332, 30);
            lblChargingStatus.Name = "lblChargingStatus";
            lblChargingStatus.Size = new Size(75, 21);
            lblChargingStatus.TabIndex = 3;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(332, 88);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 28);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(3, 19);
            lblStatus.Name = "lblStatus";
            lblStatus.Padding = new Padding(5);
            lblStatus.Size = new Size(384, 39);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Initializing...";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxStatus
            // 
            groupBoxStatus.Controls.Add(lblStatus);
            groupBoxStatus.Location = new Point(17, 122);
            groupBoxStatus.Name = "groupBoxStatus";
            groupBoxStatus.Size = new Size(390, 61);
            groupBoxStatus.TabIndex = 6;
            groupBoxStatus.TabStop = false;
            groupBoxStatus.Text = "Connection Status";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(424, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, aboutToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(180, 22);
            settingsToolStripMenuItem.Text = "&Settings...";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "&About...";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Text = "Glorious Battery Monitor";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showToolStripMenuItem, refreshNowToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(142, 76);
            // 
            // showToolStripMenuItem
            // 
            showToolStripMenuItem.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold);
            showToolStripMenuItem.Name = "showToolStripMenuItem";
            showToolStripMenuItem.Size = new Size(141, 22);
            showToolStripMenuItem.Text = "&Show";
            showToolStripMenuItem.Click += showToolStripMenuItem_Click;
            // 
            // refreshNowToolStripMenuItem
            // 
            refreshNowToolStripMenuItem.Name = "refreshNowToolStripMenuItem";
            refreshNowToolStripMenuItem.Size = new Size(141, 22);
            refreshNowToolStripMenuItem.Text = "&Refresh Now";
            refreshNowToolStripMenuItem.Click += refreshNowToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(138, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(141, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // lblLastCharge
            // 
            lblLastCharge.AutoSize = true;
            lblLastCharge.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastCharge.Location = new Point(17, 88);
            lblLastCharge.Name = "lblLastCharge";
            lblLastCharge.Size = new Size(171, 16);
            lblLastCharge.TabIndex = 9;
            lblLastCharge.Text = "Last charge time: Not recorded.";
            // 
            // BatteryMonitorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 197);
            Controls.Add(lblLastCharge);
            Controls.Add(groupBoxStatus);
            Controls.Add(btnRefresh);
            Controls.Add(lblChargingStatus);
            Controls.Add(lblBattery);
            Controls.Add(batteryProgressBar);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "BatteryMonitorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Glorious Battery Monitor";
            FormClosing += BatteryMonitorForm_FormClosing;
            Load += BatteryMonitorForm_Load;
            Resize += BatteryMonitorForm_Resize;
            groupBoxStatus.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}