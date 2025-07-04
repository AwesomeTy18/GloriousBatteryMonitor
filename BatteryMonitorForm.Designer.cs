namespace GloriousBatteryMonitor
{
    partial class BatteryMonitorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private GloriousBatteryMonitor.BatteryProgressBar batteryProgressBar;
        private System.Windows.Forms.Label lblBatteryLevel;
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
        private System.Windows.Forms.Label lblDeviceName;
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
            lblTitle = new Label();
            batteryProgressBar = new BatteryProgressBar();
            lblBatteryLevel = new Label();
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
            lblDeviceName = new Label();
            lblLastCharge = new Label();
            groupBoxStatus.SuspendLayout();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(273, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Glorious Battery Monitor";
            // 
            // batteryProgressBar
            // 
            batteryProgressBar.IsCharging = false;
            batteryProgressBar.Location = new Point(17, 137);
            batteryProgressBar.Name = "batteryProgressBar";
            batteryProgressBar.Size = new Size(390, 23);
            batteryProgressBar.TabIndex = 1;
            batteryProgressBar.Text = "batteryProgressBar1";
            batteryProgressBar.Value = 0;
            // 
            // lblBatteryLevel
            // 
            lblBatteryLevel.AutoSize = true;
            lblBatteryLevel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBatteryLevel.Location = new Point(13, 113);
            lblBatteryLevel.Name = "lblBatteryLevel";
            lblBatteryLevel.Size = new Size(118, 21);
            lblBatteryLevel.TabIndex = 2;
            lblBatteryLevel.Text = "Battery Level: --";
            // 
            // lblChargingStatus
            // 
            lblChargingStatus.AutoSize = true;
            lblChargingStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChargingStatus.Location = new Point(13, 174);
            lblChargingStatus.Name = "lblChargingStatus";
            lblChargingStatus.Size = new Size(93, 21);
            lblChargingStatus.TabIndex = 3;
            lblChargingStatus.Text = "Charging: --";
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(332, 171);
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
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(3, 19);
            lblStatus.Name = "lblStatus";
            lblStatus.Padding = new Padding(5);
            lblStatus.Size = new Size(384, 39);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status: Initializing...";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxStatus
            // 
            groupBoxStatus.Controls.Add(lblStatus);
            groupBoxStatus.Location = new Point(17, 240);
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
            menuStrip1.Size = new Size(434, 24);
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
            settingsToolStripMenuItem.Size = new Size(125, 22);
            settingsToolStripMenuItem.Text = "&Settings...";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(125, 22);
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
            showToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
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
            // lblDeviceName
            // 
            lblDeviceName.AutoSize = true;
            lblDeviceName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeviceName.Location = new Point(13, 75);
            lblDeviceName.Name = "lblDeviceName";
            lblDeviceName.Size = new Size(76, 21);
            lblDeviceName.TabIndex = 8;
            lblDeviceName.Text = "Mouse: --";
            // 
            // lblLastCharge
            // 
            this.lblLastCharge.AutoSize = true;
            this.lblLastCharge.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblLastCharge.Location = new System.Drawing.Point(14, 202);
            this.lblLastCharge.Name = "lblLastCharge";
            this.lblLastCharge.Size = new System.Drawing.Size(176, 15);
            this.lblLastCharge.TabIndex = 9;
            this.lblLastCharge.Text = "Last charge time: Not recorded.";
            // 
            // BatteryMonitorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 312);
            Controls.Add(this.lblLastCharge);
            Controls.Add(lblDeviceName);
            Controls.Add(groupBoxStatus);
            Controls.Add(btnRefresh);
            Controls.Add(lblChargingStatus);
            Controls.Add(lblBatteryLevel);
            Controls.Add(batteryProgressBar);
            Controls.Add(lblTitle);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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