namespace TimeManagementAssignment
{
    partial class InstructionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionForm));
            this.openInstrButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openInstrButton
            // 
            this.openInstrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openInstrButton.Location = new System.Drawing.Point(113, 522);
            this.openInstrButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.openInstrButton.Name = "openInstrButton";
            this.openInstrButton.Size = new System.Drawing.Size(271, 49);
            this.openInstrButton.TabIndex = 0;
            this.openInstrButton.Text = "Open Upload Instructions";
            this.openInstrButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(559, 522);
            this.backButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(98, 49);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instructionLabel.Location = new System.Drawing.Point(54, 113);
            this.instructionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(712, 147);
            this.instructionLabel.TabIndex = 2;
            this.instructionLabel.Text = resources.GetString("instructionLabel.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Assignment Instructions";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InstructionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(828, 584);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.openInstrButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "InstructionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instructions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openInstrButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label label1;
    }
}