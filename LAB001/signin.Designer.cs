
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文中宋", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(614, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 40);
            this.label1.TabIndex = 100;
            this.label1.Text = "注册";
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.BackColor = System.Drawing.Color.Transparent;
            this.nameLb.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLb.ForeColor = System.Drawing.Color.DimGray;
            this.nameLb.Location = new System.Drawing.Point(390, 126);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(108, 27);
            this.nameLb.TabIndex = 101;
            this.nameLb.Text = "真实姓名";
            // 
            // passwordLb
            // 
            this.passwordLb.AutoSize = true;
            this.passwordLb.BackColor = System.Drawing.Color.Transparent;
            this.passwordLb.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwordLb.ForeColor = System.Drawing.Color.DimGray;
            this.passwordLb.Location = new System.Drawing.Point(438, 349);
            this.passwordLb.Name = "passwordLb";
            this.passwordLb.Size = new System.Drawing.Size(60, 27);
            this.passwordLb.TabIndex = 103;
            this.passwordLb.Text = "密码";
            this.passwordLb.Click += new System.EventHandler(this.label3_Click);
            // 
            // passwordConfirmLb
            // 
            this.passwordConfirmLb.AutoSize = true;
            this.passwordConfirmLb.BackColor = System.Drawing.Color.Transparent;
            this.passwordConfirmLb.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwordConfirmLb.ForeColor = System.Drawing.Color.DimGray;
            this.passwordConfirmLb.Location = new System.Drawing.Point(390, 464);
            this.passwordConfirmLb.Name = "passwordConfirmLb";
            this.passwordConfirmLb.Size = new System.Drawing.Size(108, 27);
            this.passwordConfirmLb.TabIndex = 104;
            this.passwordConfirmLb.Text = "确认密码";
            this.passwordConfirmLb.Click += new System.EventHandler(this.label4_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.White;
            this.name.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(749, 128);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(141, 30);
            this.name.TabIndex = 1;
            // 
            // number
            // 
            this.number.BackColor = System.Drawing.Color.White;
            this.number.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.number.Location = new System.Drawing.Point(749, 237);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(141, 30);
            this.number.TabIndex = 2;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.White;
            this.password.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.Location = new System.Drawing.Point(749, 351);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(141, 30);
            this.password.TabIndex = 3;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // adminChk
            // 
            this.adminChk.AutoSize = true;
            this.adminChk.BackColor = System.Drawing.Color.Transparent;
            this.adminChk.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.adminChk.Location = new System.Drawing.Point(736, 590);
            this.adminChk.Name = "adminChk";
            this.adminChk.Size = new System.Drawing.Size(129, 27);
            this.adminChk.TabIndex = 5;
            this.adminChk.Text = "申请管理员";
            this.adminChk.UseVisualStyleBackColor = false;
            this.adminChk.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.Transparent;
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.ForeColor = System.Drawing.Color.Transparent;
            this.Submit.Location = new System.Drawing.Point(579, 580);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(122, 50);
            this.Submit.TabIndex = 6;
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // passwordConfirm
            // 
            this.passwordConfirm.BackColor = System.Drawing.Color.White;
            this.passwordConfirm.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwordConfirm.Location = new System.Drawing.Point(749, 466);
            this.passwordConfirm.Name = "passwordConfirm";
            this.passwordConfirm.Size = new System.Drawing.Size(141, 30);
            this.passwordConfirm.TabIndex = 4;
            this.passwordConfirm.UseSystemPasswordChar = true;
            // 
            // numberLb
            // 
            this.numberLb.AutoSize = true;
            this.numberLb.BackColor = System.Drawing.Color.Transparent;
            this.numberLb.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numberLb.ForeColor = System.Drawing.Color.DimGray;
            this.numberLb.Location = new System.Drawing.Point(400, 235);
            this.numberLb.Name = "numberLb";
            this.numberLb.Size = new System.Drawing.Size(98, 27);
            this.numberLb.TabIndex = 102;
            this.numberLb.Text = "学/工号";
            this.numberLb.Click += new System.EventHandler(this.label5_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LAB001.Properties.Resources.signin;
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
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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