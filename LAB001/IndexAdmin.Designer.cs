
namespace LAB001
{
    partial class IndexAdmin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CheckInOutBtn = new System.Windows.Forms.Button();
            this.BookMngBtn = new System.Windows.Forms.Button();
            this.UserMngBtn = new System.Windows.Forms.Button();
            this.QryLayout = new System.Windows.Forms.TableLayoutPanel();
            this.UserQryBtn = new System.Windows.Forms.Button();
            this.RecordQryBtn = new System.Windows.Forms.Button();
            this.BookQryBtn = new System.Windows.Forms.Button();
            this.QryBtn = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.QryLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LAB001.Properties.Resources.pic1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(240, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(725, 486);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CheckInOutBtn
            // 
            this.CheckInOutBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckInOutBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckInOutBtn.Location = new System.Drawing.Point(95, 540);
            this.CheckInOutBtn.Name = "CheckInOutBtn";
            this.CheckInOutBtn.Size = new System.Drawing.Size(179, 79);
            this.CheckInOutBtn.TabIndex = 2;
            this.CheckInOutBtn.Text = "书刊借还";
            this.CheckInOutBtn.UseVisualStyleBackColor = true;
            this.CheckInOutBtn.Click += new System.EventHandler(this.CheckInOutBtnOnClicked);
            // 
            // BookMngBtn
            // 
            this.BookMngBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookMngBtn.Location = new System.Drawing.Point(318, 540);
            this.BookMngBtn.Name = "BookMngBtn";
            this.BookMngBtn.Size = new System.Drawing.Size(179, 79);
            this.BookMngBtn.TabIndex = 3;
            this.BookMngBtn.Text = "书刊管理";
            this.BookMngBtn.UseVisualStyleBackColor = true;
            this.BookMngBtn.Click += new System.EventHandler(this.BookMngBtnOnClicked);
            // 
            // UserMngBtn
            // 
            this.UserMngBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserMngBtn.Location = new System.Drawing.Point(537, 540);
            this.UserMngBtn.Name = "UserMngBtn";
            this.UserMngBtn.Size = new System.Drawing.Size(179, 79);
            this.UserMngBtn.TabIndex = 4;
            this.UserMngBtn.Text = "用户管理";
            this.UserMngBtn.UseVisualStyleBackColor = true;
            this.UserMngBtn.Click += new System.EventHandler(this.UserMngBtnOnClicked);
            // 
            // QryLayout
            // 
            this.QryLayout.ColumnCount = 1;
            this.QryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.QryLayout.Controls.Add(this.UserQryBtn, 0, 1);
            this.QryLayout.Controls.Add(this.RecordQryBtn, 0, 2);
            this.QryLayout.Controls.Add(this.BookQryBtn, 0, 0);
            this.QryLayout.Location = new System.Drawing.Point(761, 520);
            this.QryLayout.Name = "QryLayout";
            this.QryLayout.RowCount = 3;
            this.QryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.QryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.QryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.QryLayout.Size = new System.Drawing.Size(191, 121);
            this.QryLayout.TabIndex = 5;
            this.QryLayout.Visible = false;
            this.QryLayout.MouseLeave += new System.EventHandler(this.QryLayerLeave);
            // 
            // UserQryBtn
            // 
            this.UserQryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserQryBtn.Location = new System.Drawing.Point(3, 43);
            this.UserQryBtn.Name = "UserQryBtn";
            this.UserQryBtn.Size = new System.Drawing.Size(185, 34);
            this.UserQryBtn.TabIndex = 1;
            this.UserQryBtn.Text = "用户查询";
            this.UserQryBtn.UseVisualStyleBackColor = true;
            this.UserQryBtn.Click += new System.EventHandler(this.UserQryBtn_Click);
            this.UserQryBtn.MouseLeave += new System.EventHandler(this.UserQryBtnLeave);
            // 
            // RecordQryBtn
            // 
            this.RecordQryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecordQryBtn.Location = new System.Drawing.Point(3, 83);
            this.RecordQryBtn.Name = "RecordQryBtn";
            this.RecordQryBtn.Size = new System.Drawing.Size(185, 35);
            this.RecordQryBtn.TabIndex = 2;
            this.RecordQryBtn.Text = "借还查询";
            this.RecordQryBtn.UseVisualStyleBackColor = true;
            this.RecordQryBtn.Click += new System.EventHandler(this.RecordQryBtn_Click);
            this.RecordQryBtn.MouseLeave += new System.EventHandler(this.RecordQryBtnLeave);
            // 
            // BookQryBtn
            // 
            this.BookQryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookQryBtn.Location = new System.Drawing.Point(3, 3);
            this.BookQryBtn.Name = "BookQryBtn";
            this.BookQryBtn.Size = new System.Drawing.Size(185, 34);
            this.BookQryBtn.TabIndex = 0;
            this.BookQryBtn.Text = "书刊查询";
            this.BookQryBtn.UseVisualStyleBackColor = true;
            this.BookQryBtn.Click += new System.EventHandler(this.BookQryOnClicked);
            this.BookQryBtn.MouseLeave += new System.EventHandler(this.BookQryBtnLeave);
            // 
            // QryBtn
            // 
            this.QryBtn.Location = new System.Drawing.Point(772, 540);
            this.QryBtn.Name = "QryBtn";
            this.QryBtn.Size = new System.Drawing.Size(167, 79);
            this.QryBtn.TabIndex = 6;
            this.QryBtn.Text = "信息查询";
            this.QryBtn.UseVisualStyleBackColor = true;
            this.QryBtn.MouseEnter += new System.EventHandler(this.QryBtnEntered);
            // 
            // QuitBtn
            // 
            this.QuitBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.QuitBtn.Location = new System.Drawing.Point(1167, 591);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(80, 80);
            this.QuitBtn.TabIndex = 7;
            this.QuitBtn.Text = "退出";
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // IndexAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.QryBtn);
            this.Controls.Add(this.QryLayout);
            this.Controls.Add(this.UserMngBtn);
            this.Controls.Add(this.BookMngBtn);
            this.Controls.Add(this.CheckInOutBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IndexAdmin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IndexAdminClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.QryLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CheckInOutBtn;
        private System.Windows.Forms.Button BookMngBtn;
        private System.Windows.Forms.Button UserMngBtn;
        private System.Windows.Forms.TableLayoutPanel QryLayout;
        private System.Windows.Forms.Button BookQryBtn;
        private System.Windows.Forms.Button UserQryBtn;
        private System.Windows.Forms.Button RecordQryBtn;
        private System.Windows.Forms.Button QryBtn;
        private System.Windows.Forms.Button QuitBtn;
    }
}