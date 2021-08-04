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
    public partial class UserMng : Form
    {
        protected IndexAdmin parent;
        // protected SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\lab\db.mdf;Integrated Security=True;Connect Timeout=30");
        protected SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\db.mdf';Integrated Security=True;Connect Timeout=30");
        protected SqlDataAdapter dataadepter;
        protected SqlCommandBuilder cmdbuilder;
        string sql_wholetab = "SELECT * FROM [dbo].[UserTab]";
        DataTable dt;

        public UserMng()
        {
            InitializeComponent();
        }
        public UserMng(IndexAdmin _parent)
        {
            parent = _parent;
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserMngClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void UserMng_Load(object sender, EventArgs e)
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

            Console.WriteLine("User Data Loaded.");
            // DGVmain.ReadOnly = false;
        }

        private void IsModify_Click(object sender, EventArgs e)
        {
            if (IsModify.Text.Equals("修改数据"))
            {
                // Console.WriteLine("!!!");

                DGVmain.ReadOnly = false;
                UndoBtn.Enabled = true;
                SaveBtn.Enabled = true;
                DelBtn.Enabled = true;
                IsModify.Text = "退出修改";
            }
            else if (IsModify.Text.Equals("退出修改"))
            {
                // Console.WriteLine("123");

                DGVmain.ReadOnly = true;
                UndoBtn.Enabled = false;
                SaveBtn.Enabled = false;
                DelBtn.Enabled = false;
                dataadepter.Update(bindingSource1.DataSource as DataTable);

                IsModify.Text = "修改数据";
            }
        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("!!123");
            dt.RejectChanges();
            DGVmain.RefreshEdit();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (DGVmain.SelectedRows.Count == 0)
            {
                MessageBox.Show("请在左侧选中一行!", "提示");
                return;
            }
            foreach (DataGridViewRow rows in DGVmain.SelectedRows)
            {
                DGVmain.Rows.RemoveAt(rows.Index);
            }
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

        private void DGVDateError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("错误：输入数据不符合格式，或必填项未填写", "错误");
        }
    }
}
