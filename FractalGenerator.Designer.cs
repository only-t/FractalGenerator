namespace FractalGenerator
{
    partial class FractalGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FractalGenerator));
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.FractalPictureBox = new System.Windows.Forms.PictureBox();
            this.ControlsTable = new System.Windows.Forms.TableLayoutPanel();
            this.FractalChooseBox = new System.Windows.Forms.ComboBox();
            this.DepthSlider = new System.Windows.Forms.TrackBar();
            this.ScaleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FractalPictureBox)).BeginInit();
            this.ControlsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepthSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.FractalPictureBox);
            this.MainSplitContainer.Panel1MinSize = 500;
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.ControlsTable);
            this.MainSplitContainer.Panel2MinSize = 200;
            this.MainSplitContainer.Size = new System.Drawing.Size(800, 450);
            this.MainSplitContainer.SplitterDistance = 500;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // FractalPictureBox
            // 
            this.FractalPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FractalPictureBox.Location = new System.Drawing.Point(0, 0);
            this.FractalPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.FractalPictureBox.Name = "FractalPictureBox";
            this.FractalPictureBox.Size = new System.Drawing.Size(496, 446);
            this.FractalPictureBox.TabIndex = 0;
            this.FractalPictureBox.TabStop = false;
            this.FractalPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.FractalPictureBox_Paint);
            this.FractalPictureBox.Resize += new System.EventHandler(this.FractalPictureBox_Resize);
            // 
            // ControlsTable
            // 
            this.ControlsTable.AutoSize = true;
            this.ControlsTable.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ControlsTable.ColumnCount = 3;
            this.ControlsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ControlsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.ControlsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ControlsTable.Controls.Add(this.FractalChooseBox, 1, 0);
            this.ControlsTable.Controls.Add(this.DepthSlider, 1, 2);
            this.ControlsTable.Controls.Add(this.ScaleLabel, 1, 1);
            this.ControlsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsTable.Location = new System.Drawing.Point(0, 0);
            this.ControlsTable.Margin = new System.Windows.Forms.Padding(0);
            this.ControlsTable.Name = "ControlsTable";
            this.ControlsTable.RowCount = 4;
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ControlsTable.Size = new System.Drawing.Size(292, 446);
            this.ControlsTable.TabIndex = 0;
            // 
            // FractalChooseBox
            // 
            this.FractalChooseBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FractalChooseBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FractalChooseBox.FormattingEnabled = true;
            this.FractalChooseBox.Items.AddRange(new object[] {
            "Koch Snowflake",
            "Sierpinski Triangle"});
            this.FractalChooseBox.Location = new System.Drawing.Point(84, 10);
            this.FractalChooseBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.FractalChooseBox.Name = "FractalChooseBox";
            this.FractalChooseBox.Size = new System.Drawing.Size(121, 21);
            this.FractalChooseBox.TabIndex = 0;
            this.FractalChooseBox.SelectionChangeCommitted += new System.EventHandler(this.FractalChooseBox_SelectionChangeCommitted);
            // 
            // DepthSlider
            // 
            this.DepthSlider.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DepthSlider.LargeChange = 1;
            this.DepthSlider.Location = new System.Drawing.Point(68, 66);
            this.DepthSlider.Margin = new System.Windows.Forms.Padding(0);
            this.DepthSlider.Minimum = 1;
            this.DepthSlider.Name = "DepthSlider";
            this.DepthSlider.Size = new System.Drawing.Size(154, 45);
            this.DepthSlider.TabIndex = 1;
            this.DepthSlider.Value = 1;
            this.DepthSlider.ValueChanged += new System.EventHandler(this.DepthSlider_ValueChanged);
            // 
            // ScaleLabel
            // 
            this.ScaleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ScaleLabel.AutoSize = true;
            this.ScaleLabel.Location = new System.Drawing.Point(125, 50);
            this.ScaleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ScaleLabel.Name = "ScaleLabel";
            this.ScaleLabel.Size = new System.Drawing.Size(39, 13);
            this.ScaleLabel.TabIndex = 2;
            this.ScaleLabel.Text = "Depth:";
            this.ScaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FractalGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainSplitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FractalGenerator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "FractalGenerator";
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            this.MainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FractalPictureBox)).EndInit();
            this.ControlsTable.ResumeLayout(false);
            this.ControlsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepthSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox FractalPictureBox;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.TableLayoutPanel ControlsTable;
        private System.Windows.Forms.ComboBox FractalChooseBox;
        private System.Windows.Forms.TrackBar DepthSlider;
        private System.Windows.Forms.Label ScaleLabel;
    }
}

