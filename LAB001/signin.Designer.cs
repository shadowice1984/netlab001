
namespace LAB001
{
    partial class SignIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameLb = new System.Windows.Forms.Label();
            this.passwordLb = new System.Windows.Forms.Label();
            this.passwordConfirmLb = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.adminChk = new System.Windows.Forms.CheckBox();
            this.Submit = new System.Windows.Forms.Button();
            this.passwordConfirm = new System.Windows.Forms.TextBox();
            this.numberLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 100;
            this.label1.Text = "注册";
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Location = new System.Drawing.Point(206, 129);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(53, 12);
            this.nameLb.TabIndex = 101;
            this.nameLb.Text = "真实姓名";
            // 
            // passwordLb
            // 
            this.passwordLb.AutoSize = true;
            this.passwordLb.Location = new System.Drawing.Point(206, 260);
            this.passwordLb.Name = "passwordLb";
            this.passwordLb.Size = new System.Drawing.Size(29, 12);
            this.passwordLb.TabIndex = 103;
            this.passwordLb.Text = "密码";
            this.passwordLb.Click += new System.EventHandler(this.label3_Click);
            // 
            // passwordConfirmLb
            // 
            this.passwordConfirmLb.AutoSize = true;
            this.passwordConfirmLb.Location = new System.Drawing.Point(206, 330);
            this.passwordConfirmLb.Name = "passwordConfirmLb";
            this.passwordConfirmLb.Size = new System.Drawing.Size(53, 12);
            this.passwordConfirmLb.TabIndex = 104;
            this.passwordConfirmLb.Text = "确认密码";
            this.passwordConfirmLb.Click += new System.EventHandler(this.label4_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(808, 126);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 21);
            this.name.TabIndex = 1;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(808, 191);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 21);
            this.number.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(808, 257);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 21);
            this.password.TabIndex = 3;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // adminChk
            // 
            this.adminChk.AutoSize = true;
            this.adminChk.Location = new System.Drawing.Point(659, 594);
            this.adminChk.Name = "adminChk";
            this.adminChk.Size = new System.Drawing.Size(84, 16);
            this.adminChk.TabIndex = 5;
            this.adminChk.Text = "申请管理员";
            this.adminChk.UseVisualStyleBackColor = true;
            this.adminChk.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(511, 590);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "注册";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // passwordConfirm
            // 
            this.passwordConfirm.Location = new System.Drawing.Point(808, 327);
            this.passwordConfirm.Name = "passwordConfirm";
            this.passwordConfirm.Size = new System.Drawing.Size(100, 21);
            this.passwordConfirm.TabIndex = 4;
            this.passwordConfirm.UseSystemPasswordChar = true;
            // 
            // numberLb
            // 
            this.numberLb.AutoSize = true;
            this.numberLb.Location = new System.Drawing.Point(206, 194);
            this.numberLb.Name = "numberLb";
            this.numberLb.Size = new System.Drawing.Size(47, 12);
            this.numberLb.TabIndex = 102;
            this.numberLb.Text = "学/工号";
            this.numberLb.Click += new System.EventHandler(this.label5_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.numberLb);
            this.Controls.Add(this.passwordConfirm);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.adminChk);
            this.Controls.Add(this.password);
            this.Controls.Add(this.number);
            this.Controls.Add(this.name);
            this.Controls.Add(this.passwordConfirmLb);
            this.Controls.Add(this.passwordLb);
            this.Controls.Add(this.nameLb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.Load += new System.EventHandler(this.signin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLb;
        private System.Windows.Forms.Label passwordLb;
        private System.Windows.Forms.Label passwordConfirmLb;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.CheckBox adminChk;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox passwordConfirm;
        private System.Windows.Forms.Label numberLb;
    }
}