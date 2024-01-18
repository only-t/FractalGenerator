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
            this.DisplayTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.BottomStripTable = new System.Windows.Forms.TableLayoutPanel();
            this.FractalInfoStrip = new System.Windows.Forms.StatusStrip();
            this.FractalName = new System.Windows.Forms.ToolStripStatusLabel();
            this.FractalSegAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.ZoomComboBox = new System.Windows.Forms.ComboBox();
            this.RestoreScaleButton = new System.Windows.Forms.Button();
            this.FractalPictureBox = new System.Windows.Forms.PictureBox();
            this.ControlsTable = new System.Windows.Forms.TableLayoutPanel();
            this.FractalChooseBox = new System.Windows.Forms.ComboBox();
            this.ScaleLabel = new System.Windows.Forms.Label();
            this.FillButton = new System.Windows.Forms.CheckBox();
            this.SegmentSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.SegmentSizeLabel = new System.Windows.Forms.Label();
            this.TreeAngleLabel = new System.Windows.Forms.Label();
            this.TreeRatioLabel = new System.Windows.Forms.Label();
            this.TreeRatioNumeric = new System.Windows.Forms.NumericUpDown();
            this.TreeAngleTrackBar = new System.Windows.Forms.TrackBar();
            this.TreeAngleNumeric = new System.Windows.Forms.NumericUpDown();
            this.TreeRatioTrackBar = new System.Windows.Forms.TrackBar();
            this.DepthSlider = new FractalGeneratorProject.FractalDepthTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.DisplayTableLayout.SuspendLayout();
            this.BottomStripTable.SuspendLayout();
            this.FractalInfoStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FractalPictureBox)).BeginInit();
            this.ControlsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentSizeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreeRatioNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreeAngleTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreeAngleNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreeRatioTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.MainSplitContainer.IsSplitterFixed = true;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.DisplayTableLayout);
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
            // DisplayTableLayout
            // 
            this.DisplayTableLayout.ColumnCount = 1;
            this.DisplayTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DisplayTableLayout.Controls.Add(this.BottomStripTable, 0, 1);
            this.DisplayTableLayout.Controls.Add(this.FractalPictureBox, 0, 0);
            this.DisplayTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayTableLayout.Location = new System.Drawing.Point(0, 0);
            this.DisplayTableLayout.Name = "DisplayTableLayout";
            this.DisplayTableLayout.RowCount = 1;
            this.DisplayTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DisplayTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DisplayTableLayout.Size = new System.Drawing.Size(496, 446);
            this.DisplayTableLayout.TabIndex = 5;
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
            this.BottomStripTable.Location = new System.Drawing.Point(0, 426);
            this.BottomStripTable.Margin = new System.Windows.Forms.Padding(0);
            this.BottomStripTable.Name = "BottomStripTable";
            this.BottomStripTable.RowCount = 1;
            this.BottomStripTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomStripTable.Size = new System.Drawing.Size(496, 20);
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
            this.FractalInfoStrip.Size = new System.Drawing.Size(376, 20);
            this.FractalInfoStrip.SizingGrip = false;
            this.FractalInfoStrip.TabIndex = 1;
            this.FractalInfoStrip.Text = "FractalInfoStrip";
            // 
            // FractalName
            // 
            this.FractalName.Margin = new System.Windows.Forms.Padding(0);
            this.FractalName.Name = "FractalName";
            this.FractalName.Size = new System.Drawing.Size(0, 20);
            // 
            // FractalSegAmount
            // 
            this.FractalSegAmount.Margin = new System.Windows.Forms.Padding(0);
            this.FractalSegAmount.Name = "FractalSegAmount";
            this.FractalSegAmount.Size = new System.Drawing.Size(0, 20);
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
            this.RestoreScaleButton.Size = new System.Drawing.Size(60, 20);
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
            this.FractalPictureBox.Size = new System.Drawing.Size(496, 426);
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
            this.ControlsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ControlsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ControlsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ControlsTable.Controls.Add(this.FractalChooseBox, 1, 1);
            this.ControlsTable.Controls.Add(this.DepthSlider, 1, 3);
            this.ControlsTable.Controls.Add(this.ScaleLabel, 1, 2);
            this.ControlsTable.Controls.Add(this.FillButton, 0, 3);
            this.ControlsTable.Controls.Add(this.SegmentSizeNumeric, 1, 5);
            this.ControlsTable.Controls.Add(this.SegmentSizeLabel, 1, 4);
            this.ControlsTable.Controls.Add(this.TreeAngleLabel, 1, 6);
            this.ControlsTable.Controls.Add(this.TreeRatioLabel, 1, 9);
            this.ControlsTable.Controls.Add(this.TreeRatioNumeric, 1, 10);
            this.ControlsTable.Controls.Add(this.TreeAngleTrackBar, 1, 8);
            this.ControlsTable.Controls.Add(this.TreeAngleNumeric, 1, 7);
            this.ControlsTable.Controls.Add(this.TreeRatioTrackBar, 1, 11);
            this.ControlsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsTable.Location = new System.Drawing.Point(0, 0);
            this.ControlsTable.Margin = new System.Windows.Forms.Padding(0);
            this.ControlsTable.Name = "ControlsTable";
            this.ControlsTable.RowCount = 12;
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ControlsTable.Size = new System.Drawing.Size(292, 446);
            this.ControlsTable.TabIndex = 0;
            // 
            // FractalChooseBox
            // 
            this.FractalChooseBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FractalChooseBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FractalChooseBox.FormattingEnabled = true;
            this.FractalChooseBox.Items.AddRange(new object[] {
            "Koch Snowflake",
            "Koch Anti-Snowflake",
            "Sierpinski Triangle",
            "Sierpinski Carpet",
            "Heighway Dragon Curve",
            "Fractal Tree"});
            this.FractalChooseBox.Location = new System.Drawing.Point(85, 30);
            this.FractalChooseBox.Margin = new System.Windows.Forms.Padding(0);
            this.FractalChooseBox.Name = "FractalChooseBox";
            this.FractalChooseBox.Size = new System.Drawing.Size(121, 21);
            this.FractalChooseBox.TabIndex = 0;
            this.FractalChooseBox.SelectionChangeCommitted += new System.EventHandler(this.FractalChooseBox_SelectionChangeCommitted);
            // 
            // ScaleLabel
            // 
            this.ScaleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScaleLabel.AutoSize = true;
            this.ScaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScaleLabel.Location = new System.Drawing.Point(116, 67);
            this.ScaleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ScaleLabel.Name = "ScaleLabel";
            this.ScaleLabel.Size = new System.Drawing.Size(58, 13);
            this.ScaleLabel.TabIndex = 2;
            this.ScaleLabel.Text = "Iteration:";
            this.ScaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ScaleLabel.Visible = false;
            // 
            // FillButton
            // 
            this.FillButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FillButton.AutoSize = true;
            this.FillButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FillButton.Location = new System.Drawing.Point(12, 95);
            this.FillButton.Margin = new System.Windows.Forms.Padding(10, 0, 0, 14);
            this.FillButton.Name = "FillButton";
            this.FillButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FillButton.Size = new System.Drawing.Size(43, 20);
            this.FillButton.TabIndex = 3;
            this.FillButton.Text = "Fill";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Visible = false;
            this.FillButton.CheckedChanged += new System.EventHandler(this.TriangleFillButton_CheckedChanged);
            // 
            // SegmentSizeNumeric
            // 
            this.SegmentSizeNumeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SegmentSizeNumeric.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SegmentSizeNumeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SegmentSizeNumeric.InterceptArrowKeys = false;
            this.SegmentSizeNumeric.Location = new System.Drawing.Point(85, 173);
            this.SegmentSizeNumeric.Margin = new System.Windows.Forms.Padding(0);
            this.SegmentSizeNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SegmentSizeNumeric.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SegmentSizeNumeric.Name = "SegmentSizeNumeric";
            this.SegmentSizeNumeric.Size = new System.Drawing.Size(120, 20);
            this.SegmentSizeNumeric.TabIndex = 4;
            this.SegmentSizeNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.SegmentSizeNumeric.Visible = false;
            this.SegmentSizeNumeric.ValueChanged += new System.EventHandler(this.SegmentSizeNumeric_ValueChanged);
            // 
            // SegmentSizeLabel
            // 
            this.SegmentSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SegmentSizeLabel.AutoSize = true;
            this.SegmentSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SegmentSizeLabel.Location = new System.Drawing.Point(101, 143);
            this.SegmentSizeLabel.Name = "SegmentSizeLabel";
            this.SegmentSizeLabel.Size = new System.Drawing.Size(88, 13);
            this.SegmentSizeLabel.TabIndex = 5;
            this.SegmentSizeLabel.Text = "Segment Size:";
            this.SegmentSizeLabel.Visible = false;
            // 
            // TreeAngleLabel
            // 
            this.TreeAngleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TreeAngleLabel.AutoSize = true;
            this.TreeAngleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.TreeAngleLabel.Location = new System.Drawing.Point(124, 211);
            this.TreeAngleLabel.Name = "TreeAngleLabel";
            this.TreeAngleLabel.Size = new System.Drawing.Size(43, 13);
            this.TreeAngleLabel.TabIndex = 7;
            this.TreeAngleLabel.Text = "Angle:";
            this.TreeAngleLabel.Visible = false;
            // 
            // TreeRatioLabel
            // 
            this.TreeRatioLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TreeRatioLabel.AutoSize = true;
            this.TreeRatioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TreeRatioLabel.Location = new System.Drawing.Point(125, 331);
            this.TreeRatioLabel.Name = "TreeRatioLabel";
            this.TreeRatioLabel.Size = new System.Drawing.Size(41, 13);
            this.TreeRatioLabel.TabIndex = 8;
            this.TreeRatioLabel.Text = "Ratio:";
            this.TreeRatioLabel.Visible = false;
            // 
            // TreeRatioNumeric
            // 
            this.TreeRatioNumeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TreeRatioNumeric.DecimalPlaces = 2;
            this.TreeRatioNumeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.TreeRatioNumeric.Location = new System.Drawing.Point(85, 363);
            this.TreeRatioNumeric.Margin = new System.Windows.Forms.Padding(0);
            this.TreeRatioNumeric.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TreeRatioNumeric.Name = "TreeRatioNumeric";
            this.TreeRatioNumeric.Size = new System.Drawing.Size(120, 20);
            this.TreeRatioNumeric.TabIndex = 9;
            this.TreeRatioNumeric.Visible = false;
            this.TreeRatioNumeric.ValueChanged += new System.EventHandler(this.TreeRatioNumeric_ValueChanged);
            // 
            // TreeAngleTrackBar
            // 
            this.TreeAngleTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeAngleTrackBar.LargeChange = 1;
            this.TreeAngleTrackBar.Location = new System.Drawing.Point(58, 278);
            this.TreeAngleTrackBar.Margin = new System.Windows.Forms.Padding(0);
            this.TreeAngleTrackBar.Maximum = 360;
            this.TreeAngleTrackBar.Name = "TreeAngleTrackBar";
            this.TreeAngleTrackBar.Size = new System.Drawing.Size(175, 50);
            this.TreeAngleTrackBar.TabIndex = 10;
            this.TreeAngleTrackBar.TickFrequency = 0;
            this.TreeAngleTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TreeAngleTrackBar.Visible = false;
            this.TreeAngleTrackBar.Scroll += new System.EventHandler(this.TreeAngleTrackBar_Scroll);
            // 
            // TreeAngleNumeric
            // 
            this.TreeAngleNumeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TreeAngleNumeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TreeAngleNumeric.InterceptArrowKeys = false;
            this.TreeAngleNumeric.Location = new System.Drawing.Point(85, 243);
            this.TreeAngleNumeric.Margin = new System.Windows.Forms.Padding(0);
            this.TreeAngleNumeric.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.TreeAngleNumeric.Name = "TreeAngleNumeric";
            this.TreeAngleNumeric.Size = new System.Drawing.Size(120, 20);
            this.TreeAngleNumeric.TabIndex = 6;
            this.TreeAngleNumeric.Visible = false;
            this.TreeAngleNumeric.ValueChanged += new System.EventHandler(this.TreeAngleNumeric_ValueChanged);
            // 
            // TreeRatioTrackBar
            // 
            this.TreeRatioTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeRatioTrackBar.LargeChange = 1;
            this.TreeRatioTrackBar.Location = new System.Drawing.Point(58, 398);
            this.TreeRatioTrackBar.Margin = new System.Windows.Forms.Padding(0);
            this.TreeRatioTrackBar.Maximum = 20;
            this.TreeRatioTrackBar.Name = "TreeRatioTrackBar";
            this.TreeRatioTrackBar.Size = new System.Drawing.Size(175, 48);
            this.TreeRatioTrackBar.TabIndex = 11;
            this.TreeRatioTrackBar.TickFrequency = 0;
            this.TreeRatioTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TreeRatioTrackBar.Visible = false;
            this.TreeRatioTrackBar.Scroll += new System.EventHandler(this.TreeRatioTrackBar_Scroll);
            // 
            // DepthSlider
            // 
            this.DepthSlider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DepthSlider.LargeChange = 1;
            this.DepthSlider.Location = new System.Drawing.Point(68, 89);
            this.DepthSlider.Margin = new System.Windows.Forms.Padding(0);
            this.DepthSlider.Minimum = 1;
            this.DepthSlider.Name = "DepthSlider";
            this.DepthSlider.Size = new System.Drawing.Size(154, 45);
            this.DepthSlider.TabIndex = 1;
            this.DepthSlider.Value = 1;
            this.DepthSlider.Visible = false;
            this.DepthSlider.ValueChanged += new System.EventHandler(this.DepthSlider_ValueChanged);
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
            this.DisplayTableLayout.ResumeLayout(false);
            this.BottomStripTable.ResumeLayout(false);
            this.BottomStripTable.PerformLayout();
            this.FractalInfoStrip.ResumeLayout(false);
            this.FractalInfoStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FractalPictureBox)).EndInit();
            this.ControlsTable.ResumeLayout(false);
            this.ControlsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentSizeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreeRatioNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreeAngleTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreeAngleNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreeRatioTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.TableLayoutPanel ControlsTable;
        private System.Windows.Forms.ComboBox FractalChooseBox;
        private FractalDepthTrackBar DepthSlider;
        private System.Windows.Forms.Label ScaleLabel;
        public System.Windows.Forms.CheckBox FillButton;
        private System.Windows.Forms.NumericUpDown SegmentSizeNumeric;
        private System.Windows.Forms.Label SegmentSizeLabel;
        private System.Windows.Forms.TableLayoutPanel DisplayTableLayout;
        private System.Windows.Forms.PictureBox FractalPictureBox;
        private System.Windows.Forms.TableLayoutPanel BottomStripTable;
        private System.Windows.Forms.StatusStrip FractalInfoStrip;
        private System.Windows.Forms.ToolStripStatusLabel FractalName;
        private System.Windows.Forms.ToolStripStatusLabel FractalSegAmount;
        private System.Windows.Forms.ComboBox ZoomComboBox;
        private System.Windows.Forms.Button RestoreScaleButton;
        private System.Windows.Forms.NumericUpDown TreeAngleNumeric;
        private System.Windows.Forms.Label TreeAngleLabel;
        private System.Windows.Forms.Label TreeRatioLabel;
        private System.Windows.Forms.NumericUpDown TreeRatioNumeric;
        private System.Windows.Forms.TrackBar TreeAngleTrackBar;
        private System.Windows.Forms.TrackBar TreeRatioTrackBar;
    }
}

