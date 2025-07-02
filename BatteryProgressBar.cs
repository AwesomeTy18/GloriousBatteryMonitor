using System.Drawing.Drawing2D;

namespace GloriousBatteryMonitor
{
    public class BatteryProgressBar : Control
    {
        private int _value = 0;
        private bool _isCharging = false;

        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                this.Invalidate(); // Redraw when the value changes
            }
        }

        public bool IsCharging
        {
            get { return _isCharging; }
            set
            {
                _isCharging = value;
                this.Invalidate(); // Redraw when the charging status changes
            }
        }

        public BatteryProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.Clear(this.BackColor);

            Rectangle batteryRect = new Rectangle(0, 0, this.Width - 4, this.Height - 1);
            Rectangle tipRect = new Rectangle(this.Width - 4, this.Height / 4, 3, this.Height / 2);

            g.DrawRectangle(Pens.Gray, batteryRect);
            g.DrawRectangle(Pens.Gray, tipRect);

            if (this.Value > 0)
            {
                Brush levelBrush;
                if (this.IsCharging)
                {
                    levelBrush = Brushes.DodgerBlue;
                }
                else if (this.Value <= 20)
                {
                    levelBrush = Brushes.Red;
                }
                else if (this.Value <= 50)
                {
                    levelBrush = Brushes.Yellow;
                }
                else
                {
                    levelBrush = Brushes.LimeGreen;
                }

                float fillWidth = (batteryRect.Width - 4) * (this.Value / 100.0f);
                g.FillRectangle(levelBrush, batteryRect.X + 2, batteryRect.Y + 2, fillWidth, batteryRect.Height - 4);
            }

            //string percentageText = $"{this.Value}%";
            //using (Font font = new Font("Segoe UI", 10, FontStyle.Bold))
            //{
            //    SizeF textSize = g.MeasureString(percentageText, font);
            //    PointF textLocation = new PointF(
            //        (this.Width / 2) - (textSize.Width / 2) - 5,
            //        (this.Height / 2) - (textSize.Height / 2));
            //    g.DrawString(percentageText, font, Brushes.Black, textLocation);
            //}
        }
    }
}