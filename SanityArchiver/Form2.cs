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
        public FileInfo fileSelected;
        List<string> currentAttribute;
        public string filePath { get; set; }
        public Form2(String filePath)
        {
            InitializeComponent();
            this.filePath = filePath;

        }

        private List<string> attributes()
        {
            FileAttributes attributes = File.GetAttributes(filePath);
            currentAttribute = new List<string>();
            
            if((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                {
                currentAttribute.Add("Hidden");
            }
           
            if((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                currentAttribute.Add("ReadOnly");
            }
            return currentAttribute;
        }
        private void button1_Click(object sender, EventArgs e)
        {

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
            if (readOnly.Checked)
            {
                File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.ReadOnly);
            }else if (removeReadOnly.Checked)
            {
                if((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                {
                    attributes = RemoveAttribute(attributes, FileAttributes.ReadOnly);
                    File.SetAttributes(filePath, attributes);
                }
            }

            this.Close();

        }
        private static FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
        {
            return attributes & ~attributesToRemove;
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {
            List<string> list = attributes();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (list.Contains(checkedListBox1.Items[i].ToString()))
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
        }

        
        
       
    }
}
