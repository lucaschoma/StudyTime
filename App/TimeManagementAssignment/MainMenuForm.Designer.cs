namespace TimeManagementAssignment
{
    partial class MainMenuForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.beginButton = new System.Windows.Forms.Button();
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.StudentDetailsInstruction = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.stdNmbrLabel = new System.Windows.Forms.Label();
            this.stdNmbrTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stdDetailsLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.surnameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // beginButton
            // 
            this.beginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginButton.Location = new System.Drawing.Point(263, 270);
            this.beginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(130, 43);
            this.beginButton.TabIndex = 2;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.BeginButton_Click);
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLabel.ForeColor = System.Drawing.Color.Navy;
            this.helloWorldLabel.Location = new System.Drawing.Point(12, 10);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(595, 49);
            this.helloWorldLabel.TabIndex = 3;
            this.helloWorldLabel.Text = "Time Management and Goal Setting";
            this.helloWorldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentDetailsInstruction
            // 
            this.StudentDetailsInstruction.AutoSize = true;
            this.StudentDetailsInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentDetailsInstruction.Location = new System.Drawing.Point(33, 16);
            this.StudentDetailsInstruction.Name = "StudentDetailsInstruction";
            this.StudentDetailsInstruction.Size = new System.Drawing.Size(577, 24);
            this.StudentDetailsInstruction.TabIndex = 1;
            this.StudentDetailsInstruction.Text = "Please fill in your details below, then click on \"Begin\" to start.";
            this.StudentDetailsInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 54);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(75, 25);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name: ";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLabel.Location = new System.Drawing.Point(12, 113);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(103, 25);
            this.surnameLabel.TabIndex = 6;
            this.surnameLabel.Text = "Surname: ";
            this.surnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stdNmbrLabel
            // 
            this.stdNmbrLabel.AutoSize = true;
            this.stdNmbrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdNmbrLabel.Location = new System.Drawing.Point(12, 170);
            this.stdNmbrLabel.Name = "stdNmbrLabel";
            this.stdNmbrLabel.Size = new System.Drawing.Size(165, 25);
            this.stdNmbrLabel.TabIndex = 6;
            this.stdNmbrLabel.Text = "Student Number: ";
            this.stdNmbrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stdNmbrTextBox
            // 
            this.stdNmbrTextBox.BeepOnError = true;
            this.stdNmbrTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdNmbrTextBox.Location = new System.Drawing.Point(190, 168);
            this.stdNmbrTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stdNmbrTextBox.Name = "stdNmbrTextBox";
            this.stdNmbrTextBox.Size = new System.Drawing.Size(211, 30);
            this.stdNmbrTextBox.TabIndex = 7;
            this.stdNmbrTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stdNmbrTextBox_KeyPress);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(190, 54);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(211, 30);
            this.nameTextBox.TabIndex = 8;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameTextBox.Location = new System.Drawing.Point(190, 110);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(211, 30);
            this.surnameTextBox.TabIndex = 9;
            this.surnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTextBox_KeyPress);
            this.surnameTextBox.Leave += new System.EventHandler(this.surnameTextBox_Leave);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.stdDetailsLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.surnameTextBox);
            this.panel1.Controls.Add(this.surnameLabel);
            this.panel1.Controls.Add(this.stdNmbrTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.stdNmbrLabel);
            this.panel1.Location = new System.Drawing.Point(121, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 208);
            this.panel1.TabIndex = 10;
            // 
            // stdDetailsLabel
            // 
            this.stdDetailsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stdDetailsLabel.AutoSize = true;
            this.stdDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdDetailsLabel.Location = new System.Drawing.Point(123, 12);
            this.stdDetailsLabel.Name = "stdDetailsLabel";
            this.stdDetailsLabel.Size = new System.Drawing.Size(159, 25);
            this.stdDetailsLabel.TabIndex = 10;
            this.stdDetailsLabel.Text = "Student Details";
            this.stdDetailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.StudentDetailsInstruction);
            this.panel2.Controls.Add(this.beginButton);
            this.panel2.Location = new System.Drawing.Point(57, 158);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 328);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.helloWorldLabel);
            this.panel3.Location = new System.Drawing.Point(57, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(646, 67);
            this.panel3.TabIndex = 12;
            // 
            // surnameToolTip
            // 
            this.surnameToolTip.ShowAlways = true;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(760, 562);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.Label StudentDetailsInstruction;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label stdNmbrLabel;
        private System.Windows.Forms.MaskedTextBox stdNmbrTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label stdDetailsLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolTip surnameToolTip;
    }
}