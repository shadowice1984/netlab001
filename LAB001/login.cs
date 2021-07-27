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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // protected SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\lab\db.mdf;Integrated Security=True;Connect Timeout=30");
        protected SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\db.mdf';Integrated Security=True;Connect Timeout=30");
        private IndexAdmin indexadmin_window;

        private void Login_Load(object sender, EventArgs e)
        {
            // Console.WriteLine("|DataDirectory|");
        }

        private void GotoReginster_Click(object sender, EventArgs e)
        {
            SignIn signin_window = new SignIn();
            signin_window.ShowDialog();
        }

        private void LoginSubmit_Click(object sender, EventArgs e)
        {
            if(UserName.Text=="")
            {
                MessageBox.Show("请输入学号！");return;
            }
            if(Password.Text=="")
            {
                MessageBox.Show("请输入密码！");return;
            }
            try
            {
                string cmdStr = "SELECT * FROM [dbo].[UserTab] WHERE number=N'" + UserName.Text + "' AND password=N'" + Password.Text + "'";
                Con.Open();
                SqlCommand cmd = new SqlCommand(cmdStr, Con);
                SqlDataReader dr = cmd.ExecuteReader();
                // Console.WriteLine("**!!!!" + dr.Read());
                if (dr.Read() == false)
                {    
                    MessageBox.Show("学号或密码错误！");
                    Con.Close();
                    return;
                }

                indexadmin_window = new IndexAdmin(this);
                indexadmin_window.Show();
                this.Hide();
            }
            catch (SqlException ex)
            {
                bool InvalidTableFlag = false;
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    if (ex.Errors[i].Number == 2706 || ex.Errors[i].Number == 2702)
                        InvalidTableFlag = true;
                }
                if (InvalidTableFlag)
                    MessageBox.Show("数据库或表格文件错误：不存在或已损坏。");
                else
                    MessageBox.Show("未处理的 SQL 异常：" + ex, "提示", MessageBoxButtons.OK);
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("未辨明的异常：" + ex);
            }
            Con.Close();
        }
    }
}
