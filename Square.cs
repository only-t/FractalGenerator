using FractalGeneratorProject;
using System.Drawing;

namespace FractalGenerator
{
    internal class Square
    {
        public Segment[] segments = new Segment[4];
        public Square(PointF p1, PointF p2, PointF p3, PointF p4)
        {
            segments[0] = new Segment(p1, p2);
            segments[1] = new Segment(p2, p3);
            segments[2] = new Segment(p3, p4);
            segments[3] = new Segment(p4, p1);
        }

        public Square(Segment s1, Segment s2, Segment s3, Segment s4)
        {
            segments[0] = s1;
            segments[1] = s2;
            segments[2] = s3;
            segments[3] = s4;
        }
    }
}
