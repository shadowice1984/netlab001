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
    public partial class BookMng : Form
    {
        protected IndexAdmin parent;
        protected SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shadowice1984\Documents\newdb.mdf;Integrated Security=True;Connect Timeout=30");
        protected SqlDataAdapter dataadepter;
        protected SqlCommandBuilder cmdbuilder;
        string sql_wholetab = "SELECT * FROM [dbo].[BookTab]";
        DataTable dt;

        public BookMng()
        {
            InitializeComponent();
        }
        public BookMng(IndexAdmin _parent)
        {
            InitializeComponent();
            parent = _parent;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookMngClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void BookMng_Load(object sender, EventArgs e)
        {
            dataadepter = new SqlDataAdapter(sql_wholetab, Con);
            cmdbuilder = new SqlCommandBuilder(dataadepter);
            dt = new DataTable();
            Con.Open();
            dataadepter.Fill(dt);
            Con.Close();

            bindingSource1.DataSource = dt;
            DGVmain.DataSource = bindingSource1;
            // DGVmain.DataMember = "Test_BookTable";
            DGVmain.ReadOnly = true;

            MessageBox.Show("Data Loaded.", "Hint");
            // DGVmain.ReadOnly = false;
        }

        private void IsModify_Click(object sender, EventArgs e)
        {
            
            if (IsModify.Text.Equals("修改书刊数据"))
            {
                // Console.WriteLine("!!!");

                DGVmain.ReadOnly = false;
                IsModify.Text = "保存并退出修改";
            }
            else if (IsModify.Text.Equals("保存并退出修改")) 
            {
                // Console.WriteLine("123");

                DGVmain.ReadOnly = true;
                dataadepter.Update(bindingSource1.DataSource as DataTable);

                IsModify.Text = "修改书刊数据";
            }
        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("!!123");
            dt.RejectChanges();
            DGVmain.RefreshEdit();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dataadepter.Update(bindingSource1.DataSource as DataTable);
            }
            catch
            {
                MessageBox.Show("保存失败：存在不符合格式的数据，或必填项未填写", "错误");
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rows in DGVmain.SelectedRows)
            {
                DGVmain.Rows.RemoveAt(rows.Index);
            }
            DGVmain.RefreshEdit();
        }

        private void DGVDataErr(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("错误：输入数据不符合格式，或必填项未填写", "错误");
        }
    }
}
