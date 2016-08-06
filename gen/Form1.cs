using System;
using LZ4Sharp;
using System.IO;
using System.Windows.Forms;

namespace gen
{
    public partial class Form1 : Form
    {
        LZ4Compressor32 lzc = new LZ4Compressor32();
        LZ4Decompressor32 lzd = new LZ4Decompressor32();

        bool textBoxSelectFileHasInit = false;
        bool textBoxTargetDirHasInit  = false;

        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
        }

        private void OnComButtonClick(object sender, EventArgs e)
        {
            if (!Directory.Exists(textBoxTargetDir.Text))
            {
                MessageBox.Show("目标文件夹不存在");
                return;
            }

            string srcFilePath = textBoxSelectFile.Text;
            string fileName = Path.GetFileName(srcFilePath);
            string targetFile = textBoxTargetDir.Text + "/" + fileName + ".cg";

            // 选择合适的文件名
            string temp = targetFile;
            int count = 1;
            while (File.Exists(targetFile))
            {
                temp = targetFile + count++;
            }
            targetFile = temp;
           

            byte[] fileData = File.ReadAllBytes(srcFilePath);
            byte[] cData = lzc.Compress(fileData);
            File.WriteAllBytes(targetFile, cData);
        }

        private void OnDecButtonClick(object sender, EventArgs e)
        {
            if (!Directory.Exists(textBoxTargetDir.Text))
            {
                MessageBox.Show("目标文件夹不存在");
                return;
            }

            string srcFilePath = textBoxSelectFile.Text;
            string fileName = Path.GetFileName(srcFilePath);
            if (fileName.EndsWith(".cg"))
            {
                fileName = fileName.Substring(0, fileName.Length - 3);
            }
            else
            {
                fileName = fileName + ".dg";
            }

            string targetFile = textBoxTargetDir.Text + "/" + fileName;

            // 选择合适的文件名
            string temp = targetFile;
            int count = 1;
            while (File.Exists(targetFile))
            {
                temp = targetFile + count++;
            }
            targetFile = temp;

            byte[] fileData = File.ReadAllBytes(srcFilePath);
            byte[] cData = lzd.Decompress(fileData);
            File.WriteAllBytes(targetFile, cData);
        }

        private void OnInputButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "选择目标文件";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {                
                textBoxSelectFile.Text = openFileDialog.FileName;
                if(!textBoxTargetDirHasInit || textBoxTargetDir.Text =="")
                {
                    textBoxTargetDir.Text = Path.GetDirectoryName(textBoxSelectFile.Text);
                }
            }
        }

        private void OnOutputButtonClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "选择存放路径";

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxTargetDir.Text = folderDialog.SelectedPath;
            }
        }

        private void OnTextBoxSelectFileClick(object sender, EventArgs e)
        {
            if (!textBoxSelectFileHasInit)
            {
                textBoxSelectFile.Text = "";
                textBoxSelectFileHasInit = true;
            }
        }

        private void OnTextBoxTargetDirClick(object sender, EventArgs e)
        {
            if (!textBoxTargetDirHasInit)
            {
                textBoxTargetDir.Text = "";
                textBoxTargetDirHasInit = true;
            }
        }

        private void OnTextBoxSelectFileChanged(object sender, EventArgs e)
        {
            textBoxSelectFileHasInit = true;
        }

        private void OnTextBoxTargetDirChanged(object sender, EventArgs e)
        {
            textBoxTargetDirHasInit = true;
        }
    }
}
