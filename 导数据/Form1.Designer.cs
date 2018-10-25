namespace GenerateSQL
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.lblCols = new System.Windows.Forms.Label();
            this.txtCols = new System.Windows.Forms.RichTextBox();
            this.txtSQL = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fileSelect = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMCols = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMValue = new System.Windows.Forms.TextBox();
            this.ckNull = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(44, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "表名：";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(87, 25);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(234, 21);
            this.txtTableName.TabIndex = 1;
            // 
            // lblCols
            // 
            this.lblCols.AutoSize = true;
            this.lblCols.Location = new System.Drawing.Point(44, 85);
            this.lblCols.Name = "lblCols";
            this.lblCols.Size = new System.Drawing.Size(41, 12);
            this.lblCols.TabIndex = 2;
            this.lblCols.Text = "字段：";
            // 
            // txtCols
            // 
            this.txtCols.Location = new System.Drawing.Point(87, 82);
            this.txtCols.Name = "txtCols";
            this.txtCols.Size = new System.Drawing.Size(778, 64);
            this.txtCols.TabIndex = 3;
            this.txtCols.Text = "";
            // 
            // txtSQL
            // 
            this.txtSQL.Location = new System.Drawing.Point(87, 207);
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(778, 303);
            this.txtSQL.TabIndex = 4;
            this.txtSQL.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "生成代码：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "生成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileSelect
            // 
            this.fileSelect.FileName = "openFileDialog1";
            this.fileSelect.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(464, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "选择Excel数据";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(88, 162);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(351, 21);
            this.txtFileName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "文件名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "固定值列：";
            // 
            // txtMCols
            // 
            this.txtMCols.Location = new System.Drawing.Point(87, 53);
            this.txtMCols.Name = "txtMCols";
            this.txtMCols.Size = new System.Drawing.Size(328, 21);
            this.txtMCols.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "值：";
            // 
            // txtMValue
            // 
            this.txtMValue.Location = new System.Drawing.Point(462, 52);
            this.txtMValue.Name = "txtMValue";
            this.txtMValue.Size = new System.Drawing.Size(401, 21);
            this.txtMValue.TabIndex = 9;
            // 
            // ckNull
            // 
            this.ckNull.AutoSize = true;
            this.ckNull.Location = new System.Drawing.Point(782, 163);
            this.ckNull.Name = "ckNull";
            this.ckNull.Size = new System.Drawing.Size(90, 16);
            this.ckNull.TabIndex = 11;
            this.ckNull.Text = "NullOrEmpty";
            this.ckNull.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(909, 601);
            this.Controls.Add(this.ckNull);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMValue);
            this.Controls.Add(this.txtMCols);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSQL);
            this.Controls.Add(this.txtCols);
            this.Controls.Add(this.lblCols);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "导数据";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label lblCols;
        private System.Windows.Forms.RichTextBox txtCols;
        private System.Windows.Forms.RichTextBox txtSQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog fileSelect;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMCols;
        private System.Windows.Forms.TextBox txtMValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckNull;
    }
}

