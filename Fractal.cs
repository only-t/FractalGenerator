using System;
using System.Drawing;

namespace FractalGenerator
{
    internal abstract class Fractal
    {
        public string name;

        public Fractal(string name)
        {
            this.name = name;
        }

        public abstract void DrawFractal(Graphics g, int depth);
    }
}