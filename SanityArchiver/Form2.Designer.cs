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
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.removeReadOnly = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Hide
            // 
            this.Hide.AutoSize = true;
            this.Hide.Location = new System.Drawing.Point(150, 3);
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
            this.removeHide.Location = new System.Drawing.Point(249, 3);
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
            this.readOnly.Location = new System.Drawing.Point(150, 30);
            this.readOnly.Name = "readOnly";
            this.readOnly.Size = new System.Drawing.Size(93, 21);
            this.readOnly.TabIndex = 2;
            this.readOnly.TabStop = true;
            this.readOnly.Text = "Read only";
            this.readOnly.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Enabled = false;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Hidden",
            "ReadOnly"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(132, 106);
            this.checkedListBox1.TabIndex = 6;
            // 
            // removeReadOnly
            // 
            this.removeReadOnly.AutoSize = true;
            this.removeReadOnly.Location = new System.Drawing.Point(249, 30);
            this.removeReadOnly.Name = "removeReadOnly";
            this.removeReadOnly.Size = new System.Drawing.Size(140, 21);
            this.removeReadOnly.TabIndex = 7;
            this.removeReadOnly.TabStop = true;
            this.removeReadOnly.Text = "Remove readonly";
            this.removeReadOnly.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 362);
            this.Controls.Add(this.removeReadOnly);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.readOnly);
            this.Controls.Add(this.removeHide);
            this.Controls.Add(this.Hide);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Hide;
        private System.Windows.Forms.RadioButton removeHide;
        private System.Windows.Forms.RadioButton readOnly;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label selectedFile;
        private System.Windows.Forms.RadioButton removeReadOnly;
    }
}