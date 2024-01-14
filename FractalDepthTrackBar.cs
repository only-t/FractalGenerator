using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FractalGeneratorProject
{
    internal class FractalDepthTrackBar : TrackBar
    {
        public FractalDepthTrackBar() : base()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        protected override void WndProc(ref Message m)
        {
            // WM_MOUSEWHEEL
            if (m.Msg == 0x020a)
            {
                SendMessage(this.Parent.Handle, m.Msg, m.WParam, m.LParam);
                m.Result = IntPtr.Zero;
            }
            else
            {
                base.WndProc(ref m);

                // WM_PAINT
                if (m.Msg == 0x0F)
                {
                    using (Graphics lgGraphics = Graphics.FromHwndInternal(m.HWnd))
                        OnPaintOver(new PaintEventArgs(lgGraphics, this.ClientRectangle));
                }
            }
        }

        protected virtual void OnPaintOver(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (g != null)
            {
                Rectangle rec = new Rectangle(e.ClipRectangle.Location, e.ClipRectangle.Size)
                {
                    Y = 27,
                    Height = 14
                };

                g.FillRectangle(new SolidBrush(Color.FromKnownColor(KnownColor.ControlDark)), rec);

                if(Maximum <= 10)
                {
                    float width = e.ClipRectangle.Width - 12;
                    for (int i = 1; i <= Maximum; i += 3)
                    {
                        if (i < 10)
                        {
                            g.DrawString(i.ToString(), SystemFonts.DefaultFont, Brushes.White, (int)((i - 1) * width / Maximum) + 8, 28);
                        }
                        else
                        {
                            g.DrawString(i.ToString(), SystemFonts.DefaultFont, Brushes.White, (int)((i - 2) * width / (Maximum - 1)) + 6, 28);
                        }
                    }
                } else if(Maximum < 100)
                {
                    float width = e.ClipRectangle.Width - 14;
                    for (int i = 1; i <= Maximum; i += 7)
                    {
                        if (i < 10)
                        {
                            g.DrawString(i.ToString(), SystemFonts.DefaultFont, Brushes.White, (int)((i - 1) * width / Maximum) + 8, 28);
                        }
                        else
                        {
                            g.DrawString(i.ToString(), SystemFonts.DefaultFont, Brushes.White, (int)((i - 2) * width / (Maximum - 1)) + 2, 28);
                        }
                    }
                }
            }
        }
    }
}
