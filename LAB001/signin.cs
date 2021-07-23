using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LAB001
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shadowice1984\Source\Repos\LAB001\db.mdf;Integrated Security=True;Connect Timeout=30");
        private void signin_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if(name.Text=="")
            {
                MessageBox.Show("姓名不能为空！");
                return;
            }
            if(password.Text=="")
            {
                MessageBox.Show("密码不能为空！");
                return;
            }
            if(number.Text=="")
            {
                MessageBox.Show("账号不能为空！");
                return;
            }
            if(passwordConfirm.Text=="")
            {
                MessageBox.Show("请确认密码！");
                return;
            }
            {
                string a = password.Text;
                string b = passwordConfirm.Text;
                if (string.Equals(a, b) == false)
                {
                    MessageBox.Show("两次输入的密码不一致。");
                    return;
                }
            }

            string reg_date = DateTime.Now.ToShortDateString().ToString();
            Console.WriteLine(reg_date);
            Con.Open();
            string cmdStr;
            if (adminChk.Checked == true)
            {
                cmdStr = "INSERT INTO [dbo].[UserTab] ([number], [name], [password], [regdate], [isadmin], [isbanned]) VALUES (N'"+number.Text+"', N'"+name.Text+"', N'"+password.Text+"', N'"+reg_date+"', 1, 0)";
            }
            else 
            {
                cmdStr = "INSERT INTO [dbo].[UserTab] ([number], [name], [password], [regdate], [isadmin], [isbanned]) VALUES (N'" + number.Text + "', N'" + name.Text + "', N'" + password.Text + "', N'" + reg_date + "', 0, 0)";
            }
            SqlCommand cmd = new SqlCommand(cmdStr, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
        }
    }
}
