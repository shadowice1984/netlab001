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
        string sql_wholetab = "SELECT * FROM [dbo].[BookTab]";

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
            DataSet ds = new DataSet();
            Con.Open();
            dataadepter.Fill(ds, "Test_BookTable");
            Con.Close();
            DGVmain.DataSource = ds;
            DGVmain.DataMember = "Test_BookTable";

            MessageBox.Show("Data Loaded.", "Hint");
        }
    }
}
