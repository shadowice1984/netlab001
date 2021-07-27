﻿namespace LAB001
{
    partial class UserMng
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.UndoBtn = new System.Windows.Forms.Button();
            this.IsModify = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DGVmain = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVmain)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BackBtn.Location = new System.Drawing.Point(1092, 607);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(160, 63);
            this.BackBtn.TabIndex = 8;
            this.BackBtn.Text = "返回主界面";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Enabled = false;
            this.DelBtn.Location = new System.Drawing.Point(1072, 396);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(129, 47);
            this.DelBtn.TabIndex = 12;
            this.DelBtn.Text = "删除此行";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Enabled = false;
            this.SaveBtn.Location = new System.Drawing.Point(1072, 212);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(129, 49);
            this.SaveBtn.TabIndex = 11;
            this.SaveBtn.Text = "保存";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // UndoBtn
            // 
            this.UndoBtn.Enabled = false;
            this.UndoBtn.Location = new System.Drawing.Point(1072, 302);
            this.UndoBtn.Name = "UndoBtn";
            this.UndoBtn.Size = new System.Drawing.Size(129, 50);
            this.UndoBtn.TabIndex = 10;
            this.UndoBtn.Text = "撤销";
            this.UndoBtn.UseVisualStyleBackColor = true;
            this.UndoBtn.Click += new System.EventHandler(this.UndoBtn_Click);
            // 
            // IsModify
            // 
            this.IsModify.Location = new System.Drawing.Point(1072, 124);
            this.IsModify.Name = "IsModify";
            this.IsModify.Size = new System.Drawing.Size(129, 51);
            this.IsModify.TabIndex = 9;
            this.IsModify.Text = "修改用户数据";
            this.IsModify.UseVisualStyleBackColor = true;
            this.IsModify.Click += new System.EventHandler(this.IsModify_Click);
            // 
            // DGVmain
            // 
            this.DGVmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVmain.Location = new System.Drawing.Point(12, 12);
            this.DGVmain.Name = "DGVmain";
            this.DGVmain.RowTemplate.Height = 23;
            this.DGVmain.Size = new System.Drawing.Size(996, 657);
            this.DGVmain.TabIndex = 13;
            this.DGVmain.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DGVDateError);
            // 
            // UserMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.DGVmain);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.UndoBtn);
            this.Controls.Add(this.IsModify);
            this.Controls.Add(this.BackBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserMng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "usermng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserMngClosing);
            this.Load += new System.EventHandler(this.UserMng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVmain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button UndoBtn;
        private System.Windows.Forms.Button IsModify;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView DGVmain;
    }
}