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
        //private System.Windows.Forms.ComboBox cmbChooseTheme;
        private System.Windows.Forms.Label label3;

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
            lblThreshold = new Label();
            numThreshold = new NumericUpDown();
            lblInterval = new Label();
            numInterval = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            chkStartWithWindows = new CheckBox();
            chkStartMinimized = new CheckBox();
            chkCloseToTray = new CheckBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numThreshold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numInterval).BeginInit();
            SuspendLayout();
            // 
            // lblThreshold
            // 
            lblThreshold.AutoSize = true;
            lblThreshold.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblThreshold.Location = new Point(14, 15);
            lblThreshold.Margin = new Padding(4, 0, 4, 0);
            lblThreshold.Name = "lblThreshold";
            lblThreshold.Size = new Size(185, 20);
            lblThreshold.TabIndex = 0;
            lblThreshold.Text = "Low Battery Notification at:";
            // 
            // numThreshold
            // 
            numThreshold.Font = new Font("Segoe UI Variable Display", 11.25F);
            numThreshold.Location = new Point(207, 13);
            numThreshold.Margin = new Padding(4, 3, 4, 3);
            numThreshold.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numThreshold.Name = "numThreshold";
            numThreshold.Size = new Size(71, 27);
            numThreshold.TabIndex = 1;
            numThreshold.TextAlign = HorizontalAlignment.Center;
            numThreshold.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblInterval
            // 
            lblInterval.AutoSize = true;
            lblInterval.Font = new Font("Segoe UI Variable Display", 11.25F);
            lblInterval.Location = new Point(14, 53);
            lblInterval.Margin = new Padding(4, 0, 4, 0);
            lblInterval.Name = "lblInterval";
            lblInterval.Size = new Size(111, 20);
            lblInterval.TabIndex = 2;
            lblInterval.Text = "Update Interval:";
            // 
            // numInterval
            // 
            numInterval.Font = new Font("Segoe UI Variable Display", 11.25F);
            numInterval.Location = new Point(133, 51);
            numInterval.Margin = new Padding(4, 3, 4, 3);
            numInterval.Maximum = new decimal(new int[] { 86400, 0, 0, 0 });
            numInterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numInterval.Name = "numInterval";
            numInterval.Size = new Size(71, 27);
            numInterval.TabIndex = 3;
            numInterval.TextAlign = HorizontalAlignment.Center;
            numInterval.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(139, 167);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 27);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(234, 167);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 27);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 11.25F);
            label1.Location = new Point(286, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(21, 20);
            label1.TabIndex = 6;
            label1.Text = "%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 11.25F);
            label2.Location = new Point(212, 53);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 7;
            label2.Text = "seconds";
            // 
            // chkStartWithWindows
            // 
            chkStartWithWindows.AutoSize = true;
            chkStartWithWindows.Font = new Font("Segoe UI Variable Display", 11.25F);
            chkStartWithWindows.Location = new Point(14, 84);
            chkStartWithWindows.Margin = new Padding(4, 3, 4, 3);
            chkStartWithWindows.Name = "chkStartWithWindows";
            chkStartWithWindows.Size = new Size(154, 24);
            chkStartWithWindows.TabIndex = 8;
            chkStartWithWindows.Text = "Start with Windows";
            chkStartWithWindows.UseVisualStyleBackColor = true;
            // 
            // chkStartMinimized
            // 
            chkStartMinimized.AutoSize = true;
            chkStartMinimized.Font = new Font("Segoe UI Variable Display", 11.25F);
            chkStartMinimized.Location = new Point(14, 114);
            chkStartMinimized.Margin = new Padding(4, 3, 4, 3);
            chkStartMinimized.Name = "chkStartMinimized";
            chkStartMinimized.Size = new Size(128, 24);
            chkStartMinimized.TabIndex = 9;
            chkStartMinimized.Text = "Start Minimized";
            chkStartMinimized.UseVisualStyleBackColor = true;
            // 
            // chkCloseToTray
            // 
            chkCloseToTray.AutoSize = true;
            chkCloseToTray.Font = new Font("Segoe UI Variable Display", 11.25F);
            chkCloseToTray.Location = new Point(14, 144);
            chkCloseToTray.Margin = new Padding(4, 3, 4, 3);
            chkCloseToTray.Name = "chkCloseToTray";
            chkCloseToTray.Size = new Size(115, 24);
            chkCloseToTray.TabIndex = 10;
            chkCloseToTray.Text = "Close to Tray";
            chkCloseToTray.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 11;
            // 
            // SettingsForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(329, 209);
            Controls.Add(chkCloseToTray);
            Controls.Add(chkStartMinimized);
            Controls.Add(chkStartWithWindows);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(numInterval);
            Controls.Add(lblInterval);
            Controls.Add(numThreshold);
            Controls.Add(lblThreshold);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)numThreshold).EndInit();
            ((System.ComponentModel.ISupportInitialize)numInterval).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
