namespace TimeManagementAssignment
{
    partial class GoalsSettingMenuForm
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
            this.submitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.goalSettingLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radio7dayweek = new System.Windows.Forms.RadioButton();
            this.radio6dayweek = new System.Windows.Forms.RadioButton();
            this.radio5dayweek = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.notionalsummarylabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClassAvalue = new System.Windows.Forms.Label();
            this.ClassBValue = new System.Windows.Forms.Label();
            this.ClassCValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(43, 519);
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
            this.backButton.Location = new System.Drawing.Point(498, 519);
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
            this.goalSettingLabel.Location = new System.Drawing.Point(300, 23);
            this.goalSettingLabel.Name = "goalSettingLabel";
            this.goalSettingLabel.Size = new System.Drawing.Size(101, 29);
            this.goalSettingLabel.TabIndex = 15;
            this.goalSettingLabel.Text = "Summary";
            this.goalSettingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radio5dayweek);
            this.panel1.Controls.Add(this.radio6dayweek);
            this.panel1.Controls.Add(this.radio7dayweek);
            this.panel1.Location = new System.Drawing.Point(43, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 86);
            this.panel1.TabIndex = 29;
            // 
            // radio7dayweek
            // 
            this.radio7dayweek.AutoSize = true;
            this.radio7dayweek.Location = new System.Drawing.Point(3, 54);
            this.radio7dayweek.Name = "radio7dayweek";
            this.radio7dayweek.Size = new System.Drawing.Size(135, 29);
            this.radio7dayweek.TabIndex = 26;
            this.radio7dayweek.TabStop = true;
            this.radio7dayweek.Text = "7 Day week";
            this.radio7dayweek.UseVisualStyleBackColor = true;
            this.radio7dayweek.Enter += new System.EventHandler(this.radio7dayweek_Enter);
            // 
            // radio6dayweek
            // 
            this.radio6dayweek.AutoSize = true;
            this.radio6dayweek.Location = new System.Drawing.Point(260, 54);
            this.radio6dayweek.Name = "radio6dayweek";
            this.radio6dayweek.Size = new System.Drawing.Size(135, 29);
            this.radio6dayweek.TabIndex = 27;
            this.radio6dayweek.TabStop = true;
            this.radio6dayweek.Text = "6 Day week";
            this.radio6dayweek.UseVisualStyleBackColor = true;
            this.radio6dayweek.Enter += new System.EventHandler(this.radio6dayweek_Enter);
            // 
            // radio5dayweek
            // 
            this.radio5dayweek.AutoSize = true;
            this.radio5dayweek.Location = new System.Drawing.Point(455, 54);
            this.radio5dayweek.Name = "radio5dayweek";
            this.radio5dayweek.Size = new System.Drawing.Size(135, 29);
            this.radio5dayweek.TabIndex = 28;
            this.radio5dayweek.TabStop = true;
            this.radio5dayweek.Text = "5 Day week";
            this.radio5dayweek.UseVisualStyleBackColor = true;
            this.radio5dayweek.Enter += new System.EventHandler(this.radio5dayweek_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ClassCValue);
            this.panel2.Controls.Add(this.ClassBValue);
            this.panel2.Controls.Add(this.ClassAvalue);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.notionalsummarylabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(43, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 352);
            this.panel2.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 50);
            this.label1.TabIndex = 16;
            this.label1.Text = "This is the total amount of hours you \r\nneed to spend on your studies each week";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // notionalsummarylabel
            // 
            this.notionalsummarylabel.AutoSize = true;
            this.notionalsummarylabel.Location = new System.Drawing.Point(464, 33);
            this.notionalsummarylabel.Name = "notionalsummarylabel";
            this.notionalsummarylabel.Size = new System.Drawing.Size(64, 25);
            this.notionalsummarylabel.TabIndex = 17;
            this.notionalsummarylabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 75);
            this.label3.TabIndex = 18;
            this.label3.Text = "This is the total amount of hours you \r\nneed to spend on your Class A activities\r" +
    "\neach week";
            // 
            // ClassAvalue
            // 
            this.ClassAvalue.AutoSize = true;
            this.ClassAvalue.Location = new System.Drawing.Point(464, 109);
            this.ClassAvalue.Name = "ClassAvalue";
            this.ClassAvalue.Size = new System.Drawing.Size(64, 25);
            this.ClassAvalue.TabIndex = 21;
            this.ClassAvalue.Text = "label6";
            // 
            // ClassBValue
            // 
            this.ClassBValue.AutoSize = true;
            this.ClassBValue.Location = new System.Drawing.Point(464, 191);
            this.ClassBValue.Name = "ClassBValue";
            this.ClassBValue.Size = new System.Drawing.Size(64, 25);
            this.ClassBValue.TabIndex = 22;
            this.ClassBValue.Text = "label7";
            // 
            // ClassCValue
            // 
            this.ClassCValue.AutoSize = true;
            this.ClassCValue.Location = new System.Drawing.Point(464, 285);
            this.ClassCValue.Name = "ClassCValue";
            this.ClassCValue.Size = new System.Drawing.Size(64, 25);
            this.ClassCValue.TabIndex = 23;
            this.ClassCValue.Text = "label8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 75);
            this.label2.TabIndex = 24;
            this.label2.Text = "This is the total amount of hours you \r\nneed to spend on your Class B activities\r" +
    "\neach week";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 75);
            this.label4.TabIndex = 25;
            this.label4.Text = "This is the total amount of hours you \r\nneed to spend on your Class C activities\r" +
    "\neach week";
            // 
            // GoalsSettingMenuForm
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "GoalsSettingMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goals Setting";
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
        private System.Windows.Forms.RadioButton radio5dayweek;
        private System.Windows.Forms.RadioButton radio6dayweek;
        private System.Windows.Forms.RadioButton radio7dayweek;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ClassCValue;
        private System.Windows.Forms.Label ClassBValue;
        private System.Windows.Forms.Label ClassAvalue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label notionalsummarylabel;
        private System.Windows.Forms.Label label1;
    }
}