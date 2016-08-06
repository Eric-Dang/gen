using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LZ4Sharp;
using System.IO;

namespace gen
{
    public partial class Form1 : Form
    {
        LZ4Compressor32 lzc = new LZ4Compressor32();
        LZ4Decompressor32 lzd = new LZ4Decompressor32();

        public Form1()
        {
            InitializeComponent();
        }

        private void OnComButtonClick(object sender, EventArgs e)
        {
            string srcFilePath = comboBox_SelectFile.Text;
            string fileName = Path.GetFileName(srcFilePath);
            string targetFile = comboBox_TargetDir.Text + "/" + fileName + ".cg";

            byte[] fileData = File.ReadAllBytes(srcFilePath);
            byte [] cData = lzc.Compress(fileData);
            File.WriteAllBytes(targetFile, cData);
        }

        private void OnDecButtonClick(object sender, EventArgs e)
        {
            string srcFilePath = comboBox_SelectFile.Text;
            string fileName = Path.GetFileName(srcFilePath);
            if (fileName.EndsWith(".cg"))
            {
                fileName = fileName.Substring(0, fileName.Length - 3);
            }
            else
            {
                fileName = fileName + ".dg";
            }
            string targetFile = comboBox_TargetDir.Text + "/" + fileName;
            byte[] fileData = File.ReadAllBytes(srcFilePath);
            byte[] cData = lzd.Decompress(fileData);
            File.WriteAllBytes(targetFile, cData);
        }

        private void OnInputComboBoxClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {                
                comboBox_SelectFile.Text = openFileDialog.FileName;
            }
        }

        private void OnOutputComboBoxClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                comboBox_TargetDir.Text = folderDialog.SelectedPath;
            }
        }
    }
}
