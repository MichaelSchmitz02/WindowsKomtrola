namespace Zadatak
{
    partial class FormaText
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.programNameTextBox = new System.Windows.Forms.TextBox();
            this.programNameLabel = new System.Windows.Forms.Label();
            this.programDescriptionLabel = new System.Windows.Forms.Label();
            this.programDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(124, 328);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(83, 33);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(465, 328);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(83, 33);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // programNameTextBox
            // 
            this.programNameTextBox.Location = new System.Drawing.Point(292, 93);
            this.programNameTextBox.Multiline = true;
            this.programNameTextBox.Name = "programNameTextBox";
            this.programNameTextBox.Size = new System.Drawing.Size(256, 27);
            this.programNameTextBox.TabIndex = 2;
            // 
            // programNameLabel
            // 
            this.programNameLabel.AutoSize = true;
            this.programNameLabel.Location = new System.Drawing.Point(142, 100);
            this.programNameLabel.Name = "programNameLabel";
            this.programNameLabel.Size = new System.Drawing.Size(117, 20);
            this.programNameLabel.TabIndex = 3;
            this.programNameLabel.Text = "Program name:";
            // 
            // programDescriptionLabel
            // 
            this.programDescriptionLabel.AutoSize = true;
            this.programDescriptionLabel.Location = new System.Drawing.Point(120, 164);
            this.programDescriptionLabel.Name = "programDescriptionLabel";
            this.programDescriptionLabel.Size = new System.Drawing.Size(154, 20);
            this.programDescriptionLabel.TabIndex = 4;
            this.programDescriptionLabel.Text = "Program description:";
            this.programDescriptionLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // programDescriptionTextBox
            // 
            this.programDescriptionTextBox.Location = new System.Drawing.Point(292, 164);
            this.programDescriptionTextBox.Multiline = true;
            this.programDescriptionTextBox.Name = "programDescriptionTextBox";
            this.programDescriptionTextBox.Size = new System.Drawing.Size(256, 27);
            this.programDescriptionTextBox.TabIndex = 5;
            // 
            // FormaText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.programDescriptionTextBox);
            this.Controls.Add(this.programDescriptionLabel);
            this.Controls.Add(this.programNameLabel);
            this.Controls.Add(this.programNameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "FormaText";
            this.Text = "FormaText";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox programNameTextBox;
        private System.Windows.Forms.Label programNameLabel;
        private System.Windows.Forms.Label programDescriptionLabel;
        private System.Windows.Forms.TextBox programDescriptionTextBox;
    }
}