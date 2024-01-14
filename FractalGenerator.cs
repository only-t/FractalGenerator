using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace FractalGeneratorProject
{
    public partial class FractalGenerator : Form, IMessageFilter
    {
        private Fractal currentFractal;
        private bool dragging = false;
        private float draggingStartX, draggingStartY;
        private (float, float) _offset = (0, 0);

        public float currentTreeRatio = 0;
        public int currentTreeAngle = 0;
        public int currentDepth = 1;
        public float currentScale = 1;
        public int segmentSize = 100;
        public (float, float) offset = (0, 0);

        public FractalGenerator()
        {
            InitializeComponent(); // WinForms Designer Generated Code

            MinimumSize = new Size(850, 500);
            ZoomComboBox.SelectedIndex = 4;
            Application.AddMessageFilter(this);

            SegmentSizeNumeric.Controls.RemoveAt(0);
            TreeAngleNumeric.Controls.RemoveAt(0);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Opaque, true);
        }

        [DllImport("user32.dll")]
        private static extern IntPtr WindowFromPoint(Point pt);
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        public bool PreFilterMessage(ref Message m)
        {
            // WM_MOUSEWHEEL
            if (m.Msg == 0x20a)
            {
                // find the control at screen position m.LParam
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

        private void ShowSettings()
        {
            SegmentSizeLabel.Visible = true;
            SegmentSizeNumeric.Visible = true;
            ScaleLabel.Visible = true;
            DepthSlider.Visible = true;
        }

        private void FractalPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            if (currentFractal != null)
            {
                if(!(currentFractal is SierpinskiCarpet))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                }

                PictureBox box = (PictureBox)sender;
                int w = box.Width / 2;
                int h = box.Height / 2;
                g.DrawLine(Pens.LightGray,
                    w - 5 - offset.Item1,
                    h - offset.Item2,
                    w + 5 - offset.Item1,
                    h - offset.Item2
                );
                g.DrawLine(Pens.LightGray,
                    w - offset.Item1,
                    h - 5 - offset.Item2,
                    w - offset.Item1,
                    h + 5 - offset.Item2
                );

                currentFractal.Clear();
                currentFractal.DrawFractalWithDepth(g, new Point(w, h), currentDepth);
                FractalName.Text = "Name: " + currentFractal.name;
                FractalSegAmount.Text = "Edges: " + currentFractal.GetSegmentAmount();

                if (FractalName.BorderSides != ToolStripStatusLabelBorderSides.Right)
                {
                    FractalName.BorderSides = ToolStripStatusLabelBorderSides.Right;
                }
            }
        }

        private void FractalChooseBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                if(currentFractal == null)
                {
                    ShowSettings();
                }

                FillButton.Visible = false;
                FillButton.Enabled = false;
                FillButton.Checked = false;

                TreeAngleLabel.Visible = false;
                TreeAngleNumeric.Visible = false;
                TreeAngleNumeric.Enabled = false;
                TreeAngleTrackBar.Visible = false;

                TreeRatioLabel.Visible = false;
                TreeRatioNumeric.Visible = false;
                TreeRatioNumeric.Enabled = false;
                TreeRatioTrackBar.Visible = false;

                if (comboBox.SelectedItem.ToString() == "Koch Snowflake")
                {
                    if (DepthSlider.Value > 10)
                    {
                        DepthSlider.Value = 10;
                    }

                    DepthSlider.Maximum = 10;
                    currentFractal = new KochSnowflake(this);
                }
                else if (comboBox.SelectedItem.ToString() == "Koch Anti-Snowflake")
                {
                    if (DepthSlider.Value > 10)
                    {
                        DepthSlider.Value = 10;
                    }

                    DepthSlider.Maximum = 10;
                    currentFractal = new KochAntiSnowflake(this);
                }
                else if (comboBox.SelectedItem.ToString() == "Sierpinski Triangle")
                {
                    if (DepthSlider.Value > 10)
                    {
                        DepthSlider.Value = 10;
                    }

                    DepthSlider.Maximum = 10;
                    FillButton.Visible = true;
                    FillButton.Enabled = true;

                    currentFractal = new SierpinskiTriangle(this);
                }
                else if (comboBox.SelectedItem.ToString() == "Heighway Dragon Curve")
                {
                    DepthSlider.Maximum = 15;
                    currentFractal = new DragonCurve(this);
                }
                else if (comboBox.SelectedItem.ToString() == "Sierpinski Carpet")
                {
                    if (DepthSlider.Value > 10)
                    {
                        DepthSlider.Value = 10;
                    }

                    DepthSlider.Maximum = 10;
                    FillButton.Visible = true;
                    FillButton.Enabled = true;

                    currentFractal = new SierpinskiCarpet(this);
                } else if(comboBox.SelectedItem.ToString() == "Fractal Tree")
                {
                    DepthSlider.Maximum = 15;

                    TreeAngleLabel.Visible = true;
                    TreeAngleNumeric.Visible = true;
                    TreeAngleNumeric.Enabled = true;
                    TreeAngleTrackBar.Visible = true;

                    TreeRatioLabel.Visible = true;
                    TreeRatioNumeric.Visible = true;
                    TreeRatioNumeric.Enabled = true;
                    TreeRatioTrackBar.Visible = true;

                    currentFractal = new FractalTree(this);
                }
            }

            FractalPictureBox.Refresh();
        }

        private void FractalPictureBox_Resize(object sender, EventArgs e)
        {
            FractalPictureBox.Refresh();
        }

        private void DepthSlider_ValueChanged(object sender, EventArgs e)
        {
            currentDepth = DepthSlider.Value;
            FractalPictureBox.Refresh();
        }

        private void ZoomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string scale = ZoomComboBox.SelectedItem.ToString();
            currentScale = float.Parse(scale.Substring(0, scale.Length - 1)) / 100;
            FractalPictureBox.Refresh();
        }

        private void FractalPictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && ZoomComboBox.SelectedIndex < ZoomComboBox.Items.Count - 1)
            {
                ZoomComboBox.SelectedIndex++;
            }
            else if (e.Delta < 0 && ZoomComboBox.SelectedIndex > 0)
            {
                ZoomComboBox.SelectedIndex--;
            }
        }

        private void FractalPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            draggingStartX = e.X;
            draggingStartY = e.Y;
            _offset = offset;
        }

        private void FractalPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void FractalPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                offset.Item1 = _offset.Item1 + draggingStartX - e.X;
                offset.Item2 = _offset.Item2 + draggingStartY - e.Y;
            }

            FractalPictureBox.Refresh();
        }

        private void TriangleFillButton_CheckedChanged(object sender, EventArgs e)
        {
            FractalPictureBox.Refresh();
        }

        private void SegmentSizeNumeric_ValueChanged(object sender, EventArgs e)
        {
            segmentSize = (int)SegmentSizeNumeric.Value;
            FractalPictureBox.Refresh();
        }

        private void TreeAngleNumeric_ValueChanged(object sender, EventArgs e)
        {
            currentTreeAngle = (int)TreeAngleNumeric.Value;
            FractalPictureBox.Refresh();
        }

        private void TreeRatioNumeric_ValueChanged(object sender, EventArgs e)
        {
            currentTreeRatio = (float)TreeRatioNumeric.Value;
            FractalPictureBox.Refresh();
        }

        private void TreeRatioTrackBar_Scroll(object sender, EventArgs e)
        {
            Console.WriteLine(TreeRatioTrackBar.Value);
            TreeRatioNumeric.Value = new decimal((float)TreeRatioTrackBar.Value/20);
        }

        private void TreeAngleTrackBar_Scroll(object sender, EventArgs e)
        {
            Console.WriteLine(TreeAngleTrackBar.Value);
            TreeAngleNumeric.Value = TreeAngleTrackBar.Value;
        }

        private void RestoreScaleButton_Click(object sender, EventArgs e)
        {
            offset.Item1 = 0;
            offset.Item2 = 0;
            FractalPictureBox.Refresh();
        }
    }
}
