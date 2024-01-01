namespace FractalGeneratorProject
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
            this.BottomStripTable = new System.Windows.Forms.TableLayoutPanel();
            this.FractalInfoStrip = new System.Windows.Forms.StatusStrip();
            this.FractalName = new System.Windows.Forms.ToolStripStatusLabel();
            this.FractalSegAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.ZoomComboBox = new System.Windows.Forms.ComboBox();
            this.RestoreScaleButton = new System.Windows.Forms.Button();
            this.FractalPictureBox = new System.Windows.Forms.PictureBox();
            this.ControlsTable = new System.Windows.Forms.TableLayoutPanel();
            this.FractalChooseBox = new System.Windows.Forms.ComboBox();
            this.DepthSlider = new FractalGeneratorProject.FractalDepthTrackBar();
            this.ScaleLabel = new System.Windows.Forms.Label();
            this.TriangleFillButton = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.BottomStripTable.SuspendLayout();
            this.FractalInfoStrip.SuspendLayout();
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
            this.MainSplitContainer.Panel1.Controls.Add(this.BottomStripTable);
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
            // BottomStripTable
            // 
            this.BottomStripTable.ColumnCount = 3;
            this.BottomStripTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomStripTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.BottomStripTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.BottomStripTable.Controls.Add(this.FractalInfoStrip, 0, 0);
            this.BottomStripTable.Controls.Add(this.ZoomComboBox, 1, 0);
            this.BottomStripTable.Controls.Add(this.RestoreScaleButton, 2, 0);
            this.BottomStripTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomStripTable.Location = new System.Drawing.Point(0, 424);
            this.BottomStripTable.Margin = new System.Windows.Forms.Padding(0);
            this.BottomStripTable.Name = "BottomStripTable";
            this.BottomStripTable.RowCount = 1;
            this.BottomStripTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomStripTable.Size = new System.Drawing.Size(496, 22);
            this.BottomStripTable.TabIndex = 2;
            // 
            // FractalInfoStrip
            // 
            this.FractalInfoStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FractalInfoStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.FractalInfoStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FractalName,
            this.FractalSegAmount});
            this.FractalInfoStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.FractalInfoStrip.Location = new System.Drawing.Point(0, 0);
            this.FractalInfoStrip.Name = "FractalInfoStrip";
            this.FractalInfoStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.FractalInfoStrip.Size = new System.Drawing.Size(376, 22);
            this.FractalInfoStrip.SizingGrip = false;
            this.FractalInfoStrip.TabIndex = 1;
            this.FractalInfoStrip.Text = "FractalInfoStrip";
            // 
            // FractalName
            // 
            this.FractalName.Margin = new System.Windows.Forms.Padding(0);
            this.FractalName.Name = "FractalName";
            this.FractalName.Size = new System.Drawing.Size(0, 22);
            // 
            // FractalSegAmount
            // 
            this.FractalSegAmount.Margin = new System.Windows.Forms.Padding(0);
            this.FractalSegAmount.Name = "FractalSegAmount";
            this.FractalSegAmount.Size = new System.Drawing.Size(0, 22);
            // 
            // ZoomComboBox
            // 
            this.ZoomComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZoomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ZoomComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ZoomComboBox.FormattingEnabled = true;
            this.ZoomComboBox.Items.AddRange(new object[] {
            "10%",
            "20%",
            "50%",
            "75%",
            "100%",
            "125%",
            "150%",
            "200%",
            "300%",
            "400%",
            "600%",
            "800%",
            "1000%",
            "1500%",
            "2000%"});
            this.ZoomComboBox.Location = new System.Drawing.Point(376, 0);
            this.ZoomComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.ZoomComboBox.Name = "ZoomComboBox";
            this.ZoomComboBox.Size = new System.Drawing.Size(60, 21);
            this.ZoomComboBox.TabIndex = 2;
            this.ZoomComboBox.SelectedIndexChanged += new System.EventHandler(this.ZoomComboBox_SelectedIndexChanged);
            // 
            // RestoreScaleButton
            // 
            this.RestoreScaleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RestoreScaleButton.FlatAppearance.BorderSize = 0;
            this.RestoreScaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RestoreScaleButton.Location = new System.Drawing.Point(436, 0);
            this.RestoreScaleButton.Margin = new System.Windows.Forms.Padding(0);
            this.RestoreScaleButton.Name = "RestoreScaleButton";
            this.RestoreScaleButton.Size = new System.Drawing.Size(60, 22);
            this.RestoreScaleButton.TabIndex = 3;
            this.RestoreScaleButton.Text = "Restore";
            this.RestoreScaleButton.UseVisualStyleBackColor = true;
            this.RestoreScaleButton.Click += new System.EventHandler(this.RestoreScaleButton_Click);
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
            this.FractalPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FractalPictureBox_MouseDown);
            this.FractalPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FractalPictureBox_MouseMove);
            this.FractalPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FractalPictureBox_MouseUp);
            this.FractalPictureBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.FractalPictureBox_MouseWheel);
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
            this.ControlsTable.Controls.Add(this.TriangleFillButton, 1, 3);
            this.ControlsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsTable.Location = new System.Drawing.Point(0, 0);
            this.ControlsTable.Margin = new System.Windows.Forms.Padding(0);
            this.ControlsTable.Name = "ControlsTable";
            this.ControlsTable.RowCount = 4;
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
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
            "Koch Anti-Snowflake",
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
            this.ScaleLabel.Location = new System.Drawing.Point(121, 50);
            this.ScaleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ScaleLabel.Name = "ScaleLabel";
            this.ScaleLabel.Size = new System.Drawing.Size(48, 13);
            this.ScaleLabel.TabIndex = 2;
            this.ScaleLabel.Text = "Iteration:";
            this.ScaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TriangleFillButton
            // 
            this.TriangleFillButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TriangleFillButton.AutoSize = true;
            this.TriangleFillButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TriangleFillButton.Location = new System.Drawing.Point(123, 116);
            this.TriangleFillButton.Margin = new System.Windows.Forms.Padding(0);
            this.TriangleFillButton.Name = "TriangleFillButton";
            this.TriangleFillButton.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.TriangleFillButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TriangleFillButton.Size = new System.Drawing.Size(43, 26);
            this.TriangleFillButton.TabIndex = 3;
            this.TriangleFillButton.Text = "Fill";
            this.TriangleFillButton.UseVisualStyleBackColor = true;
            this.TriangleFillButton.Visible = false;
            this.TriangleFillButton.CheckedChanged += new System.EventHandler(this.TriangleFillButton_CheckedChanged);
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
            this.BottomStripTable.ResumeLayout(false);
            this.BottomStripTable.PerformLayout();
            this.FractalInfoStrip.ResumeLayout(false);
            this.FractalInfoStrip.PerformLayout();
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
        private FractalDepthTrackBar DepthSlider;
        private System.Windows.Forms.Label ScaleLabel;
        private System.Windows.Forms.StatusStrip FractalInfoStrip;
        private System.Windows.Forms.ToolStripStatusLabel FractalName;
        private System.Windows.Forms.ToolStripStatusLabel FractalSegAmount;
        private System.Windows.Forms.TableLayoutPanel BottomStripTable;
        private System.Windows.Forms.ComboBox ZoomComboBox;
        private System.Windows.Forms.Button RestoreScaleButton;
        public System.Windows.Forms.CheckBox TriangleFillButton;
    }
}

