namespace LAB001
{
    partial class CheckInOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInOut));
            this.ApproveBtn = new System.Windows.Forms.Button();
            this.RejectBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.DGVmain = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGVmain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ApproveBtn
            // 
            this.ApproveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApproveBtn.FlatAppearance.BorderSize = 0;
            this.ApproveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApproveBtn.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ApproveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ApproveBtn.Location = new System.Drawing.Point(718, 595);
            this.ApproveBtn.Name = "ApproveBtn";
            this.ApproveBtn.Size = new System.Drawing.Size(150, 63);
            this.ApproveBtn.TabIndex = 1;
            this.ApproveBtn.Text = "通过申请";
            this.ApproveBtn.UseVisualStyleBackColor = true;
            this.ApproveBtn.Click += new System.EventHandler(this.ApprBtnClicked);
            // 
            // RejectBtn
            // 
            this.RejectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RejectBtn.FlatAppearance.BorderSize = 0;
            this.RejectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RejectBtn.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RejectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RejectBtn.Location = new System.Drawing.Point(425, 594);
            this.RejectBtn.Name = "RejectBtn";
            this.RejectBtn.Size = new System.Drawing.Size(150, 64);
            this.RejectBtn.TabIndex = 2;
            this.RejectBtn.Text = "拒绝申请";
            this.RejectBtn.UseVisualStyleBackColor = true;
            this.RejectBtn.Click += new System.EventHandler(this.RejectBtnClicked);
            // 
            // BackBtn
            // 
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BackBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackBtn.Location = new System.Drawing.Point(12, 603);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(76, 64);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "返回";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackbtnOnClicked);
            // 
            // DGVmain
            // 
            this.DGVmain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVmain.BackgroundColor = System.Drawing.Color.White;
            this.DGVmain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVmain.Location = new System.Drawing.Point(82, 12);
            this.DGVmain.Name = "DGVmain";
            this.DGVmain.RowTemplate.Height = 23;
            this.DGVmain.Size = new System.Drawing.Size(1101, 545);
            this.DGVmain.TabIndex = 4;
            // 
            // CheckInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.DGVmain);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.RejectBtn);
            this.Controls.Add(this.ApproveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckInOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "书刊借还管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckInOutClosing);
            this.Load += new System.EventHandler(this.CheckInOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVmain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ApproveBtn;
        private System.Windows.Forms.Button RejectBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridView DGVmain;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}