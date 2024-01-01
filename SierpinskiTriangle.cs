using System.Collections.Generic;
using System;
using System.Drawing;
using FractalGenerator;

namespace FractalGeneratorProject
{
    internal class SierpinskiTriangle : Fractal
    {
        private const int BASE_SEG_LEN = 200;
        private List<Triangle> triangles;
        private FractalGenerator mainform;

        public SierpinskiTriangle(FractalGenerator mainform) : base("Sierpinski Triangle")
        {
            triangles = new List<Triangle>();
            this.mainform = mainform;
        }

        private void Draw(Graphics g, PointF c)
        {
            float scale = mainform.currentScale;
            (float, float) offset = mainform.offset;
            foreach (Triangle tri in triangles)
            {
                if(mainform.TriangleFillButton.Checked)
                {
                    Segment seg1 = tri.segments[0];
                    Segment seg2 = tri.segments[1];
                    Segment seg3 = tri.segments[2];

                    float x1 = seg1.x1 - c.X;
                    float y1 = seg1.y1 - c.Y;
                    float x2 = seg2.x1 - c.X;
                    float y2 = seg2.y1 - c.Y;
                    float x3 = seg3.x1 - c.X;
                    float y3 = seg3.y1 - c.Y;

                    g.FillPolygon(Brushes.Black, new PointF[] {
                        new PointF(x1*scale + c.X - offset.Item1, y1*scale + c.Y - offset.Item2),
                        new PointF(x2*scale + c.X - offset.Item1, y2*scale + c.Y - offset.Item2),
                        new PointF(x3*scale + c.X - offset.Item1, y3*scale + c.Y - offset.Item2)
                    });
                } else
                {
                    foreach (Segment seg in tri.segments)
                    {
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
            }
        }

        public override void DrawFractalWithDepth(Graphics g, Point c, int depth)
        {
            if (depth <= 0)
            {
                Draw(g, c);
                return;
            }

            List<Triangle> new_triangles = new List<Triangle>();

            if (triangles.Count <= 0)
            {
                float h = (float)(BASE_SEG_LEN * Math.Sqrt(3) / 2);
                PointF p1 = new PointF(c.X + BASE_SEG_LEN / 2, c.Y + h / 3);
                PointF p2 = new PointF(c.X - BASE_SEG_LEN / 2, c.Y + h / 3);
                PointF p3 = new PointF(c.X, c.Y - 2 * h / 3);
                new_triangles.Add(new Triangle(p1, p2, p3));
            }
            else
            {
                foreach (Triangle tri in triangles)
                {
                    Segment seg1 = tri.segments[0];
                    Segment seg2 = tri.segments[1];
                    Segment seg3 = tri.segments[2];
                    PointF inner_p1 = new PointF(seg1.x1 + (seg1.x2 - seg1.x1) / 2, seg1.y1 + (seg1.y2 - seg1.y1) / 2);
                    PointF inner_p2 = new PointF(seg2.x1 + (seg2.x2 - seg2.x1) / 2, seg2.y1 + (seg2.y2 - seg2.y1) / 2);
                    PointF inner_p3 = new PointF(seg3.x1 + (seg3.x2 - seg3.x1) / 2, seg3.y1 + (seg3.y2 - seg3.y1) / 2);

                    new_triangles.Add(new Triangle(new PointF(seg1.x1, seg1.y1), inner_p1, inner_p3));
                    new_triangles.Add(new Triangle(new PointF(seg2.x1, seg2.y1), inner_p2, inner_p1));
                    new_triangles.Add(new Triangle(new PointF(seg3.x1, seg3.y1), inner_p3, inner_p2));
                }
            }

            triangles = new_triangles;

            DrawFractalWithDepth(g, c, depth - 1);
        }

        public override void Clear()
        {
            triangles.Clear();
        }

        public override int GetSegmentAmount()
        {
            int segments = 0;
            foreach(Triangle tri in triangles)
            {
                segments += tri.segments.Length;
            }

            return segments;
        }
    }
}
