namespace LAB001
{
    partial class BookQry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.AddBookFilter = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PreviewLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.DGVmain = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVmain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(695, 28);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(95, 23);
            this.ResetBtn.TabIndex = 1;
            this.ResetBtn.Text = "重置筛选规则";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(276, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 21);
            this.textBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BackBtn);
            this.panel1.Controls.Add(this.AddBookFilter);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.ResetBtn);
            this.panel1.Location = new System.Drawing.Point(12, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 78);
            this.panel1.TabIndex = 3;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(1099, 11);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(138, 57);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.Text = "返回主界面";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // AddBookFilter
            // 
            this.AddBookFilter.Location = new System.Drawing.Point(582, 28);
            this.AddBookFilter.Name = "AddBookFilter";
            this.AddBookFilter.Size = new System.Drawing.Size(98, 23);
            this.AddBookFilter.TabIndex = 4;
            this.AddBookFilter.Text = "添加筛选规则";
            this.AddBookFilter.UseVisualStyleBackColor = true;
            this.AddBookFilter.Click += new System.EventHandler(this.AddBookFilter_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ISBN码",
            "书名",
            "作者",
            "其他作者",
            "图书代码",
            "出版社",
            "出版日期",
            "数目",
            "在馆数目"});
            this.comboBox1.Location = new System.Drawing.Point(3, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(267, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // PreviewLabel
            // 
            this.PreviewLabel.BackColor = System.Drawing.Color.White;
            this.PreviewLabel.Location = new System.Drawing.Point(12, 9);
            this.PreviewLabel.Name = "PreviewLabel";
            this.PreviewLabel.Size = new System.Drawing.Size(1240, 55);
            this.PreviewLabel.TabIndex = 4;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResultLabel.Location = new System.Drawing.Point(605, 169);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(74, 21);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = "查询结果";
            // 
            // DGVmain
            // 
            this.DGVmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVmain.Location = new System.Drawing.Point(12, 202);
            this.DGVmain.Name = "DGVmain";
            this.DGVmain.RowTemplate.Height = 23;
            this.DGVmain.Size = new System.Drawing.Size(1240, 468);
            this.DGVmain.TabIndex = 6;
            // 
            // BookQry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.DGVmain);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.PreviewLabel);
            this.Controls.Add(this.panel1);
            this.Name = "BookQry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bookqry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookQryClosing);
            this.Load += new System.EventHandler(this.BookQryLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVmain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label PreviewLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button AddBookFilter;
        private System.Windows.Forms.DataGridView DGVmain;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}