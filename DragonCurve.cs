using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace FractalGeneratorProject
{
    internal class DragonCurve : Fractal
    {
        private List<Segment> segments;

        public DragonCurve(FractalGenerator mainform) : base("Heighway Dragon Curve", mainform)
        {
            segments = new List<Segment>();
        }

        private PointF RotatePointF(PointF p, PointF c, int angle)
        {
            float rad = (float)(angle * Math.PI / 180);
            return new PointF(c.X + (float)(Math.Cos(rad) * (p.X - c.X) - Math.Sin(rad) * (p.Y - c.Y)),
                c.Y + (float)(Math.Sin(rad) * (p.X - c.X) + Math.Cos(rad) * (p.Y - c.Y)));
        }

        private void Draw(Graphics g, PointF c)
        {
            foreach (Segment seg in segments)
            {
                float scale = mainform.currentScale;
                (float, float) offset = mainform.offset;

                float x1 = seg.x1 - c.X;
                float y1 = seg.y1 - c.Y;
                float x2 = seg.x2 - c.X;
                float y2 = seg.y2 - c.Y;

                g.DrawLine(Pens.Black,
                    x1 * scale + c.X - offset.Item1,
                    y1 * scale + c.Y - offset.Item2,
                    x2 * scale + c.X - offset.Item1,
                    y2 * scale + c.Y - offset.Item2);
            }
        }

        public override void DrawFractalWithDepth(Graphics g, Point c, int depth)
        {
            if (depth <= 0)
            {
                Draw(g, c);
                return;
            }

            List<Segment> new_segments = new List<Segment>();

            if (segments.Count <= 0)
            {
                PointF p1 = new PointF(c.X + mainform.segmentSize / 2, c.Y);
                PointF p2 = new PointF(c.X - mainform.segmentSize / 2, c.Y);
                new_segments.Add(new Segment(p1, p2));
            }
            else
            {
                for(int i = 0; i < segments.Count; i++)
                {
                    PointF mid_p;
                    Segment seg = segments[i];
                    if (i%2 == 0)
                    {
                        mid_p = new PointF(seg.x1 + (seg.x2 - seg.x1) / 2, seg.y1 + (seg.y2 - seg.y1) / 2);
                        mid_p = RotatePointF(mid_p, new PointF(seg.x1, seg.y1), 45);

                        float x_delta = (mid_p.X - seg.x1) / (seg.length / 2);
                        float y_delta = (mid_p.Y - seg.y1) / (seg.length / 2);

                        mid_p.X += seg.length / 2 * ((float)Math.Sqrt(2) - 1) * x_delta;
                        mid_p.Y += seg.length / 2 * ((float)Math.Sqrt(2) - 1) * y_delta;
                    } else
                    {
                        mid_p = new PointF(seg.x1 + (seg.x2 - seg.x1) / 2, seg.y1 + (seg.y2 - seg.y1) / 2);
                        mid_p = RotatePointF(mid_p, new PointF(seg.x1, seg.y1), -45);

                        float x_delta = (mid_p.X - seg.x1) / (seg.length / 2);
                        float y_delta = (mid_p.Y - seg.y1) / (seg.length / 2);

                        mid_p.X += seg.length / 2  * ((float)Math.Sqrt(2) - 1) * x_delta;
                        mid_p.Y += seg.length / 2 * ((float)Math.Sqrt(2) - 1) * y_delta;
                    }

                    Segment new_seg1 = new Segment(seg.x1, seg.y1, mid_p.X, mid_p.Y);
                    Segment new_seg2 = new Segment(mid_p.X, mid_p.Y, seg.x2, seg.y2);

                    new_segments.Add(new_seg1);
                    new_segments.Add(new_seg2);
                }
            }

            segments = new_segments;

            DrawFractalWithDepth(g, c, depth - 1);
        }

        public override void Clear()
        {
            segments.Clear();
        }

        public override int GetSegmentAmount()
        {
            return segments.Count;
        }
    }
}
