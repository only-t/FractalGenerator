using FractalGeneratorProject;
using System.Drawing;

namespace FractalGenerator
{
    internal class Triangle
    {
        public Segment[] segments = new Segment[3];
        public Triangle(PointF p1, PointF p2, PointF p3)
        {
            segments[0] = new Segment(p1, p2);
            segments[1] = new Segment(p2, p3);
            segments[2] = new Segment(p3, p1);
        }

        public Triangle(Segment s1, Segment s2, Segment s3)
        {
            segments[0] = s1;
            segments[1] = s2;
            segments[2] = s3;
        }
    }
}
