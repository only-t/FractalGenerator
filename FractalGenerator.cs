using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace FractalGeneratorProject
{
    public partial class FractalGenerator : Form, IMessageFilter
    {
        private int currentDepth = 1;
        private float currentScale = 1;
        private Fractal currentFractal;

        private bool dragging = false;
        private float dragging_start_x, dragging_start_y;
        private PointF _offset = new PointF(0, 0);
        private PointF offset = new PointF(0, 0);

        public FractalGenerator()
        {
            InitializeComponent(); // WinForms Designer Generated Code

            this.MinimumSize = new Size(850, 500);
            this.ZoomComboBox.SelectedIndex = 4;
            Application.AddMessageFilter(this);
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x20a)
            {
                // WM_MOUSEWHEEL, find the control at screen position m.LParam
                Point pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                IntPtr hWnd = WindowFromPoint(pos);
                if (hWnd != IntPtr.Zero && hWnd != m.HWnd && Control.FromHandle(hWnd) != null)
                {
                    SendMessage(hWnd, m.Msg, m.WParam, m.LParam);
                    return true;
                }
            }

            return false;
        }

        [DllImport("user32.dll")]
        private static extern IntPtr WindowFromPoint(Point pt);
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void FractalPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if(currentFractal != null)
            {
                PictureBox box = (PictureBox)sender;
                int w = box.Width/2;
                int h = box.Height/2;
                currentFractal.ClearSegments();
                currentFractal.DrawFractalWithDepth(g, new Point(w, h), currentScale, offset, currentDepth);
                this.FractalName.Text = "Name: " + currentFractal.name;
                this.FractalName.BorderSides = ToolStripStatusLabelBorderSides.Right;
                this.FractalSegAmount.Text = "Edges: " + currentFractal.segments.Count;
            }
        }

        private void FractalChooseBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox != null)
            {
                if(comboBox.SelectedItem.ToString() == "Koch Snowflake")
                {
                    currentFractal = new KochSnowflake();
                }
                else if(comboBox.SelectedItem.ToString() == "Koch Anti-Snowflake")
                {
                    currentFractal = new KochAntiSnowflake();
                }
                else if(comboBox.SelectedItem.ToString() == "Sierpinski Triangle")
                {
                    //currentFractal = new SierpinskiTriangle();
                }
            }

            this.FractalPictureBox.Refresh();
        }

        private void FractalPictureBox_Resize(object sender, EventArgs e)
        {
            this.FractalPictureBox.Refresh();
        }

        private void DepthSlider_ValueChanged(object sender, EventArgs e)
        {
            this.currentDepth = this.DepthSlider.Value;
            this.FractalPictureBox.Refresh();
        }

        private void ZoomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string scale = this.ZoomComboBox.SelectedItem.ToString();
            this.currentScale = float.Parse(scale.Substring(0, scale.Length - 1)) / 100;
            this.FractalPictureBox.Refresh();
        }

        private void FractalPictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if(e.Delta > 0 && this.ZoomComboBox.SelectedIndex < this.ZoomComboBox.Items.Count - 1)
            {
                this.ZoomComboBox.SelectedIndex++;
                this.FractalPictureBox.Refresh();
            } else if(e.Delta < 0 && this.ZoomComboBox.SelectedIndex > 0)
            {
                this.ZoomComboBox.SelectedIndex--;
            }
        }

        private void FractalPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragging_start_x = e.X;
            dragging_start_y = e.Y;
            _offset = offset;
        }

        private void FractalPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void FractalPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if(dragging)
            {
                offset.X = _offset.X + dragging_start_x - e.X;
                offset.Y = _offset.Y + dragging_start_y - e.Y;
            }

            this.FractalPictureBox.Refresh();
        }

        private void RestoreScaleButton_Click(object sender, EventArgs e)
        {
            offset.X = 0;
            offset.Y = 0;
            this.FractalPictureBox.Refresh();
        }
    }
}
