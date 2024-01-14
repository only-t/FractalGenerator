using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FractalGeneratorProject
{
    internal class FractalTree : Fractal
    {
        List<Segment> segments;

        public FractalTree(FractalGenerator mainform) : base("Fractal Canopy", mainform)
        {
            segments = new List<Segment>();
            TreeNode tree = new TreeNode();
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
                PointF p1 = new PointF(c.X, c.Y);
                PointF p2 = new PointF(c.X, c.Y - mainform.segmentSize);
                new_segments.Add(new Segment(p1, p2));
            }
            else
            {
                for(int i = segments.Count/2; i < segments.Count; i++)
                {
                    Segment seg = segments[i];
                    float distance_ratio = 1 + mainform.currentTreeRatio;
                    PointF left_p = new PointF(
                        seg.x1 * (1 - distance_ratio) + seg.x2 * distance_ratio,
                        seg.y1 * (1 - distance_ratio) + seg.y2 * distance_ratio
                    );

                    left_p = RotatePointF(left_p, new PointF(seg.x2, seg.y2), mainform.currentTreeAngle);

                    PointF right_p = new PointF(
                        seg.x1 * (1 - distance_ratio) + seg.x2 * distance_ratio,
                        seg.y1 * (1 - distance_ratio) + seg.y2 * distance_ratio
                    );

                    right_p = RotatePointF(right_p, new PointF(seg.x2, seg.y2), -mainform.currentTreeAngle);

                    Segment new_seg1 = new Segment(seg.x2, seg.y2, left_p.X, left_p.Y);
                    Segment new_seg2 = new Segment(seg.x2, seg.y2, right_p.X, right_p.Y);

                    new_segments.Add(new_seg1);
                    new_segments.Add(new_seg2);
                }
            }

            segments.AddRange(new_segments);

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
