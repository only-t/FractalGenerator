using System;
using System.Drawing;

namespace FractalGeneratorProject
{
    internal abstract class Fractal
    {
        public string name;

        public Fractal(String name)
        {
            this.name = name;
        }

        public abstract void DrawFractalWithDepth(Graphics g, Point c, int depth);
        public abstract void Clear();
        public abstract int GetSegmentAmount();
    }
}
