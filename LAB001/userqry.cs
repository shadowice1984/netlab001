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
    public partial class UserQry : Form
    {
        // protected SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\lab\db.mdf;Integrated Security=True;Connect Timeout=30");
        protected SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\db.mdf';Integrated Security=True;Connect Timeout=30");
        protected SqlDataAdapter dataadepter;
        protected SqlCommandBuilder cmdbuilder;
        string sql_wholetab = "SELECT * FROM [dbo].[UserTab]";
        DataTable dt;

        public UserQry()
        {
            InitializeComponent();
        }
        IndexAdmin parent;
       public UserQry(IndexAdmin _parent)
        {
            parent = _parent;
            InitializeComponent();
        }

        private void UpdateDGV(string QryStr)
        {
            Console.WriteLine(QryStr);
            DataRow[] fRows;

            try
            {
                List<DataRow> RmIndex = new List<DataRow>();
                fRows = dt.Select(QryStr);

                foreach (DataRow SrcRows in dt.Rows)
                {
                    bool IsExist = false;
                    foreach (DataRow frow in fRows)
                    {
                        if (SrcRows == frow)
                        {
                            IsExist = true;
                        }
                    }
                    if (!IsExist)
                        RmIndex.Add(SrcRows);
                }

                foreach (DataRow rmrow in RmIndex)
                {
                    dt.Rows.Remove(rmrow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误：发生了未处理的数据库异常", "提示");
                Console.WriteLine(ex);
            }
        }

        private void AddFilter_Click(object sender, EventArgs e)
        {
            string QryStr;
            if (String.Equals(comboBox1.Text, "学号"))
            {
                if (textBox1.Text.Length > 15)
                { MessageBox.Show("学号过长"); return; }
                PreviewLabel.Text += "学号=" + textBox1.Text + ";";

                QryStr = "number = '" + textBox1.Text + "'";
                UpdateDGV(QryStr.ToString());
            }
            else if (String.Equals(comboBox1.Text, "姓名"))
            {
                if (textBox1.Text.Length > 15)
                { MessageBox.Show("姓名过长"); return; }
                PreviewLabel.Text += "姓名=" + textBox1.Text + ";";

                QryStr = "name = '" + textBox1.Text + "'";
                UpdateDGV(QryStr.ToString());
            }
            else if (String.Equals(comboBox1.Text, "注册日期"))
            {
                DateTime dtTime;
                if (DateTime.TryParse(textBox1.Text, out dtTime))
                {
                    PreviewLabel.Text += "注册日期=" + textBox1.Text + ";";
                }
                else
                {
                    MessageBox.Show("请输入合法日期");return;
                }

                QryStr = "regdate = '" + textBox1.Text + "'";
                UpdateDGV(QryStr.ToString());
            }
            else if (String.Equals(comboBox1.Text, "是否为管理员"))
            {
                if (String.Equals(textBox1.Text, "是"))
                {
                    PreviewLabel.Text += "为管理员;";

                    QryStr = "isadmin = True";
                }
                else if (String.Equals(textBox1.Text, "否"))
                {
                    PreviewLabel.Text += "不为管理员;";

                    QryStr = "isadmin = False";
                }
                else
                {
                    MessageBox.Show("请输入“是”或“否”");return;
                }

                UpdateDGV(QryStr.ToString());
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            dt.Clear();
            Con.Open();
            dataadepter.Fill(dt);
            Con.Close();
            PreviewLabel.Text = "";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserQryClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void UserQry_Load(object sender, EventArgs e)
        {
            dataadepter = new SqlDataAdapter(sql_wholetab, Con);
            cmdbuilder = new SqlCommandBuilder(dataadepter);
            dt = new DataTable();
            Con.Open();
            dataadepter.Fill(dt);
            Con.Close();

            bindingSource1.DataSource = dt;
            DGVmain.DataSource = bindingSource1;
            DGVmain.ReadOnly = true;

            Console.WriteLine("User Data Loaded.");
        }
    }
}
