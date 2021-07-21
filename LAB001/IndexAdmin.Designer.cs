
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
            this.checkinout = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BookCheckInOut = new System.Windows.Forms.ToolStripMenuItem();
            this.书刊管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新书上架ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.旧书下架ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改图书信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改用户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.事务管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借还信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.通用设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LAB001.Properties.Resources.pic1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(605, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(621, 439);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // checkinout
            // 
            this.checkinout.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkinout.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkinout.Location = new System.Drawing.Point(39, 96);
            this.checkinout.Name = "checkinout";
            this.checkinout.Size = new System.Drawing.Size(179, 79);
            this.checkinout.TabIndex = 2;
            this.checkinout.Text = "书刊借还";
            this.checkinout.UseVisualStyleBackColor = true;
            this.checkinout.Click += new System.EventHandler(this.BookCheckInOut_OnClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 596);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(512, 596);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(681, 596);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // BookCheckInOut
            // 
            this.BookCheckInOut.Name = "BookCheckInOut";
            this.BookCheckInOut.Size = new System.Drawing.Size(86, 61);
            this.BookCheckInOut.Text = "书刊借还";
            this.BookCheckInOut.Click += new System.EventHandler(this.BookCheckInOutClicked);
            // 
            // 书刊管理ToolStripMenuItem
            // 
            this.书刊管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新书上架ToolStripMenuItem,
            this.旧书下架ToolStripMenuItem,
            this.修改图书信息ToolStripMenuItem});
            this.书刊管理ToolStripMenuItem.Name = "书刊管理ToolStripMenuItem";
            this.书刊管理ToolStripMenuItem.Size = new System.Drawing.Size(86, 61);
            this.书刊管理ToolStripMenuItem.Text = "书刊管理";
            // 
            // 新书上架ToolStripMenuItem
            // 
            this.新书上架ToolStripMenuItem.Name = "新书上架ToolStripMenuItem";
            this.新书上架ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.新书上架ToolStripMenuItem.Text = "新书上架";
            // 
            // 旧书下架ToolStripMenuItem
            // 
            this.旧书下架ToolStripMenuItem.Name = "旧书下架ToolStripMenuItem";
            this.旧书下架ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.旧书下架ToolStripMenuItem.Text = "旧书下架";
            // 
            // 修改图书信息ToolStripMenuItem
            // 
            this.修改图书信息ToolStripMenuItem.Name = "修改图书信息ToolStripMenuItem";
            this.修改图书信息ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.修改图书信息ToolStripMenuItem.Text = "修改图书信息";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加用户ToolStripMenuItem,
            this.删除用户ToolStripMenuItem,
            this.修改用户信息ToolStripMenuItem});
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(86, 61);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // 添加用户ToolStripMenuItem
            // 
            this.添加用户ToolStripMenuItem.Name = "添加用户ToolStripMenuItem";
            this.添加用户ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.添加用户ToolStripMenuItem.Text = "添加用户";
            // 
            // 删除用户ToolStripMenuItem
            // 
            this.删除用户ToolStripMenuItem.Name = "删除用户ToolStripMenuItem";
            this.删除用户ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.删除用户ToolStripMenuItem.Text = "删除用户";
            // 
            // 修改用户信息ToolStripMenuItem
            // 
            this.修改用户信息ToolStripMenuItem.Name = "修改用户信息ToolStripMenuItem";
            this.修改用户信息ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.修改用户信息ToolStripMenuItem.Text = "修改用户信息";
            // 
            // 事务管理ToolStripMenuItem
            // 
            this.事务管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户信息ToolStripMenuItem,
            this.图书信息ToolStripMenuItem,
            this.借还信息ToolStripMenuItem});
            this.事务管理ToolStripMenuItem.Name = "事务管理ToolStripMenuItem";
            this.事务管理ToolStripMenuItem.Size = new System.Drawing.Size(86, 61);
            this.事务管理ToolStripMenuItem.Text = "信息查询";
            this.事务管理ToolStripMenuItem.Click += new System.EventHandler(this.事务管理ToolStripMenuItem_Click);
            // 
            // 用户信息ToolStripMenuItem
            // 
            this.用户信息ToolStripMenuItem.Name = "用户信息ToolStripMenuItem";
            this.用户信息ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.用户信息ToolStripMenuItem.Text = "用户信息";
            // 
            // 图书信息ToolStripMenuItem
            // 
            this.图书信息ToolStripMenuItem.Name = "图书信息ToolStripMenuItem";
            this.图书信息ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.图书信息ToolStripMenuItem.Text = "图书信息";
            // 
            // 借还信息ToolStripMenuItem
            // 
            this.借还信息ToolStripMenuItem.Name = "借还信息ToolStripMenuItem";
            this.借还信息ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.借还信息ToolStripMenuItem.Text = "借还信息";
            // 
            // 通用设置ToolStripMenuItem
            // 
            this.通用设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.通用设置ToolStripMenuItem.Name = "通用设置ToolStripMenuItem";
            this.通用设置ToolStripMenuItem.Size = new System.Drawing.Size(86, 61);
            this.通用设置ToolStripMenuItem.Text = "通用设置";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BookCheckInOut,
            this.书刊管理ToolStripMenuItem,
            this.用户管理ToolStripMenuItem,
            this.事务管理ToolStripMenuItem,
            this.通用设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 65);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // index_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkinout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "index_admin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.userindex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button checkinout;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem BookCheckInOut;
        private System.Windows.Forms.ToolStripMenuItem 书刊管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新书上架ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 旧书下架ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改图书信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改用户信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 事务管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借还信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 通用设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}