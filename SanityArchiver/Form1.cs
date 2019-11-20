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
        static List<FileInfo> FoundFiles;
        byte[] abc;
        byte[,] table;
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

            //Encrypt en = new Encrypt();
        private void Encrypt_Click(object sender, EventArgs e)
        {            


            string path = openD.FileName;

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Password is empty!");
                return;
            }
            //en.EncryptFile(path);
            try
            {
                byte[] fileContent = File.ReadAllBytes(path);
                byte[] password = Encoding.ASCII.GetBytes(tbPassword.Text);
                byte[] keys = new byte[fileContent.Length];
                for (int i = 0; i < fileContent.Length; i ++)
                {
                    keys[i] = password[i % password.Length];
                }
                
                byte[] result = new byte[fileContent.Length];
                for(int i = 0;i < fileContent.Length; i++)
                {
                    byte value = fileContent[i];
                    byte key = keys[i];
                    int valueIndex = -1, keyIndey = -1;
                    for(int j = 0; j < 256; j++)
                    {
                        if(abc[j] == value)
                        {
                            valueIndex = j;
                            break;
                        }
                    }
                    for(int j = 0; j < 256; j++)
                    {
                        if(abc[j] == key)
                        {
                            keyIndey = j;
                            break;
                        }
                    }
                    result[i] = table[keyIndey, valueIndex];
                }

             
                String fileExt = Path.GetExtension(path);
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "Files (*" + fileExt + ") | *" + fileExt;
                if(sd.ShowDialog () == DialogResult.OK)
                {
                    File.WriteAllBytes(sd.FileName, result);
                }
                

            }
            catch
            {
                MessageBox.Show("File is in use");
                return;
            }
            
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            string path = openD.FileName;
            //en.EncryptFile(path);
            try
            {
                byte[] fileContent = File.ReadAllBytes(path);
                byte[] password = Encoding.ASCII.GetBytes(tbPassword.Text);
                byte[] keys = new byte[fileContent.Length];
                for (int i = 0; i < fileContent.Length; i++)
                {
                    keys[i] = password[i % password.Length];
                }
               
                byte[] result = new byte[fileContent.Length];
                for (int i = 0; i < fileContent.Length; i++)
                {
                    byte value = fileContent[i];
                    byte key = keys[i];
                    int valueIndex = -1, keyIndey = -1;
                      
                    for(int j = 0; j< 256; j++)
                        
                        if(abc[j] == key)
                        {
                            keyIndey = j;
                            break;
                        }
                    for(int j = 0; j< 256; j++)
                    {
                        if(table[keyIndey,j] == value)
                        {
                            valueIndex = j;
                            break;
                        }
                    }
                    result[i] = abc[valueIndex];
                }

                String fileExt = Path.GetExtension(path);
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "Files (*" + fileExt + ") | *" + fileExt;
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(sd.FileName, result);
                }
                
            }
            catch
            {
                MessageBox.Show("File is in use");
                return;
            }
            /*
            string fName = openD.FileName;
            if (fName != null)
            {
                FileInfo fi = new FileInfo(fName);
                string name = fi.Name;
                en.DecryptFile(name);
            }
            */

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filePath = openD.FileName;
            Form2 attributesForm = new Form2(filePath);
            attributesForm.Show();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            string filePath = openD.FileName;

            FileReading reading = new FileReading(filePath);
            reading.Show();

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

            abc = new byte[256];
            for(int i = 0; i<256; i++)
            {
                abc[i] = Convert.ToByte(i);
            }

            table = new byte[256, 256];
            for(int i = 0; i<256; i++)
            {
                for(int j = 0; j < 256; j++)
                {
                    table[i, j] = abc[(i + j) % 256];
                }
            }
        }

        public void copyFile(string source, string destination)
        {
            
            FileStream fsOut = new FileStream(destination, FileMode.Create);
            FileStream fsIn = new FileStream(source, FileMode.Open);
            byte[] bt = new byte[1048756];
            int readByte;

            while((readByte = fsIn.Read(bt, 0, bt.Length)) > 0)
            {
                fsOut.Write(bt, 0, readByte);

            }
            fsIn.Close();
            fsOut.Close();
            
        }
        private void button_copy_Click(object sender, EventArgs e)
        {


            FolderBrowserDialog fb = new FolderBrowserDialog();
            if(fb.ShowDialog() == DialogResult.OK)
            {
                
                copyFile(textBox1.Text, Path.Combine(fb.SelectedPath, Path.GetFileName(textBox1.Text)));
            }
            
        }

        private void button_move_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                copyFile(textBox1.Text, Path.Combine(fb.SelectedPath, Path.GetFileName(textBox1.Text)));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {            
            listView1.Items.Clear();
            FoundFiles = new List<FileInfo>();
            string fileName = textBox2.Text;
            string path = @"d:\teszt";
            
            DirectoryInfo rootDir = new DirectoryInfo(path);
            
            RecursiveSearch(FoundFiles, fileName, rootDir);
            
            if (FoundFiles.Count == 0)
            {
                MessageBox.Show("Nem található a keresett fájl");
            }
            else
            {
                foreach (FileInfo ls in FoundFiles)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = ls.Name;
                    item.SubItems.Add(ls.DirectoryName);
                    listView1.Items.Add(item);                    
                }
            }
            FoundFiles.Clear();
           
        }
        static void RecursiveSearch(List<FileInfo> foundFiles, string fileName, DirectoryInfo currentDirectory)
        {


            foreach (FileInfo fil in currentDirectory.GetFiles(fileName))
            {                              
                foundFiles.Add(fil);                                         
            }
            foreach (DirectoryInfo dir in currentDirectory.GetDirectories())
            {
                RecursiveSearch(foundFiles, fileName, dir);
            }

        }
    }
}
