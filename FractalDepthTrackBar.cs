using System.Drawing;
using System.Windows.Forms;

namespace FractalGeneratorProject
{
    internal class FractalDepthTrackBar : TrackBar
    {
        public FractalDepthTrackBar() : base()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // WM_PAINT
            if (m.Msg == 0x0F)
            {
                using (Graphics lgGraphics = Graphics.FromHwndInternal(m.HWnd))
                    OnPaintOver(new PaintEventArgs(lgGraphics, this.ClientRectangle));
            }
        }

        protected virtual void OnPaintOver(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (g != null)
            {
                Rectangle rec = new Rectangle(e.ClipRectangle.Location, e.ClipRectangle.Size);
                rec.Y = 27;
                rec.Height = 14;

                g.FillRectangle(new SolidBrush(Color.FromKnownColor(KnownColor.ControlDark)), rec);

                if(Maximum > 10)
                {
                    return;
                }

                float width = e.ClipRectangle.Width - 12;
                for (int i = 0; i < Maximum - 1; i++)
                {
                    g.DrawString((i + 1).ToString(), SystemFonts.DefaultFont, Brushes.White, (int)(width/10*i) + 8, 28);
                }

                g.DrawString("10", SystemFonts.DefaultFont, Brushes.White, (int)(8*width/9) + 6, 28);
            }
        }
    }
}
