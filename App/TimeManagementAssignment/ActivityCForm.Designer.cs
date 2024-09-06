namespace TimeManagementAssignment
{
    partial class ActivityCForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityCForm));
            this.submitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.activityTitleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.descriptorHeading = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.activityC1 = new System.Windows.Forms.DomainUpDown();
            this.hoursHeader = new System.Windows.Forms.Label();
            this.minutesHeader = new System.Windows.Forms.Label();
            this.hoursC1 = new System.Windows.Forms.NumericUpDown();
            this.minutesC1 = new System.Windows.Forms.NumericUpDown();
            this.hoursC2 = new System.Windows.Forms.NumericUpDown();
            this.hoursC3 = new System.Windows.Forms.NumericUpDown();
            this.hoursC4 = new System.Windows.Forms.NumericUpDown();
            this.activitiesLabel = new System.Windows.Forms.Label();
            this.hoursC5 = new System.Windows.Forms.NumericUpDown();
            this.hoursC6 = new System.Windows.Forms.NumericUpDown();
            this.hoursC7 = new System.Windows.Forms.NumericUpDown();
            this.minutesC2 = new System.Windows.Forms.NumericUpDown();
            this.minutesC3 = new System.Windows.Forms.NumericUpDown();
            this.minutesC4 = new System.Windows.Forms.NumericUpDown();
            this.minutesC5 = new System.Windows.Forms.NumericUpDown();
            this.minutesC6 = new System.Windows.Forms.NumericUpDown();
            this.minutesC7 = new System.Windows.Forms.NumericUpDown();
            this.activityC2 = new System.Windows.Forms.DomainUpDown();
            this.activityC3 = new System.Windows.Forms.DomainUpDown();
            this.activityC4 = new System.Windows.Forms.DomainUpDown();
            this.activityC5 = new System.Windows.Forms.DomainUpDown();
            this.activityC6 = new System.Windows.Forms.DomainUpDown();
            this.activityC7 = new System.Windows.Forms.DomainUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.activityAtimer = new System.Windows.Forms.Panel();
            this.hoursValue = new System.Windows.Forms.Label();
            this.totalTimeSpendLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.minutesValue = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursC3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursC4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursC5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursC6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursC7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesC3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesC4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesC5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesC6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesC7)).BeginInit();
            this.panel2.SuspendLayout();
            this.activityAtimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(151, 494);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 40);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Visible = false;
            this.submitButton.VisibleChanged += new System.EventHandler(this.submitButton_VisibleChanged);
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(408, 494);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(101, 39);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // activityTitleLabel
            // 
            this.activityTitleLabel.AutoSize = true;
            this.activityTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityTitleLabel.Location = new System.Drawing.Point(243, 9);
            this.activityTitleLabel.Name = "activityTitleLabel";
            this.activityTitleLabel.Size = new System.Drawing.Size(182, 25);
            this.activityTitleLabel.TabIndex = 7;
            this.activityTitleLabel.Text = "Class C Activities";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.descriptorHeading);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(76, 152);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 296);
            this.panel1.TabIndex = 8;
            // 
            // descriptorHeading
            // 
            this.descriptorHeading.AutoSize = true;
            this.descriptorHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptorHeading.Location = new System.Drawing.Point(36, 12);
            this.descriptorHeading.Margin = new System.Windows.Forms.Padding(0);
            this.descriptorHeading.Name = "descriptorHeading";
            this.descriptorHeading.Size = new System.Drawing.Size(407, 20);
            this.descriptorHeading.TabIndex = 0;
            this.descriptorHeading.Text = "Select your activities and the time you spend on them";
            this.descriptorHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.Controls.Add(this.activityC1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.hoursHeader, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.minutesHeader, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.hoursC1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.minutesC1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.hoursC2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.hoursC3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.hoursC4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.activitiesLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.hoursC5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.hoursC6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.hoursC7, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.minutesC2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.minutesC3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.minutesC4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.minutesC5, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.minutesC6, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.minutesC7, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.activityC2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.activityC3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.activityC4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.activityC5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.activityC6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.activityC7, 0, 7);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 46);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 242);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // activityC1
            // 
            this.activityC1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.activityC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityC1.Items.Add("Spending time with friends");
            this.activityC1.Items.Add("Quiet time or meditation");
            this.activityC1.Items.Add("Reading");
            this.activityC1.Items.Add("Going to the cinema");
            this.activityC1.Items.Add("Having coffee with a friend");
            this.activityC1.Items.Add("Watching movies or series");
            this.activityC1.Items.Add("Playing video games");
            this.activityC1.Items.Add("Doing sports with friends");
            this.activityC1.Items.Add("Other");
            this.activityC1.Location = new System.Drawing.Point(4, 32);
            this.activityC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityC1.Name = "activityC1";
            this.activityC1.ReadOnly = true;
            this.activityC1.Size = new System.Drawing.Size(258, 26);
            this.activityC1.TabIndex = 8;
            this.activityC1.Text = "Select activity...";
            this.activityC1.SelectedItemChanged += new System.EventHandler(this.ActivityC1_SelectedItemChanged);
            // 
            // hoursHeader
            // 
            this.hoursHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoursHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursHeader.Location = new System.Drawing.Point(269, 1);
            this.hoursHeader.Name = "hoursHeader";
            this.hoursHeader.Size = new System.Drawing.Size(100, 28);
            this.hoursHeader.TabIndex = 2;
            this.hoursHeader.Text = "Hours";
            this.hoursHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minutesHeader
            // 
            this.minutesHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutesHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesHeader.Location = new System.Drawing.Point(376, 1);
            this.minutesHeader.Name = "minutesHeader";
            this.minutesHeader.Size = new System.Drawing.Size(111, 28);
            this.minutesHeader.TabIndex = 2;
            this.minutesHeader.Text = "Minutes";
            this.minutesHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursC1
            // 
            this.hoursC1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.hoursC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoursC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursC1.Location = new System.Drawing.Point(269, 32);
            this.hoursC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoursC1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursC1.Name = "hoursC1";
            this.hoursC1.Size = new System.Drawing.Size(100, 26);
            this.hoursC1.TabIndex = 9;
            this.hoursC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoursC1.ValueChanged += new System.EventHandler(this.HoursC1_ValueChanged);
            // 
            // minutesC1
            // 
            this.minutesC1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.minutesC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutesC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesC1.Location = new System.Drawing.Point(376, 32);
            this.minutesC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minutesC1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesC1.Name = "minutesC1";
            this.minutesC1.Size = new System.Drawing.Size(111, 26);
            this.minutesC1.TabIndex = 9;
            this.minutesC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minutesC1.ValueChanged += new System.EventHandler(this.MinutesC1_ValueChanged);
            // 
            // hoursC2
            // 
            this.hoursC2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hoursC2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.hoursC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursC2.Location = new System.Drawing.Point(269, 61);
            this.hoursC2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoursC2.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursC2.Name = "hoursC2";
            this.hoursC2.Size = new System.Drawing.Size(100, 26);
            this.hoursC2.TabIndex = 9;
            this.hoursC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoursC2.ValueChanged += new System.EventHandler(this.HoursC2_ValueChanged);
            // 
            // hoursC3
            // 
            this.hoursC3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hoursC3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.hoursC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursC3.Location = new System.Drawing.Point(269, 90);
            this.hoursC3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoursC3.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursC3.Name = "hoursC3";
            this.hoursC3.Size = new System.Drawing.Size(100, 26);
            this.hoursC3.TabIndex = 9;
            this.hoursC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoursC3.ValueChanged += new System.EventHandler(this.HoursC3_ValueChanged);
            // 
            // hoursC4
            // 
            this.hoursC4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hoursC4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.hoursC4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursC4.Location = new System.Drawing.Point(269, 119);
            this.hoursC4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoursC4.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursC4.Name = "hoursC4";
            this.hoursC4.Size = new System.Drawing.Size(100, 26);
            this.hoursC4.TabIndex = 9;
            this.hoursC4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoursC4.ValueChanged += new System.EventHandler(this.HoursC4_ValueChanged);
            // 
            // activitiesLabel
            // 
            this.activitiesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activitiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activitiesLabel.Location = new System.Drawing.Point(4, 1);
            this.activitiesLabel.Name = "activitiesLabel";
            this.activitiesLabel.Size = new System.Drawing.Size(258, 28);
            this.activitiesLabel.TabIndex = 6;
            this.activitiesLabel.Text = "Choose your class C Activities";
            this.activitiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursC5
            // 
            this.hoursC5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hoursC5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.hoursC5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursC5.Location = new System.Drawing.Point(269, 148);
            this.hoursC5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoursC5.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursC5.Name = "hoursC5";
            this.hoursC5.Size = new System.Drawing.Size(100, 26);
            this.hoursC5.TabIndex = 9;
            this.hoursC5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoursC5.ValueChanged += new System.EventHandler(this.HoursC5_ValueChanged);
            // 
            // hoursC6
            // 
            this.hoursC6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hoursC6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.hoursC6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursC6.Location = new System.Drawing.Point(269, 177);
            this.hoursC6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoursC6.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursC6.Name = "hoursC6";
            this.hoursC6.Size = new System.Drawing.Size(100, 26);
            this.hoursC6.TabIndex = 9;
            this.hoursC6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoursC6.ValueChanged += new System.EventHandler(this.HoursC6_ValueChanged);
            // 
            // hoursC7
            // 
            this.hoursC7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hoursC7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.hoursC7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursC7.Location = new System.Drawing.Point(269, 206);
            this.hoursC7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoursC7.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursC7.Name = "hoursC7";
            this.hoursC7.Size = new System.Drawing.Size(100, 26);
            this.hoursC7.TabIndex = 9;
            this.hoursC7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoursC7.ValueChanged += new System.EventHandler(this.HoursC7_ValueChanged);
            // 
            // minutesC2
            // 
            this.minutesC2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.minutesC2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutesC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesC2.Location = new System.Drawing.Point(376, 61);
            this.minutesC2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minutesC2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesC2.Name = "minutesC2";
            this.minutesC2.Size = new System.Drawing.Size(111, 26);
            this.minutesC2.TabIndex = 9;
            this.minutesC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minutesC2.ValueChanged += new System.EventHandler(this.MinutesC2_ValueChanged);
            // 
            // minutesC3
            // 
            this.minutesC3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.minutesC3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutesC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesC3.Location = new System.Drawing.Point(376, 90);
            this.minutesC3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minutesC3.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesC3.Name = "minutesC3";
            this.minutesC3.Size = new System.Drawing.Size(111, 26);
            this.minutesC3.TabIndex = 9;
            this.minutesC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minutesC3.ValueChanged += new System.EventHandler(this.MinutesC3_ValueChanged);
            // 
            // minutesC4
            // 
            this.minutesC4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.minutesC4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutesC4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesC4.Location = new System.Drawing.Point(376, 119);
            this.minutesC4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minutesC4.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesC4.Name = "minutesC4";
            this.minutesC4.Size = new System.Drawing.Size(111, 26);
            this.minutesC4.TabIndex = 9;
            this.minutesC4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minutesC4.ValueChanged += new System.EventHandler(this.MinutesC4_ValueChanged);
            // 
            // minutesC5
            // 
            this.minutesC5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.minutesC5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutesC5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesC5.Location = new System.Drawing.Point(376, 148);
            this.minutesC5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minutesC5.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesC5.Name = "minutesC5";
            this.minutesC5.Size = new System.Drawing.Size(111, 26);
            this.minutesC5.TabIndex = 9;
            this.minutesC5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minutesC5.ValueChanged += new System.EventHandler(this.MinutesC5_ValueChanged);
            // 
            // minutesC6
            // 
            this.minutesC6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.minutesC6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutesC6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesC6.Location = new System.Drawing.Point(376, 177);
            this.minutesC6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minutesC6.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesC6.Name = "minutesC6";
            this.minutesC6.Size = new System.Drawing.Size(111, 26);
            this.minutesC6.TabIndex = 9;
            this.minutesC6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minutesC6.ValueChanged += new System.EventHandler(this.MinutesC6_ValueChanged);
            // 
            // minutesC7
            // 
            this.minutesC7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.minutesC7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutesC7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesC7.Location = new System.Drawing.Point(376, 206);
            this.minutesC7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minutesC7.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesC7.Name = "minutesC7";
            this.minutesC7.Size = new System.Drawing.Size(111, 26);
            this.minutesC7.TabIndex = 9;
            this.minutesC7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minutesC7.ValueChanged += new System.EventHandler(this.MinutesC7_ValueChanged);
            // 
            // activityC2
            // 
            this.activityC2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.activityC2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityC2.Items.Add("Spending time with friends");
            this.activityC2.Items.Add("Quiet time or meditation");
            this.activityC2.Items.Add("Reading");
            this.activityC2.Items.Add("Going to the cinema");
            this.activityC2.Items.Add("Having coffee with a friend");
            this.activityC2.Items.Add("Watching movies or series");
            this.activityC2.Items.Add("Playing video games");
            this.activityC2.Items.Add("Doing sports with friends");
            this.activityC2.Items.Add("Other");
            this.activityC2.Location = new System.Drawing.Point(4, 61);
            this.activityC2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityC2.Name = "activityC2";
            this.activityC2.ReadOnly = true;
            this.activityC2.Size = new System.Drawing.Size(258, 26);
            this.activityC2.TabIndex = 8;
            this.activityC2.Text = "Select activity...";
            this.activityC2.SelectedItemChanged += new System.EventHandler(this.ActivityC2_SelectedItemChanged);
            // 
            // activityC3
            // 
            this.activityC3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.activityC3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityC3.Items.Add("Spending time with friends");
            this.activityC3.Items.Add("Quiet time or meditation");
            this.activityC3.Items.Add("Reading");
            this.activityC3.Items.Add("Going to the cinema");
            this.activityC3.Items.Add("Having coffee with a friend");
            this.activityC3.Items.Add("Watching movies or series");
            this.activityC3.Items.Add("Playing video games");
            this.activityC3.Items.Add("Doing sports with friends");
            this.activityC3.Items.Add("Other");
            this.activityC3.Location = new System.Drawing.Point(4, 90);
            this.activityC3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityC3.Name = "activityC3";
            this.activityC3.ReadOnly = true;
            this.activityC3.Size = new System.Drawing.Size(258, 26);
            this.activityC3.TabIndex = 8;
            this.activityC3.Text = "Select activity...";
            this.activityC3.SelectedItemChanged += new System.EventHandler(this.ActivityC3_SelectedItemChanged);
            // 
            // activityC4
            // 
            this.activityC4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.activityC4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityC4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityC4.Items.Add("Spending time with friends");
            this.activityC4.Items.Add("Quiet time or meditation");
            this.activityC4.Items.Add("Reading");
            this.activityC4.Items.Add("Going to the cinema");
            this.activityC4.Items.Add("Having coffee with a friend");
            this.activityC4.Items.Add("Watching movies or series");
            this.activityC4.Items.Add("Playing video games");
            this.activityC4.Items.Add("Doing sports with friends");
            this.activityC4.Items.Add("Other");
            this.activityC4.Location = new System.Drawing.Point(4, 119);
            this.activityC4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityC4.Name = "activityC4";
            this.activityC4.ReadOnly = true;
            this.activityC4.Size = new System.Drawing.Size(258, 26);
            this.activityC4.TabIndex = 8;
            this.activityC4.Text = "Select activity...";
            this.activityC4.SelectedItemChanged += new System.EventHandler(this.ActivityC4_SelectedItemChanged);
            // 
            // activityC5
            // 
            this.activityC5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.activityC5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityC5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityC5.Items.Add("Spending time with friends");
            this.activityC5.Items.Add("Quiet time or meditation");
            this.activityC5.Items.Add("Reading");
            this.activityC5.Items.Add("Going to the cinema");
            this.activityC5.Items.Add("Having coffee with a friend");
            this.activityC5.Items.Add("Watching movies or series");
            this.activityC5.Items.Add("Playing video games");
            this.activityC5.Items.Add("Doing sports with friends");
            this.activityC5.Items.Add("Other");
            this.activityC5.Location = new System.Drawing.Point(4, 148);
            this.activityC5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityC5.Name = "activityC5";
            this.activityC5.ReadOnly = true;
            this.activityC5.Size = new System.Drawing.Size(258, 26);
            this.activityC5.TabIndex = 8;
            this.activityC5.Text = "Select activity...";
            this.activityC5.SelectedItemChanged += new System.EventHandler(this.ActivityC5_SelectedItemChanged);
            // 
            // activityC6
            // 
            this.activityC6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.activityC6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityC6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityC6.Items.Add("Spending time with friends");
            this.activityC6.Items.Add("Quiet time or meditation");
            this.activityC6.Items.Add("Reading");
            this.activityC6.Items.Add("Going to the cinema");
            this.activityC6.Items.Add("Having coffee with a friend");
            this.activityC6.Items.Add("Watching movies or series");
            this.activityC6.Items.Add("Playing video games");
            this.activityC6.Items.Add("Doing sports with friends");
            this.activityC6.Items.Add("Other");
            this.activityC6.Location = new System.Drawing.Point(4, 177);
            this.activityC6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityC6.Name = "activityC6";
            this.activityC6.ReadOnly = true;
            this.activityC6.Size = new System.Drawing.Size(258, 26);
            this.activityC6.TabIndex = 8;
            this.activityC6.Text = "Select activity...";
            this.activityC6.SelectedItemChanged += new System.EventHandler(this.ActivityC6_SelectedItemChanged);
            // 
            // activityC7
            // 
            this.activityC7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.activityC7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityC7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityC7.Items.Add("Spending time with friends");
            this.activityC7.Items.Add("Quiet time or meditation");
            this.activityC7.Items.Add("Reading");
            this.activityC7.Items.Add("Going to the cinema");
            this.activityC7.Items.Add("Having coffee with a friend");
            this.activityC7.Items.Add("Watching movies or series");
            this.activityC7.Items.Add("Playing video games");
            this.activityC7.Items.Add("Doing sports with friends");
            this.activityC7.Items.Add("Other");
            this.activityC7.Location = new System.Drawing.Point(4, 206);
            this.activityC7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityC7.Name = "activityC7";
            this.activityC7.ReadOnly = true;
            this.activityC7.Size = new System.Drawing.Size(258, 26);
            this.activityC7.TabIndex = 8;
            this.activityC7.Text = "Select activity...";
            this.activityC7.SelectedItemChanged += new System.EventHandler(this.ActivityC7_SelectedItemChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.activityTitleLabel);
            this.panel2.Location = new System.Drawing.Point(20, 7);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 138);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(641, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // activityAtimer
            // 
            this.activityAtimer.Controls.Add(this.hoursValue);
            this.activityAtimer.Controls.Add(this.totalTimeSpendLabel);
            this.activityAtimer.Controls.Add(this.hoursLabel);
            this.activityAtimer.Controls.Add(this.minutesValue);
            this.activityAtimer.Controls.Add(this.minutesLabel);
            this.activityAtimer.Location = new System.Drawing.Point(64, 454);
            this.activityAtimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityAtimer.Name = "activityAtimer";
            this.activityAtimer.Size = new System.Drawing.Size(572, 32);
            this.activityAtimer.TabIndex = 8;
            // 
            // hoursValue
            // 
            this.hoursValue.AutoSize = true;
            this.hoursValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursValue.Location = new System.Drawing.Point(323, 6);
            this.hoursValue.Margin = new System.Windows.Forms.Padding(0);
            this.hoursValue.Name = "hoursValue";
            this.hoursValue.Size = new System.Drawing.Size(19, 20);
            this.hoursValue.TabIndex = 2;
            this.hoursValue.Text = "0";
            this.hoursValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hoursValue.TextChanged += new System.EventHandler(this.hoursValue_TextChanged);
            // 
            // totalTimeSpendLabel
            // 
            this.totalTimeSpendLabel.AutoSize = true;
            this.totalTimeSpendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTimeSpendLabel.Location = new System.Drawing.Point(7, 6);
            this.totalTimeSpendLabel.Margin = new System.Windows.Forms.Padding(0);
            this.totalTimeSpendLabel.Name = "totalTimeSpendLabel";
            this.totalTimeSpendLabel.Size = new System.Drawing.Size(279, 20);
            this.totalTimeSpendLabel.TabIndex = 2;
            this.totalTimeSpendLabel.Text = "Total time spent on these activities: ";
            this.totalTimeSpendLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLabel.Location = new System.Drawing.Point(359, 6);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(60, 20);
            this.hoursLabel.TabIndex = 2;
            this.hoursLabel.Text = "Hours;";
            this.hoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // minutesValue
            // 
            this.minutesValue.AutoSize = true;
            this.minutesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesValue.Location = new System.Drawing.Point(453, 6);
            this.minutesValue.Margin = new System.Windows.Forms.Padding(0);
            this.minutesValue.Name = "minutesValue";
            this.minutesValue.Size = new System.Drawing.Size(19, 20);
            this.minutesValue.TabIndex = 2;
            this.minutesValue.Text = "0";
            this.minutesValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.minutesValue.TextChanged += new System.EventHandler(this.minutesValue_TextChanged);
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesLabel.Location = new System.Drawing.Point(489, 6);
            this.minutesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(68, 20);
            this.minutesLabel.TabIndex = 2;
            this.minutesLabel.Text = "Minutes";
            this.minutesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ActivityCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(700, 543);
            this.Controls.Add(this.activityAtimer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.submitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ActivityCForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activity C";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hoursC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursC3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursC4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursC5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursC6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursC7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesC3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesC4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesC5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesC6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesC7)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.activityAtimer.ResumeLayout(false);
            this.activityAtimer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label activityTitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label descriptorHeading;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DomainUpDown activityC1;
        private System.Windows.Forms.Label hoursHeader;
        private System.Windows.Forms.Label minutesHeader;
        private System.Windows.Forms.NumericUpDown hoursC1;
        private System.Windows.Forms.NumericUpDown minutesC1;
        private System.Windows.Forms.NumericUpDown hoursC2;
        private System.Windows.Forms.NumericUpDown hoursC3;
        private System.Windows.Forms.NumericUpDown hoursC4;
        private System.Windows.Forms.Label activitiesLabel;
        private System.Windows.Forms.NumericUpDown hoursC5;
        private System.Windows.Forms.NumericUpDown hoursC6;
        private System.Windows.Forms.NumericUpDown hoursC7;
        private System.Windows.Forms.NumericUpDown minutesC2;
        private System.Windows.Forms.NumericUpDown minutesC3;
        private System.Windows.Forms.NumericUpDown minutesC4;
        private System.Windows.Forms.NumericUpDown minutesC5;
        private System.Windows.Forms.NumericUpDown minutesC6;
        private System.Windows.Forms.NumericUpDown minutesC7;
        private System.Windows.Forms.DomainUpDown activityC2;
        private System.Windows.Forms.DomainUpDown activityC3;
        private System.Windows.Forms.DomainUpDown activityC4;
        private System.Windows.Forms.DomainUpDown activityC5;
        private System.Windows.Forms.DomainUpDown activityC6;
        private System.Windows.Forms.DomainUpDown activityC7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel activityAtimer;
        private System.Windows.Forms.Label hoursValue;
        private System.Windows.Forms.Label totalTimeSpendLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label minutesValue;
        private System.Windows.Forms.Label minutesLabel;
    }
}