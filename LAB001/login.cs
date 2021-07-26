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
        
        protected SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shadowice1984\Documents\newdb.mdf;Integrated Security=True;Connect Timeout=30");
        private IndexAdmin indexadmin_window;

        private void Login_Load(object sender, EventArgs e)
        {

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
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex);
            }
            Con.Close();

            indexadmin_window = new IndexAdmin(this);
            indexadmin_window.Show();
            this.Hide();
        }
    }
}
