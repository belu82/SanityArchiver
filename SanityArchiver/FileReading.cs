using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SanityArchiver
{

    public partial class FileReading : Form
    {
        public string filePath { get; set; }

        public FileReading(string filePath)
        {
            InitializeComponent();
            this.filePath = filePath;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            StreamReader read = new StreamReader(filePath, Encoding.Default);
            
            textBox1.Text = read.ReadToEnd();
            FileAttributes attributes = File.GetAttributes(filePath);
            if((attributes & FileAttributes.Encrypted) == FileAttributes.Encrypted)
            {
                label1.Text = "Kódolva van!";
            }
            read.Close();
        
        }
    }
}
