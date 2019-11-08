namespace SanityArchiver
{
    partial class Form2
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
            this.Hide = new System.Windows.Forms.RadioButton();
            this.removeHide = new System.Windows.Forms.RadioButton();
            this.readOnly = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Hide
            // 
            this.Hide.AutoSize = true;
            this.Hide.Location = new System.Drawing.Point(45, 30);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(58, 21);
            this.Hide.TabIndex = 0;
            this.Hide.TabStop = true;
            this.Hide.Text = "Hide";
            this.Hide.UseVisualStyleBackColor = true;
            // 
            // removeHide
            // 
            this.removeHide.AutoSize = true;
            this.removeHide.Location = new System.Drawing.Point(45, 77);
            this.removeHide.Name = "removeHide";
            this.removeHide.Size = new System.Drawing.Size(112, 21);
            this.removeHide.TabIndex = 1;
            this.removeHide.TabStop = true;
            this.removeHide.Text = "Remove hide";
            this.removeHide.UseVisualStyleBackColor = true;
            // 
            // readOnly
            // 
            this.readOnly.AutoSize = true;
            this.readOnly.Location = new System.Drawing.Point(45, 127);
            this.readOnly.Name = "readOnly";
            this.readOnly.Size = new System.Drawing.Size(93, 21);
            this.readOnly.TabIndex = 2;
            this.readOnly.TabStop = true;
            this.readOnly.Text = "Read only";
            this.readOnly.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(45, 175);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(110, 21);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.readOnly);
            this.Controls.Add(this.removeHide);
            this.Controls.Add(this.Hide);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Hide;
        private System.Windows.Forms.RadioButton removeHide;
        private System.Windows.Forms.RadioButton readOnly;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button button1;
    }
}