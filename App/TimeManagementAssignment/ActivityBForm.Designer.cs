namespace TimeManagementAssignment
{
    partial class ActivityBForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityBForm));
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.activityTitleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.descriptorHeading = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.activityB1 = new System.Windows.Forms.DomainUpDown();
            this.hoursHeader = new System.Windows.Forms.Label();
            this.minutesHeader = new System.Windows.Forms.Label();
            this.hoursB1 = new System.Windows.Forms.NumericUpDown();
            this.minutesB1 = new System.Windows.Forms.NumericUpDown();
            this.hoursB2 = new System.Windows.Forms.NumericUpDown();
            this.hoursB3 = new System.Windows.Forms.NumericUpDown();
            this.hoursB4 = new System.Windows.Forms.NumericUpDown();
            this.activitiesLabel = new System.Windows.Forms.Label();
            this.hoursB5 = new System.Windows.Forms.NumericUpDown();
            this.hoursB6 = new System.Windows.Forms.NumericUpDown();
            this.hoursB7 = new System.Windows.Forms.NumericUpDown();
            this.minutesB2 = new System.Windows.Forms.NumericUpDown();
            this.minutesB3 = new System.Windows.Forms.NumericUpDown();
            this.minutesB4 = new System.Windows.Forms.NumericUpDown();
            this.minutesB5 = new System.Windows.Forms.NumericUpDown();
            this.minutesB6 = new System.Windows.Forms.NumericUpDown();
            this.minutesB7 = new System.Windows.Forms.NumericUpDown();
            this.activityB2 = new System.Windows.Forms.DomainUpDown();
            this.activityB3 = new System.Windows.Forms.DomainUpDown();
            this.activityB4 = new System.Windows.Forms.DomainUpDown();
            this.activityB5 = new System.Windows.Forms.DomainUpDown();
            this.activityB6 = new System.Windows.Forms.DomainUpDown();
            this.activityB7 = new System.Windows.Forms.DomainUpDown();
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
            ((System.ComponentModel.ISupportInitialize)(this.hoursB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursB4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursB5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursB6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursB7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesB4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesB5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesB6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesB7)).BeginInit();
            this.panel2.SuspendLayout();
            this.activityAtimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(93, 470);
            this.nextButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(224, 40);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next >>> Activity C";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Visible = false;
            this.nextButton.VisibleChanged += new System.EventHandler(this.nextButton_VisibleChanged);
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(461, 470);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(91, 39);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // activityTitleLabel
            // 
            this.activityTitleLabel.AutoSize = true;
            this.activityTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityTitleLabel.Location = new System.Drawing.Point(235, 8);
            this.activityTitleLabel.Name = "activityTitleLabel";
            this.activityTitleLabel.Size = new System.Drawing.Size(180, 25);
            this.activityTitleLabel.TabIndex = 6;
            this.activityTitleLabel.Text = "Class B Activities";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.descriptorHeading);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(81, 129);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 296);
            this.panel1.TabIndex = 7;
            // 
            // descriptorHeading
            // 
            this.descriptorHeading.AutoSize = true;
            this.descriptorHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptorHeading.Location = new System.Drawing.Point(35, 11);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.Controls.Add(this.activityB1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.hoursHeader, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.minutesHeader, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.hoursB1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.minutesB1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.hoursB2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.hoursB3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.hoursB4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.activitiesLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.hoursB5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.hoursB6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.hoursB7, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.minutesB2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.minutesB3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.minutesB4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.minutesB5, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.minutesB6, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.minutesB7, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.activityB2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.activityB3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.activityB4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.activityB5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.activityB6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.activityB7, 0, 7);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 45);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(477, 242);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // activityB1
            // 
            this.activityB1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.activityB1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityB1.Items.Add("Bathing");
            this.activityB1.Items.Add("Sleeping");
            this.activityB1.Items.Add("Eating");
            this.activityB1.Items.Add("Exercising");
            this.activityB1.Items.Add("Cooking");
            this.activityB1.Items.Add("Cleaning house or room");
            this.activityB1.Items.Add("Running errands");
            this.activityB1.Items.Add("Other");
            this.activityB1.Location = new System.Drawing.Point(4, 32);
            this.activityB1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityB1.Name = "activityB1";
            this.activityB1.ReadOnly = true;
            this.activityB1.Size = new System.Drawing.Size(265, 26);
            this.activityB1.TabIndex = 8;
            this.activityB1.Text = "Select activity...";
            this.activityB1.SelectedItemChanged += new System.EventHandler(this.ActivityB1_SelectedItemChanged);
            // 
            // hoursHeader
            // 
            this.hoursHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoursHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursHeader.Location = new System.Drawing.Point(276, 1);
            this.hoursHeader.Name = "hoursHeader";
            this.hoursHeader.Size = new System.Drawing.Size(94, 28);
            this.hoursHeader.TabIndex = 2;
            this.hoursHeader.Text = "Hours";
            this.hoursHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minutesHeader
            // 
            this.minutesHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutesHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesHeader.Location = new System.Drawing.Point(377, 1);
            this.minutesHeader.Name = "minutesHeader";
            this.minutesHeader.Size = new System.Drawing.Size(101, 28);
            this.minutesHeader.TabIndex = 2;
            this.minutesHeader.Text = "Minutes";
            this.minutesHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursB1
            // 
            this.hoursB1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.hoursB1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoursB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursB1.Location = new System.Drawing.Point(276, 32);
            this.hoursB1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoursB1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursB1.Name = "hoursB1";
            this.hoursB1.Size = new System.Drawing.Size(94, 26);
            this.hoursB1.TabIndex = 9;
            this.hoursB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoursB1.ValueChanged += new System.EventHandler(this.HoursB1_ValueChanged);
            // 
            // minutesB1
            // 
            this.minutesB1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.minutesB1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutesB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesB1.Location = new System.Drawing.Point(377, 32);
            this.minutesB1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minutesB1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesB1.Name = "minutesB1";
            this.minutesB1.Size = new System.Drawing.Size(101, 26);
            this.minutesB1.TabIndex = 9;
            this.minutesB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minutesB1.ValueChanged += new System.EventHandler(this.MinutesB1_ValueChanged);
            // 
            // hoursB2
            // 
            this.hoursB2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hoursB2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.hoursB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursB2.Location = new System.Drawing.Point(276, 61);
            this.hoursB2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoursB2.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursB2.Name = "hoursB2";
            this.hoursB2.Size = new System.Drawing.Size(94, 26);
            this.hoursB2.TabIndex = 9;
            this.hoursB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoursB2.ValueChanged += new System.EventHandler(this.HoursB2_ValueChanged);
            // 
            // hoursB3
            // 
            this.hoursB3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hoursB3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.hoursB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursB3.Location = new System.Drawing.Point(276, 90);
            this.hoursB3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoursB3.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursB3.Name = "hoursB3";
            this.hoursB3.Size = new System.Drawing.Size(94, 26);
            this.hoursB3.TabIndex = 9;
            this.hoursB3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoursB3.ValueChanged += new System.EventHandler(this.HoursB3_ValueChanged);
            // 
            // hoursB4
            // 
            this.hoursB4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hoursB4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.hoursB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursB4.Location = new System.Drawing.Point(276, 119);
            this.hoursB4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoursB4.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursB4.Name = "hoursB4";
            this.hoursB4.Size = new System.Drawing.Size(94, 26);
            this.hoursB4.TabIndex = 9;
            this.hoursB4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoursB4.ValueChanged += new System.EventHandler(this.HoursB4_ValueChanged);
            // 
            // activitiesLabel
            // 
            this.activitiesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activitiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activitiesLabel.Location = new System.Drawing.Point(4, 1);
            this.activitiesLabel.Name = "activitiesLabel";
            this.activitiesLabel.Size = new System.Drawing.Size(265, 28);
            this.activitiesLabel.TabIndex = 6;
            this.activitiesLabel.Text = "Choose your class B Activities";
            this.activitiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursB5
            // 
            this.hoursB5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hoursB5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.hoursB5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursB5.Location = new System.Drawing.Point(276, 148);
            this.hoursB5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoursB5.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursB5.Name = "hoursB5";
            this.hoursB5.Size = new System.Drawing.Size(94, 26);
            this.hoursB5.TabIndex = 9;
            this.hoursB5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoursB5.ValueChanged += new System.EventHandler(this.HoursB5_ValueChanged);
            // 
            // hoursB6
            // 
            this.hoursB6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hoursB6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.hoursB6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursB6.Location = new System.Drawing.Point(276, 177);
            this.hoursB6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoursB6.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursB6.Name = "hoursB6";
            this.hoursB6.Size = new System.Drawing.Size(94, 26);
            this.hoursB6.TabIndex = 9;
            this.hoursB6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoursB6.ValueChanged += new System.EventHandler(this.HoursB6_ValueChanged);
            // 
            // hoursB7
            // 
            this.hoursB7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hoursB7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.hoursB7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursB7.Location = new System.Drawing.Point(276, 206);
            this.hoursB7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoursB7.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursB7.Name = "hoursB7";
            this.hoursB7.Size = new System.Drawing.Size(94, 26);
            this.hoursB7.TabIndex = 9;
            this.hoursB7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoursB7.ValueChanged += new System.EventHandler(this.HoursB7_ValueChanged);
            // 
            // minutesB2
            // 
            this.minutesB2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.minutesB2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutesB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesB2.Location = new System.Drawing.Point(377, 61);
            this.minutesB2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minutesB2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesB2.Name = "minutesB2";
            this.minutesB2.Size = new System.Drawing.Size(101, 26);
            this.minutesB2.TabIndex = 9;
            this.minutesB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minutesB2.ValueChanged += new System.EventHandler(this.MinutesB2_ValueChanged);
            // 
            // minutesB3
            // 
            this.minutesB3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.minutesB3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutesB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesB3.Location = new System.Drawing.Point(377, 90);
            this.minutesB3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minutesB3.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesB3.Name = "minutesB3";
            this.minutesB3.Size = new System.Drawing.Size(101, 26);
            this.minutesB3.TabIndex = 9;
            this.minutesB3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minutesB3.ValueChanged += new System.EventHandler(this.MinutesB3_ValueChanged);
            // 
            // minutesB4
            // 
            this.minutesB4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.minutesB4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutesB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesB4.Location = new System.Drawing.Point(377, 119);
            this.minutesB4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minutesB4.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesB4.Name = "minutesB4";
            this.minutesB4.Size = new System.Drawing.Size(101, 26);
            this.minutesB4.TabIndex = 9;
            this.minutesB4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minutesB4.ValueChanged += new System.EventHandler(this.MinutesB4_ValueChanged);
            // 
            // minutesB5
            // 
            this.minutesB5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.minutesB5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutesB5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesB5.Location = new System.Drawing.Point(377, 148);
            this.minutesB5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minutesB5.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesB5.Name = "minutesB5";
            this.minutesB5.Size = new System.Drawing.Size(101, 26);
            this.minutesB5.TabIndex = 9;
            this.minutesB5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minutesB5.ValueChanged += new System.EventHandler(this.MinutesB5_ValueChanged);
            // 
            // minutesB6
            // 
            this.minutesB6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.minutesB6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutesB6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesB6.Location = new System.Drawing.Point(377, 177);
            this.minutesB6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minutesB6.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesB6.Name = "minutesB6";
            this.minutesB6.Size = new System.Drawing.Size(101, 26);
            this.minutesB6.TabIndex = 9;
            this.minutesB6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minutesB6.ValueChanged += new System.EventHandler(this.MinutesB6_ValueChanged);
            // 
            // minutesB7
            // 
            this.minutesB7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.minutesB7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutesB7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesB7.Location = new System.Drawing.Point(377, 206);
            this.minutesB7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minutesB7.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesB7.Name = "minutesB7";
            this.minutesB7.Size = new System.Drawing.Size(101, 26);
            this.minutesB7.TabIndex = 9;
            this.minutesB7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minutesB7.ValueChanged += new System.EventHandler(this.MinutesB7_ValueChanged);
            // 
            // activityB2
            // 
            this.activityB2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.activityB2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityB2.Items.Add("Bathing");
            this.activityB2.Items.Add("Sleeping");
            this.activityB2.Items.Add("Eating");
            this.activityB2.Items.Add("Exercising");
            this.activityB2.Items.Add("Cooking");
            this.activityB2.Items.Add("Cleaning house or room");
            this.activityB2.Items.Add("Running errands");
            this.activityB2.Items.Add("Other");
            this.activityB2.Location = new System.Drawing.Point(4, 61);
            this.activityB2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityB2.Name = "activityB2";
            this.activityB2.ReadOnly = true;
            this.activityB2.Size = new System.Drawing.Size(265, 26);
            this.activityB2.TabIndex = 8;
            this.activityB2.Text = "Select activity...";
            this.activityB2.SelectedItemChanged += new System.EventHandler(this.ActivityB2_SelectedItemChanged);
            // 
            // activityB3
            // 
            this.activityB3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.activityB3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityB3.Items.Add("Bathing");
            this.activityB3.Items.Add("Sleeping");
            this.activityB3.Items.Add("Eating");
            this.activityB3.Items.Add("Exercising");
            this.activityB3.Items.Add("Cooking");
            this.activityB3.Items.Add("Cleaning house or room");
            this.activityB3.Items.Add("Running errands");
            this.activityB3.Items.Add("Other");
            this.activityB3.Location = new System.Drawing.Point(4, 90);
            this.activityB3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityB3.Name = "activityB3";
            this.activityB3.ReadOnly = true;
            this.activityB3.Size = new System.Drawing.Size(265, 26);
            this.activityB3.TabIndex = 8;
            this.activityB3.Text = "Select activity...";
            this.activityB3.SelectedItemChanged += new System.EventHandler(this.ActivityB3_SelectedItemChanged);
            // 
            // activityB4
            // 
            this.activityB4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.activityB4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityB4.Items.Add("Bathing");
            this.activityB4.Items.Add("Sleeping");
            this.activityB4.Items.Add("Eating");
            this.activityB4.Items.Add("Exercising");
            this.activityB4.Items.Add("Cooking");
            this.activityB4.Items.Add("Cleaning house or room");
            this.activityB4.Items.Add("Running errands");
            this.activityB4.Items.Add("Other");
            this.activityB4.Location = new System.Drawing.Point(4, 119);
            this.activityB4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityB4.Name = "activityB4";
            this.activityB4.ReadOnly = true;
            this.activityB4.Size = new System.Drawing.Size(265, 26);
            this.activityB4.TabIndex = 8;
            this.activityB4.Text = "Select activity...";
            this.activityB4.SelectedItemChanged += new System.EventHandler(this.ActivityB4_SelectedItemChanged);
            // 
            // activityB5
            // 
            this.activityB5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.activityB5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityB5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityB5.Items.Add("Bathing");
            this.activityB5.Items.Add("Sleeping");
            this.activityB5.Items.Add("Eating");
            this.activityB5.Items.Add("Exercising");
            this.activityB5.Items.Add("Cooking");
            this.activityB5.Items.Add("Cleaning house or room");
            this.activityB5.Items.Add("Running errands");
            this.activityB5.Items.Add("Other");
            this.activityB5.Location = new System.Drawing.Point(4, 148);
            this.activityB5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityB5.Name = "activityB5";
            this.activityB5.ReadOnly = true;
            this.activityB5.Size = new System.Drawing.Size(265, 26);
            this.activityB5.TabIndex = 8;
            this.activityB5.Text = "Select activity...";
            this.activityB5.SelectedItemChanged += new System.EventHandler(this.ActivityB5_SelectedItemChanged);
            // 
            // activityB6
            // 
            this.activityB6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.activityB6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityB6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityB6.Items.Add("Bathing");
            this.activityB6.Items.Add("Sleeping");
            this.activityB6.Items.Add("Eating");
            this.activityB6.Items.Add("Exercising");
            this.activityB6.Items.Add("Cooking");
            this.activityB6.Items.Add("Cleaning house or room");
            this.activityB6.Items.Add("Running errands");
            this.activityB6.Items.Add("Other");
            this.activityB6.Location = new System.Drawing.Point(4, 177);
            this.activityB6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityB6.Name = "activityB6";
            this.activityB6.ReadOnly = true;
            this.activityB6.Size = new System.Drawing.Size(265, 26);
            this.activityB6.TabIndex = 8;
            this.activityB6.Text = "Select activity...";
            this.activityB6.SelectedItemChanged += new System.EventHandler(this.ActivityB6_SelectedItemChanged);
            // 
            // activityB7
            // 
            this.activityB7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.activityB7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityB7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityB7.Items.Add("Bathing");
            this.activityB7.Items.Add("Sleeping");
            this.activityB7.Items.Add("Eating");
            this.activityB7.Items.Add("Exercising");
            this.activityB7.Items.Add("Cooking");
            this.activityB7.Items.Add("Cleaning house or room");
            this.activityB7.Items.Add("Running errands");
            this.activityB7.Items.Add("Other");
            this.activityB7.Location = new System.Drawing.Point(4, 206);
            this.activityB7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityB7.Name = "activityB7";
            this.activityB7.ReadOnly = true;
            this.activityB7.Size = new System.Drawing.Size(265, 26);
            this.activityB7.TabIndex = 8;
            this.activityB7.Text = "Select activity...";
            this.activityB7.SelectedItemChanged += new System.EventHandler(this.ActivityB7_SelectedItemChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.activityTitleLabel);
            this.panel2.Location = new System.Drawing.Point(20, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 116);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 65);
            this.label1.TabIndex = 7;
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
            this.activityAtimer.Location = new System.Drawing.Point(67, 433);
            this.activityAtimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityAtimer.Name = "activityAtimer";
            this.activityAtimer.Size = new System.Drawing.Size(564, 32);
            this.activityAtimer.TabIndex = 10;
            // 
            // hoursValue
            // 
            this.hoursValue.AutoSize = true;
            this.hoursValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursValue.Location = new System.Drawing.Point(316, 6);
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
            this.totalTimeSpendLabel.Location = new System.Drawing.Point(8, 6);
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
            this.hoursLabel.Location = new System.Drawing.Point(356, 6);
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
            this.minutesValue.Location = new System.Drawing.Point(438, 6);
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
            this.minutesLabel.Location = new System.Drawing.Point(484, 6);
            this.minutesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(68, 20);
            this.minutesLabel.TabIndex = 2;
            this.minutesLabel.Text = "Minutes";
            this.minutesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ActivityBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(698, 518);
            this.Controls.Add(this.activityAtimer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nextButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ActivityBForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class B Activities";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hoursB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursB4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursB5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursB6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursB7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesB4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesB5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesB6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesB7)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.activityAtimer.ResumeLayout(false);
            this.activityAtimer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label activityTitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label descriptorHeading;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DomainUpDown activityB1;
        private System.Windows.Forms.Label hoursHeader;
        private System.Windows.Forms.Label minutesHeader;
        private System.Windows.Forms.NumericUpDown hoursB1;
        private System.Windows.Forms.NumericUpDown minutesB1;
        private System.Windows.Forms.NumericUpDown hoursB2;
        private System.Windows.Forms.NumericUpDown hoursB3;
        private System.Windows.Forms.NumericUpDown hoursB4;
        private System.Windows.Forms.Label activitiesLabel;
        private System.Windows.Forms.NumericUpDown hoursB5;
        private System.Windows.Forms.NumericUpDown hoursB6;
        private System.Windows.Forms.NumericUpDown hoursB7;
        private System.Windows.Forms.NumericUpDown minutesB2;
        private System.Windows.Forms.NumericUpDown minutesB3;
        private System.Windows.Forms.NumericUpDown minutesB4;
        private System.Windows.Forms.NumericUpDown minutesB5;
        private System.Windows.Forms.NumericUpDown minutesB6;
        private System.Windows.Forms.NumericUpDown minutesB7;
        private System.Windows.Forms.DomainUpDown activityB2;
        private System.Windows.Forms.DomainUpDown activityB3;
        private System.Windows.Forms.DomainUpDown activityB4;
        private System.Windows.Forms.DomainUpDown activityB5;
        private System.Windows.Forms.DomainUpDown activityB6;
        private System.Windows.Forms.DomainUpDown activityB7;
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