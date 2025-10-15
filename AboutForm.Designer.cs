namespace GloriousBatteryMonitor
{
    partial class AboutForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.LinkLabel linkLabel1;

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
            lblAppName = new Label();
            lblVersion = new Label();
            lblDescription = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.Location = new Point(14, 10);
            lblAppName.Margin = new Padding(4, 0, 4, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(236, 26);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Glorious Battery Monitor";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVersion.Location = new Point(16, 50);
            lblVersion.Margin = new Padding(4, 0, 4, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(84, 17);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "Version X.X.X";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(16, 90);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.MaximumSize = new Size(320, 35);
            lblDescription.Name = "lblDescription";
            lblDescription.TabIndex = 2;
            lblDescription.Text = "A lightweight utility to monitor the battery level of your wireless Glorious mouse.";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Variable Display", 9.75F);
            linkLabel1.Location = new Point(16, 127);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(94, 17);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Find on GitHub";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 154);
            Controls.Add(linkLabel1);
            Controls.Add(lblDescription);
            Controls.Add(lblVersion);
            Controls.Add(lblAppName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}