using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FractalGenerator
{
    public partial class FractalGenerator : Form
    {
        Fractal currentFractal;
        int currentDepth = 1;

        public FractalGenerator()
        {
            InitializeComponent(); // WinForms Designer Generated Code

            this.MinimumSize = new Size(850, 500);
        }

        private void FractalPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (currentFractal != null)
            {
                Graphics g = e.Graphics;
                g.Clear(Color.White);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                currentFractal.DrawFractal(g, currentDepth);
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
    }
}
