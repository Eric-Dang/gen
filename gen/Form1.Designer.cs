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
            this.comboBox_SelectFile = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_TargetDir = new System.Windows.Forms.ComboBox();
            this.buttonCom = new System.Windows.Forms.Button();
            this.buttonDec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_SelectFile
            // 
            this.comboBox_SelectFile.FormattingEnabled = true;
            this.comboBox_SelectFile.Location = new System.Drawing.Point(98, 18);
            this.comboBox_SelectFile.Name = "comboBox_SelectFile";
            this.comboBox_SelectFile.Size = new System.Drawing.Size(225, 20);
            this.comboBox_SelectFile.TabIndex = 0;
            this.comboBox_SelectFile.Text = "输入文件名";
            this.comboBox_SelectFile.Click += new System.EventHandler(this.OnInputComboBoxClick);
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
            // comboBox_TargetDir
            // 
            this.comboBox_TargetDir.FormattingEnabled = true;
            this.comboBox_TargetDir.Location = new System.Drawing.Point(98, 54);
            this.comboBox_TargetDir.Name = "comboBox_TargetDir";
            this.comboBox_TargetDir.Size = new System.Drawing.Size(225, 20);
            this.comboBox_TargetDir.TabIndex = 2;
            this.comboBox_TargetDir.Text = "输入文件夹名";
            this.comboBox_TargetDir.Click += new System.EventHandler(this.OnOutputComboBoxClick);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 126);
            this.Controls.Add(this.buttonDec);
            this.Controls.Add(this.buttonCom);
            this.Controls.Add(this.comboBox_TargetDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_SelectFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "小工具";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_SelectFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_TargetDir;
        private System.Windows.Forms.Button buttonCom;
        private System.Windows.Forms.Button buttonDec;
    }
}

