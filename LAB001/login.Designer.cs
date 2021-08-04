
namespace LAB001
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GotoReginster = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginSubmit
            // 
            this.LoginSubmit.BackColor = System.Drawing.Color.Transparent;
            this.LoginSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginSubmit.FlatAppearance.BorderSize = 0;
            this.LoginSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LoginSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LoginSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginSubmit.ForeColor = System.Drawing.Color.Transparent;
            this.LoginSubmit.Location = new System.Drawing.Point(137, 235);
            this.LoginSubmit.Name = "LoginSubmit";
            this.LoginSubmit.Size = new System.Drawing.Size(75, 23);
            this.LoginSubmit.TabIndex = 3;
            this.LoginSubmit.UseVisualStyleBackColor = false;
            this.LoginSubmit.Click += new System.EventHandler(this.LoginSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(137, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 101;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(153, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 102;
            this.label2.Text = "密码";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(254, 125);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(100, 21);
            this.UserName.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(254, 178);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 21);
            this.Password.TabIndex = 2;
            this.Password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(220, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 100;
            this.label3.Text = "登录";
            // 
            // GotoReginster
            // 
            this.GotoReginster.BackColor = System.Drawing.Color.Transparent;
            this.GotoReginster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GotoReginster.FlatAppearance.BorderSize = 0;
            this.GotoReginster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GotoReginster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GotoReginster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GotoReginster.ForeColor = System.Drawing.Color.Transparent;
            this.GotoReginster.Location = new System.Drawing.Point(279, 235);
            this.GotoReginster.Name = "GotoReginster";
            this.GotoReginster.Size = new System.Drawing.Size(75, 23);
            this.GotoReginster.TabIndex = 4;
            this.GotoReginster.UseVisualStyleBackColor = false;
            this.GotoReginster.Click += new System.EventHandler(this.GotoReginster_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(319, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 19);
            this.label4.TabIndex = 103;
            this.label4.Text = "简单注册后即可登录";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LAB001.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 321);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GotoReginster);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginSubmit);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GotoReginster;
        private System.Windows.Forms.Label label4;
    }
}