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
    public partial class BookQry : Form
    {
        protected SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\lab\db.mdf;Integrated Security=True;Connect Timeout=30");
        protected SqlDataAdapter dataadepter;
        protected SqlCommandBuilder cmdbuilder;
        string sql_wholetab = "SELECT * FROM [dbo].[BookTab]";
        DataTable dt;

        public BookQry()
        {
            InitializeComponent();
        }
        IndexAdmin parent;
        public BookQry(IndexAdmin _parent)
        {
            parent = _parent;
            InitializeComponent();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void AddBookFilter_Click(object sender, EventArgs e)
        {
            string QryStr;
            if (String.Equals(comboBox1.Text, "ISBN码"))
            {
                if (textBox1.Text.Length > 25)
                    { MessageBox.Show("ISBN码过长"); return; }
                PreviewLabel.Text += "ISBN="+textBox1.Text+";";

                QryStr = "ISBN = '" + textBox1.Text + "'";
                UpdateDGV(QryStr.ToString());
            }
            else if (String.Equals(comboBox1.Text, "书名"))
            {
                if (textBox1.Text.Length > 50)
                    { MessageBox.Show("书名过长"); return; }
                PreviewLabel.Text += "书名=" + textBox1.Text + ";";

                QryStr = "name = '" + textBox1.Text + "'";
                UpdateDGV(QryStr.ToString());
            }
            else if (String.Equals(comboBox1.Text, "出版日期"))
            {
                DateTime dtTime;
                if (DateTime.TryParse(textBox1.Text, out dtTime))
                {
                    PreviewLabel.Text += "出版日期=" + textBox1.Text + ";";
                }
                else
                {
                    MessageBox.Show("请输入合法日期"); return;
                }

                QryStr = "pressdate = '" + textBox1.Text + "'";
                UpdateDGV(QryStr.ToString());
            }
            else if (String.Equals(comboBox1.Text, "出版社"))
            {
                if (textBox1.Text.Length > 15)
                    { MessageBox.Show("出版社名过长"); return; }
                PreviewLabel.Text += "出版社=" + textBox1.Text + ";";

                QryStr = "press = '" + textBox1.Text + "'";
                UpdateDGV(QryStr.ToString());
            }
            else if (String.Equals(comboBox1.Text, "在馆数目"))
            {
                PreviewLabel.Text += "在馆数目=" + textBox1.Text + ";";

                QryStr = "countinlib = " + textBox1.Text;
                UpdateDGV(QryStr.ToString());
            }
            else if (String.Equals(comboBox1.Text, "数目"))
            {
                PreviewLabel.Text += "数目=" + textBox1.Text + ";";

                QryStr = "count = " + textBox1.Text;
                UpdateDGV(QryStr.ToString());
            }
            else if (String.Equals(comboBox1.Text, "作者"))
            {
                if (textBox1.Text.Length > 25)
                    { MessageBox.Show("作者姓名过长"); return; }
                PreviewLabel.Text += "作者=" + textBox1.Text + ";";

                QryStr = "author = '" + textBox1.Text + "'";
                UpdateDGV(QryStr.ToString());
            }
            else if (String.Equals(comboBox1.Text, "其他作者"))
            {
                if (textBox1.Text.Length > 50)
                    { MessageBox.Show("其他作者姓名过长"); return; }
                PreviewLabel.Text += "其他作者=" + textBox1.Text + ";";

                QryStr = "subauthor = '" + textBox1.Text + "'";
                UpdateDGV(QryStr.ToString());
            }
            else if (String.Equals(comboBox1.Text, "图书馆编码"))
            {
                if (textBox1.Text.Length > 20)
                    { MessageBox.Show("图书馆编码过长"); return; }
                PreviewLabel.Text += "图书馆编码=" + textBox1.Text + ";";

                QryStr = "libcode = '" + textBox1.Text + "'";
                UpdateDGV(QryStr.ToString());
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookQryClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void BookQryLoad(object sender, EventArgs e)
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

            Console.WriteLine("Book Data Loaded.");
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            dt.Clear();
            Con.Open();
            dataadepter.Fill(dt);
            Con.Close();
            PreviewLabel.Text = "";
        }
    }
}
