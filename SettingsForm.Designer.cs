namespace GloriousBatteryMonitor
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.NumericUpDown numThreshold;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkStartWithWindows;
        private System.Windows.Forms.CheckBox chkStartMinimized;
        private System.Windows.Forms.CheckBox chkCloseToTray;

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
            this.lblThreshold = new System.Windows.Forms.Label();
            this.numThreshold = new System.Windows.Forms.NumericUpDown();
            this.lblInterval = new System.Windows.Forms.Label();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkStartWithWindows = new System.Windows.Forms.CheckBox();
            this.chkStartMinimized = new System.Windows.Forms.CheckBox();
            this.chkCloseToTray = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreshold.Location = new System.Drawing.Point(12, 23);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(202, 20);
            this.lblThreshold.TabIndex = 0;
            this.lblThreshold.Text = "Low Battery Notification at:";
            // 
            // numThreshold
            // 
            this.numThreshold.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.numThreshold.Location = new System.Drawing.Point(220, 21);
            this.numThreshold.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numThreshold.Name = "numThreshold";
            this.numThreshold.Size = new System.Drawing.Size(61, 27);
            this.numThreshold.TabIndex = 1;
            this.numThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblInterval.Location = new System.Drawing.Point(12, 67);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(115, 20);
            this.lblInterval.TabIndex = 2;
            this.lblInterval.Text = "Update Interval:";
            // 
            // numInterval
            // 
            this.numInterval.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.numInterval.Location = new System.Drawing.Point(220, 65);
            this.numInterval.Maximum = new decimal(new int[] {
            86400, // max every 24h
            0,
            0,
            0});
            this.numInterval.Minimum = new decimal(new int[] {
            1, // min every 1s
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(61, 27);
            this.numInterval.TabIndex = 3;
            this.numInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(186, 205);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(267, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.Location = new System.Drawing.Point(287, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label2.Location = new System.Drawing.Point(287, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "seconds";
            // 
            // chkStartWithWindows
            // 
            this.chkStartWithWindows.AutoSize = true;
            this.chkStartWithWindows.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.chkStartWithWindows.Location = new System.Drawing.Point(16, 110);
            this.chkStartWithWindows.Name = "chkStartWithWindows";
            this.chkStartWithWindows.Size = new System.Drawing.Size(158, 24);
            this.chkStartWithWindows.TabIndex = 8;
            this.chkStartWithWindows.Text = "Start with Windows";
            this.chkStartWithWindows.UseVisualStyleBackColor = true;
            // 
            // chkStartMinimized
            // 
            this.chkStartMinimized.AutoSize = true;
            this.chkStartMinimized.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.chkStartMinimized.Location = new System.Drawing.Point(16, 140);
            this.chkStartMinimized.Name = "chkStartMinimized";
            this.chkStartMinimized.Size = new System.Drawing.Size(133, 24);
            this.chkStartMinimized.TabIndex = 9;
            this.chkStartMinimized.Text = "Start Minimized";
            this.chkStartMinimized.UseVisualStyleBackColor = true;
            //
            // chkCloseToTray
            //
            this.chkCloseToTray.AutoSize = true;
            this.chkCloseToTray.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.chkCloseToTray.Location = new System.Drawing.Point(16, 170);
            this.chkCloseToTray.Name = "chkCloseToTray";
            this.chkCloseToTray.Size = new System.Drawing.Size(225, 24);
            this.chkCloseToTray.TabIndex = 10;
            this.chkCloseToTray.Text = "Close to Tray";
            this.chkCloseToTray.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(359, 240);
            this.Controls.Add(this.chkCloseToTray);
            this.Controls.Add(this.chkStartMinimized);
            this.Controls.Add(this.chkStartWithWindows);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numInterval);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.numThreshold);
            this.Controls.Add(this.lblThreshold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
