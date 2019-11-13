namespace SanityArchiver
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Compress = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Encrypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.Encryption = new System.Windows.Forms.GroupBox();
            this.button_copy = new System.Windows.Forms.Button();
            this.button_move = new System.Windows.Forms.Button();
            this.Encryption.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "File name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Compress
            // 
            this.Compress.Location = new System.Drawing.Point(92, 65);
            this.Compress.Name = "Compress";
            this.Compress.Size = new System.Drawing.Size(141, 23);
            this.Compress.TabIndex = 3;
            this.Compress.Text = "Compress";
            this.Compress.UseVisualStyleBackColor = true;
            this.Compress.Click += new System.EventHandler(this.Compress_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(92, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Decompress";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(0, 21);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(141, 23);
            this.Encrypt.TabIndex = 5;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(0, 50);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(141, 23);
            this.Decrypt.TabIndex = 6;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(92, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Attributes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(92, 152);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(141, 23);
            this.openFile.TabIndex = 8;
            this.openFile.Text = "Open file";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(6, 89);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(135, 22);
            this.tbPassword.TabIndex = 11;
            // 
            // Encryption
            // 
            this.Encryption.Controls.Add(this.Encrypt);
            this.Encryption.Controls.Add(this.tbPassword);
            this.Encryption.Controls.Add(this.Decrypt);
            this.Encryption.Location = new System.Drawing.Point(437, 12);
            this.Encryption.Name = "Encryption";
            this.Encryption.Size = new System.Drawing.Size(152, 134);
            this.Encryption.TabIndex = 12;
            this.Encryption.TabStop = false;
            this.Encryption.Text = "Encryption";
            // 
            // button_copy
            // 
            this.button_copy.Location = new System.Drawing.Point(92, 182);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(141, 23);
            this.button_copy.TabIndex = 13;
            this.button_copy.Text = "Copy";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // button_move
            // 
            this.button_move.Location = new System.Drawing.Point(92, 212);
            this.button_move.Name = "button_move";
            this.button_move.Size = new System.Drawing.Size(141, 23);
            this.button_move.TabIndex = 14;
            this.button_move.Text = "Move";
            this.button_move.UseVisualStyleBackColor = true;
            this.button_move.Click += new System.EventHandler(this.button_move_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 512);
            this.Controls.Add(this.button_move);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.Encryption);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Compress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Encryption.ResumeLayout(false);
            this.Encryption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Compress;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.GroupBox Encryption;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.Button button_move;
    }
}

