using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openD = new OpenFileDialog();
            openD.Title = "File browsing";
            openD.InitialDirectory = @"D:\";
            openD.Filter = "All files (*.*) |*.*|All files (*.*)|*.*";
            openD.FilterIndex = 2;
            openD.RestoreDirectory = true;
            if(openD.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openD.FileName;
            }
        }
    }
}
