using System;
using System.Drawing;

namespace FractalGeneratorProject
{
    internal class Segment
    {
        public float x1;
        public float y1;
        public float x2;
        public float y2;

        public float length;

        public Segment(float x1, float y1, float x2, float y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;

            this.length = (float)Math.Sqrt(Math.Pow(this.x2 - this.x1, 2) + Math.Pow(this.y2 - this.y1, 2));
        }
        public Segment(PointF p1, PointF p2)
        {
            this.x1 = p1.X;
            this.y1 = p1.Y;
            this.x2 = p2.X;
            this.y2 = p2.Y;

            this.length = (float)Math.Sqrt(Math.Pow(this.x2 - this.x1, 2) + Math.Pow(this.y2 - this.y1, 2));
        }
    }
}
