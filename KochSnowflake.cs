using System;
using System.Drawing;

namespace FractalGenerator
{
    internal class KochSnowflake : Fractal
    {
        public KochSnowflake() : base("Koch Snowflake") { }

        public override void DrawFractal(Graphics g, int depth)
        {
            if (depth <= 0)
            {
                return;
            }

            Pen pen = new Pen(Color.Black, 2);
            float a = 300;
            float h = (float)(a*Math.Sqrt(3))/2;
            float c_x = 300;
            float c_y = 300;

            PointF[] points = new PointF[] {
                new PointF(c_x, c_y - h*2/3),
                new PointF(c_x + a/2, c_y + h/3),
                new PointF(c_x - a/2, c_y + h/3),
                new PointF(c_x, c_y - h*2/3)
            };

            g.DrawLines(pen, points);

            DrawFractal(g, depth - 1);
        }
    }
}
