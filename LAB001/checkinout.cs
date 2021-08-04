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
    public partial class CheckInOut : Form
    {
        public IndexAdmin parent;
        // protected SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\lab\db.mdf;Integrated Security=True;Connect Timeout=30");
        protected SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Resources\db.mdf';Integrated Security=True;Connect Timeout=30");
        protected SqlDataAdapter dataadepter;
        protected SqlCommandBuilder cmdbuilder;
        string sql_wholetab = "SELECT * FROM [dbo].[CheckInOutTab]";
        DataTable dt;

        public CheckInOut()
        {
            InitializeComponent();
        }

        public CheckInOut(IndexAdmin _parent)
        {
            InitializeComponent();
            parent = _parent;
        }

        private void BackbtnOnClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckInOutClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void CheckInOut_Load(object sender, EventArgs e)
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

            Console.WriteLine("Book Data Loaded.");
            // DGVmain.ReadOnly = false;
        }

        private void SaveData()
        {
            try
            {
                dataadepter.Update(bindingSource1.DataSource as DataTable);
                MessageBox.Show("更改成功，数据已保存！", "成功");
            }
            catch
            {
                MessageBox.Show("保存失败：存在不符合格式的数据，或必填项未填写", "错误");
            }
        }

        private void ApprBtnClicked(object sender, EventArgs e)
        {
            if (DGVmain.SelectedRows.Count == 0)
            {
                MessageBox.Show("请在左侧选中一行!", "提示");
                return;
            }
            foreach (DataGridViewRow rows in DGVmain.SelectedRows)
            {
                DGVmain.Rows[rows.Index].Cells[5].Value = 1;
            }
            DGVmain.RefreshEdit();
            SaveData();
        }

        private void RejectBtnClicked(object sender, EventArgs e)
        {
            if (DGVmain.SelectedRows.Count == 0)
            {
                MessageBox.Show("请在左侧选中一行!", "提示");
                return;
            }
            foreach (DataGridViewRow rows in DGVmain.SelectedRows)
            {
                DGVmain.Rows[rows.Index].Cells[5].Value = -1;
            }
            DGVmain.RefreshEdit();
            SaveData();
        }
    }
}
