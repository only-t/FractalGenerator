using System;
using System.Drawing;

namespace FractalGeneratorProject
{
    internal abstract class Fractal
    {
        public string name;
        protected readonly FractalGenerator mainform;

        public Fractal(String name, FractalGenerator mainform)
        {
            this.name = name;
            this.mainform = mainform;
        }

        public abstract void DrawFractalWithDepth(Graphics g, Point c, int depth);
        public abstract void Clear();
        public abstract int GetSegmentAmount();
    }
}
