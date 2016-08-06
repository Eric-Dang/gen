namespace gen
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCom = new System.Windows.Forms.Button();
            this.buttonDec = new System.Windows.Forms.Button();
            this.textBoxSelectFile = new System.Windows.Forms.TextBox();
            this.textBoxTargetDir = new System.Windows.Forms.TextBox();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.buttonTargetDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "输出";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCom
            // 
            this.buttonCom.Location = new System.Drawing.Point(55, 91);
            this.buttonCom.Name = "buttonCom";
            this.buttonCom.Size = new System.Drawing.Size(75, 23);
            this.buttonCom.TabIndex = 3;
            this.buttonCom.Text = "com";
            this.buttonCom.UseVisualStyleBackColor = true;
            this.buttonCom.Click += new System.EventHandler(this.OnComButtonClick);
            // 
            // buttonDec
            // 
            this.buttonDec.Location = new System.Drawing.Point(203, 91);
            this.buttonDec.Name = "buttonDec";
            this.buttonDec.Size = new System.Drawing.Size(75, 23);
            this.buttonDec.TabIndex = 4;
            this.buttonDec.Text = "dec";
            this.buttonDec.UseVisualStyleBackColor = true;
            this.buttonDec.Click += new System.EventHandler(this.OnDecButtonClick);
            // 
            // textBoxSelectFile
            // 
            this.textBoxSelectFile.Location = new System.Drawing.Point(61, 18);
            this.textBoxSelectFile.Name = "textBoxSelectFile";
            this.textBoxSelectFile.Size = new System.Drawing.Size(247, 21);
            this.textBoxSelectFile.TabIndex = 5;
            this.textBoxSelectFile.Text = "输入文件名";
            this.textBoxSelectFile.Click += new System.EventHandler(this.OnTextBoxSelectFileClick);
            this.textBoxSelectFile.TextChanged += new System.EventHandler(this.OnTextBoxSelectFileChanged);
            // 
            // textBoxTargetDir
            // 
            this.textBoxTargetDir.Location = new System.Drawing.Point(61, 54);
            this.textBoxTargetDir.Name = "textBoxTargetDir";
            this.textBoxTargetDir.Size = new System.Drawing.Size(247, 21);
            this.textBoxTargetDir.TabIndex = 6;
            this.textBoxTargetDir.Text = "输入文件夹名";
            this.textBoxTargetDir.Click += new System.EventHandler(this.OnTextBoxTargetDirClick);
            this.textBoxTargetDir.TextChanged += new System.EventHandler(this.OnTextBoxTargetDirChanged);
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSelectFile.Location = new System.Drawing.Point(306, 18);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(31, 23);
            this.buttonSelectFile.TabIndex = 7;
            this.buttonSelectFile.Text = "...";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.OnInputButtonClick);
            // 
            // buttonTargetDir
            // 
            this.buttonTargetDir.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTargetDir.Location = new System.Drawing.Point(306, 54);
            this.buttonTargetDir.Name = "buttonTargetDir";
            this.buttonTargetDir.Size = new System.Drawing.Size(31, 23);
            this.buttonTargetDir.TabIndex = 8;
            this.buttonTargetDir.Text = "...";
            this.buttonTargetDir.UseVisualStyleBackColor = true;
            this.buttonTargetDir.Click += new System.EventHandler(this.OnOutputButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 126);
            this.Controls.Add(this.buttonTargetDir);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.textBoxTargetDir);
            this.Controls.Add(this.textBoxSelectFile);
            this.Controls.Add(this.buttonDec);
            this.Controls.Add(this.buttonCom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "小工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCom;
        private System.Windows.Forms.Button buttonDec;
        private System.Windows.Forms.TextBox textBoxSelectFile;
        private System.Windows.Forms.TextBox textBoxTargetDir;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.Button buttonTargetDir;
    }
}

