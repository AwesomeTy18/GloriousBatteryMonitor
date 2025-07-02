using System.Drawing.Drawing2D;

namespace GloriousBatteryMonitor
{
    public static class IconFactory
    {
        public static Icon CreateBatteryIcon(int percentage, bool isCharging, bool isInitial = false)
        {
            // Create a 32x32 bitmap for the icon
            using (var bmp = new Bitmap(32, 32))
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Battery shell
                var batteryBrush = new SolidBrush(Color.FromArgb(200, 200, 200));
                g.FillRectangle(batteryBrush, 4, 8, 24, 16);
                g.FillRectangle(batteryBrush, 28, 12, 2, 8);

                if (!isInitial)
                {
                    // Battery level fill
                    Brush levelBrush;
                    if (isCharging)
                    {
                        levelBrush = Brushes.DodgerBlue;
                    }
                    else if (percentage <= 20)
                    {
                        levelBrush = Brushes.Red;
                    }
                    else if (percentage <= 50)
                    {
                        levelBrush = Brushes.Yellow;
                    }
                    else
                    {
                        levelBrush = Brushes.LimeGreen;
                    }
                    float fillWidth = 20.0f * (percentage / 100.0f);
                    g.FillRectangle(levelBrush, 6, 10, fillWidth, 12);
                }

                // Charging bolt
                if (isCharging)
                {
                    Point[] boltPoints = {
                        new Point(16, 10), new Point(12, 16), new Point(18, 16),
                        new Point(14, 22), new Point(20, 16), new Point(14, 16)
                    };
                    g.FillPolygon(Brushes.White, boltPoints);
                    g.DrawPolygon(new Pen(Color.Black, 1.5f), boltPoints);
                }

                // Convert bitmap to icon
                IntPtr hIcon = bmp.GetHicon();
                Icon newIcon = Icon.FromHandle(hIcon);
                return newIcon;
            }
        }
    }
}