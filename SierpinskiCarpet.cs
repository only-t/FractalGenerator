using FractalGenerator;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace FractalGeneratorProject
{
    internal class SierpinskiCarpet : Fractal
    {
        private List<Square> squares;

        public SierpinskiCarpet(FractalGenerator mainform) : base("Sierpinski Carpet", mainform)
        {
            squares = new List<Square>();
        }

        private void Draw(Graphics g, PointF c)
        {
            float scale = mainform.currentScale;
            (float, float) offset = mainform.offset;
            foreach (Square sq in squares)
            {
                if (mainform.FillButton.Checked)
                {
                    Segment seg1 = sq.segments[0];
                    Segment seg2 = sq.segments[1];
                    Segment seg3 = sq.segments[2];
                    Segment seg4 = sq.segments[3];

                    float x1 = seg1.x1 - c.X;
                    float y1 = seg1.y1 - c.Y;
                    float x2 = seg2.x1 - c.X;
                    float y2 = seg2.y1 - c.Y;
                    float x3 = seg3.x1 - c.X;
                    float y3 = seg3.y1 - c.Y;
                    float x4 = seg4.x1 - c.X;
                    float y4 = seg4.y1 - c.Y;

                    g.FillPolygon(Brushes.Black, new PointF[] {
                        new PointF(x1*scale + c.X - offset.Item1, y1*scale + c.Y - offset.Item2),
                        new PointF(x2*scale + c.X - offset.Item1, y2*scale + c.Y - offset.Item2),
                        new PointF(x3*scale + c.X - offset.Item1, y3*scale + c.Y - offset.Item2),
                        new PointF(x4*scale + c.X - offset.Item1, y4*scale + c.Y - offset.Item2)
                    });
                }
                else
                {
                    foreach (Segment seg in sq.segments)
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

            List<Square> new_squares = new List<Square>();

            if (squares.Count <= 0)
            {
                PointF p1 = new PointF(c.X - mainform.segmentSize / 2, c.Y - mainform.segmentSize / 2);
                PointF p2 = new PointF(c.X + mainform.segmentSize / 2, c.Y - mainform.segmentSize / 2);
                PointF p3 = new PointF(c.X + mainform.segmentSize / 2, c.Y + mainform.segmentSize / 2);
                PointF p4 = new PointF(c.X - mainform.segmentSize / 2, c.Y + mainform.segmentSize / 2);
                new_squares.Add(new Square(p1, p2, p3, p4));
            }
            else
            {
                foreach (Square sq in squares)
                {
                    float seg_len = sq.segments[0].length;
                    PointF starting_subsquare_center_point = new PointF(
                        sq.segments[0].x1 + seg_len / 6,
                        sq.segments[0].y1 + seg_len / 6
                    );

                    for (int i = 0; i < 9; i++)
                    {
                        if(i == 4)
                        {
                            continue;
                        }

                        PointF subsquare_center = new PointF(
                            starting_subsquare_center_point.X + (seg_len/3)*(i%3),
                            starting_subsquare_center_point.Y + (seg_len/3)*(i/3)
                        );

                        PointF p1 = new PointF(subsquare_center.X - seg_len / 6, subsquare_center.Y - seg_len / 6);
                        PointF p2 = new PointF(subsquare_center.X + seg_len / 6, subsquare_center.Y - seg_len / 6);
                        PointF p3 = new PointF(subsquare_center.X + seg_len / 6, subsquare_center.Y + seg_len / 6);
                        PointF p4 = new PointF(subsquare_center.X - seg_len / 6, subsquare_center.Y + seg_len / 6);

                        new_squares.Add(new Square(p1, p2, p3, p4));
                    }
                }
            }

            squares = new_squares;

            DrawFractalWithDepth(g, c, depth - 1);
        }

        public override void Clear()
        {
            squares.Clear();
        }

        public override int GetSegmentAmount()
        {
            return squares.Count * 4;
        }
    }
}
