using System;
using System.Collections.Generic;
using System.Drawing;

namespace FractalGeneratorProject
{
    internal abstract class Fractal
    {
        public string name;
        public List<Segment> segments;

        public Fractal(String name)
        {
            this.name = name;
            segments = new List<Segment>();
        }

        public abstract void DrawFractalWithDepth(Graphics g, Point c, float scale, PointF offset, int depth);
        public void ClearSegments()
        {
            segments.Clear();
        }
    }
}
