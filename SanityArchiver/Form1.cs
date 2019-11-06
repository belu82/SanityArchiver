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
using System.IO.Compression;


namespace SanityArchiver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        OpenFileDialog openD = new OpenFileDialog();

        private void button1_Click_1(object sender, EventArgs e)
        {
            openD.Title = "File browsing";
            openD.InitialDirectory = @"D:\";
            openD.Filter = "All files (*.*) |*.*|All files (*.*)|*.*";
            openD.FilterIndex = 2;
            openD.RestoreDirectory = true;
            if (openD.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = Path.GetFileName(openD.FileName);
            }
        }

        CompressingFile compr = new CompressingFile(); 
        private void Compress_Click(object sender, EventArgs e)
        {
            string path = openD.FileName;
            FileInfo fileInfo = new FileInfo(path);
            compr.Compress(fileInfo);

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            string path = openD.FileName;
            FileInfo fileInfo = new FileInfo(path);
            compr.Decompress(fileInfo);
        }
    }
}
