using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanityArchiver
{
    public partial class Form2 : Form
    {

        public string filePath { get; set; }
        public Form2(String filePath)
        {
            InitializeComponent();
            this.filePath = filePath;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }


            FileAttributes attributes = File.GetAttributes(filePath);
            if (Hide.Checked)
            {

                File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.Hidden);
            }
            else if (removeHide.Checked)
            {
                if((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                {
                    attributes = RemoveAttribute(attributes, FileAttributes.Hidden);
                    File.SetAttributes(filePath, attributes);
                }
            }
            else if (readOnly.Checked)
            {
                File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.ReadOnly);
            }
        }
        private static FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
        {
            return attributes & ~attributesToRemove;
        }

    }
}
