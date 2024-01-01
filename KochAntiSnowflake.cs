using System;
using System.Collections.Generic;
using System.Drawing;

namespace FractalGeneratorProject
{
    internal class KochAntiSnowflake : Fractal
    {
        private const int BASE_SEG_LEN = 200;

        public KochAntiSnowflake() : base("Koch Anti-Snowflake") { }

        private PointF RotatePointF(PointF p, PointF c, int angle)
        {
            float rad = (float)(angle * Math.PI / 180);
            return new PointF(c.X + (float)(Math.Cos(rad) * (p.X - c.X) - Math.Sin(rad) * (p.Y - c.Y)),
                c.Y + (float)(Math.Sin(rad) * (p.X - c.X) + Math.Cos(rad) * (p.Y - c.Y)));
        }

        private void Draw(Graphics g, PointF c, PointF offset, float scale)
        {
            foreach (Segment seg in segments)
            {
                float x1 = seg.x1 - c.X;
                float y1 = seg.y1 - c.Y;
                float x2 = seg.x2 - c.X;
                float y2 = seg.y2 - c.Y;

                float offset_x = -offset.X;
                float offset_y = -offset.Y;

                g.DrawLine(Pens.Black,
                    x1 * scale + c.X + offset_x,
                    y1 * scale + c.Y + offset_y,
                    x2 * scale + c.X + offset_x,
                    y2 * scale + c.Y + offset_y);
            }
        }

        public override void DrawFractalWithDepth(Graphics g, Point c, float scale, PointF offset, int depth)
        {
            if (depth <= 0)
            {
                Draw(g, c, offset, scale);
                return;
            }

            List<Segment> new_segments = new List<Segment>();

            if (segments.Count <= 0)
            {
                float h = (float)(BASE_SEG_LEN * Math.Sqrt(3) / 2);
                PointF p1 = new PointF(c.X + BASE_SEG_LEN / 2, c.Y + h / 3);
                PointF p2 = new PointF(c.X - BASE_SEG_LEN / 2, c.Y + h / 3);
                PointF p3 = new PointF(c.X, c.Y - 2 * h / 3);
                new_segments.Add(new Segment(p1, p2));
                new_segments.Add(new Segment(p2, p3));
                new_segments.Add(new Segment(p3, p1));
            }
            else
            {
                foreach (Segment seg in segments)
                {
                    PointF p1 = new PointF(seg.x1 + (seg.x2 - seg.x1) / 3, seg.y1 + (seg.y2 - seg.y1) / 3);
                    PointF p2 = RotatePointF(new PointF(seg.x1, seg.y1), p1, -120);
                    PointF p3 = new PointF(seg.x2 + (seg.x1 - seg.x2) / 3, seg.y2 + (seg.y1 - seg.y2) / 3);

                    new_segments.Add(new Segment(seg.x1, seg.y1, p1.X, p1.Y));
                    new_segments.Add(new Segment(p1.X, p1.Y, p2.X, p2.Y));
                    new_segments.Add(new Segment(p2.X, p2.Y, p3.X, p3.Y));
                    new_segments.Add(new Segment(p3.X, p3.Y, seg.x2, seg.y2));
                }
            }

            segments = new_segments;

            DrawFractalWithDepth(g, c, scale, offset, depth - 1);
        }
    }
}
