namespace TimeManagementAssignment
{
    partial class SummaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryForm));
            this.submitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.goalSettingLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radio5dayWeek = new System.Windows.Forms.RadioButton();
            this.radio6dayWeek = new System.Windows.Forms.RadioButton();
            this.radio7dayWeek = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ClassCHrsSummary = new System.Windows.Forms.Label();
            this.ClassBHrsSummary = new System.Windows.Forms.Label();
            this.ClassAHrsSummary = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.notionalHoursSummary = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(108, 529);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(160, 49);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // backButton
            // 
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(432, 529);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(160, 49);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // goalSettingLabel
            // 
            this.goalSettingLabel.AutoSize = true;
            this.goalSettingLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalSettingLabel.Location = new System.Drawing.Point(293, 23);
            this.goalSettingLabel.Name = "goalSettingLabel";
            this.goalSettingLabel.Size = new System.Drawing.Size(101, 29);
            this.goalSettingLabel.TabIndex = 15;
            this.goalSettingLabel.Text = "Summary";
            this.goalSettingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radio5dayWeek);
            this.panel1.Controls.Add(this.radio6dayWeek);
            this.panel1.Controls.Add(this.radio7dayWeek);
            this.panel1.Location = new System.Drawing.Point(33, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 64);
            this.panel1.TabIndex = 29;
            // 
            // radio5dayWeek
            // 
            this.radio5dayWeek.AutoSize = true;
            this.radio5dayWeek.Location = new System.Drawing.Point(460, 16);
            this.radio5dayWeek.Name = "radio5dayWeek";
            this.radio5dayWeek.Size = new System.Drawing.Size(135, 29);
            this.radio5dayWeek.TabIndex = 28;
            this.radio5dayWeek.TabStop = true;
            this.radio5dayWeek.Text = "5 Day week";
            this.radio5dayWeek.UseVisualStyleBackColor = true;
            this.radio5dayWeek.Enter += new System.EventHandler(this.radio5dayweek_Enter);
            // 
            // radio6dayWeek
            // 
            this.radio6dayWeek.AutoSize = true;
            this.radio6dayWeek.Location = new System.Drawing.Point(240, 16);
            this.radio6dayWeek.Name = "radio6dayWeek";
            this.radio6dayWeek.Size = new System.Drawing.Size(135, 29);
            this.radio6dayWeek.TabIndex = 27;
            this.radio6dayWeek.TabStop = true;
            this.radio6dayWeek.Text = "6 Day week";
            this.radio6dayWeek.UseVisualStyleBackColor = true;
            this.radio6dayWeek.Enter += new System.EventHandler(this.radio6dayweek_Enter);
            // 
            // radio7dayWeek
            // 
            this.radio7dayWeek.AutoSize = true;
            this.radio7dayWeek.Location = new System.Drawing.Point(18, 16);
            this.radio7dayWeek.Name = "radio7dayWeek";
            this.radio7dayWeek.Size = new System.Drawing.Size(135, 29);
            this.radio7dayWeek.TabIndex = 26;
            this.radio7dayWeek.TabStop = true;
            this.radio7dayWeek.Text = "7 Day week";
            this.radio7dayWeek.UseVisualStyleBackColor = true;
            this.radio7dayWeek.Enter += new System.EventHandler(this.radio7dayweek_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.ClassCHrsSummary);
            this.panel2.Controls.Add(this.ClassBHrsSummary);
            this.panel2.Controls.Add(this.ClassAHrsSummary);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.notionalHoursSummary);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(33, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 355);
            this.panel2.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(485, 63);
            this.label6.TabIndex = 25;
            this.label6.Text = "This is the total amount of hours you need to spend on your Class C activities ea" +
    "ch week";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(485, 64);
            this.label9.TabIndex = 24;
            this.label9.Text = "This is the total amount of hours you need to spend on your Class B activities ea" +
    "ch week";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClassCHrsSummary
            // 
            this.ClassCHrsSummary.AutoSize = true;
            this.ClassCHrsSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassCHrsSummary.Location = new System.Drawing.Point(528, 296);
            this.ClassCHrsSummary.Name = "ClassCHrsSummary";
            this.ClassCHrsSummary.Size = new System.Drawing.Size(36, 25);
            this.ClassCHrsSummary.TabIndex = 23;
            this.ClassCHrsSummary.Text = "00";
            // 
            // ClassBHrsSummary
            // 
            this.ClassBHrsSummary.AutoSize = true;
            this.ClassBHrsSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassBHrsSummary.Location = new System.Drawing.Point(528, 205);
            this.ClassBHrsSummary.Name = "ClassBHrsSummary";
            this.ClassBHrsSummary.Size = new System.Drawing.Size(36, 25);
            this.ClassBHrsSummary.TabIndex = 22;
            this.ClassBHrsSummary.Text = "00";
            // 
            // ClassAHrsSummary
            // 
            this.ClassAHrsSummary.AutoSize = true;
            this.ClassAHrsSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassAHrsSummary.Location = new System.Drawing.Point(528, 117);
            this.ClassAHrsSummary.Name = "ClassAHrsSummary";
            this.ClassAHrsSummary.Size = new System.Drawing.Size(36, 25);
            this.ClassAHrsSummary.TabIndex = 21;
            this.ClassAHrsSummary.Text = "00";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(480, 64);
            this.label8.TabIndex = 18;
            this.label8.Text = "This is the total amount of hours you need to spend on your Class A activities ea" +
    "ch week";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // notionalHoursSummary
            // 
            this.notionalHoursSummary.AutoSize = true;
            this.notionalHoursSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notionalHoursSummary.Location = new System.Drawing.Point(528, 29);
            this.notionalHoursSummary.Name = "notionalHoursSummary";
            this.notionalHoursSummary.Size = new System.Drawing.Size(36, 25);
            this.notionalHoursSummary.TabIndex = 17;
            this.notionalHoursSummary.Text = "00";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(480, 58);
            this.label7.TabIndex = 16;
            this.label7.Text = "This is the total amount of hours you need to spend on your studies each week";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SummaryForm
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.backButton;
            this.ClientSize = new System.Drawing.Size(709, 595);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.goalSettingLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.submitButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summary";
            this.Load += new System.EventHandler(this.GoalsSettingMenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label goalSettingLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radio5dayWeek;
        private System.Windows.Forms.RadioButton radio6dayWeek;
        private System.Windows.Forms.RadioButton radio7dayWeek;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ClassCHrsSummary;
        private System.Windows.Forms.Label ClassBHrsSummary;
        private System.Windows.Forms.Label ClassAHrsSummary;
        private System.Windows.Forms.Label notionalHoursSummary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}