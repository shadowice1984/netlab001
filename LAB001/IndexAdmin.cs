using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB001
{
    public partial class IndexAdmin : Form
    {
        protected Login parent;

        public IndexAdmin()
        {
            InitializeComponent();

        }

        public IndexAdmin(Login _parent)
        {
            InitializeComponent();
            parent = _parent;
        }

        private void BookCheckInOutClicked(object sender, EventArgs e)
        {

        }

        private void userindex_Load(object sender, EventArgs e)
        {

        }

        private void 事务管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private CheckInOut checkinout_window;
        private BookMng bookmng_window;
        private UserMng usermng_window;
        //private 


        private void BookMngBtnOnClicked(object sender, EventArgs e)
        {
            bookmng_window = new BookMng(this);
            bookmng_window.Show();
            this.Hide();
        }

        private void CheckInOutBtnOnClicked(object sender, EventArgs e)
        {
            /*Console.WriteLine(checkinout_window);
            if (checkinout_window == null)
            {
                Console.WriteLine("Clicked");
                //checkinout_window.
            }
            else
            {
                checkinout_window.Show();
            }*/

            checkinout_window = new CheckInOut(this);
            checkinout_window.Show();
            this.Hide();
        }

        private void UserMngBtnOnClicked(object sender, EventArgs e)
        {
            usermng_window = new UserMng(this);
            usermng_window.Show();
            this.Hide();
        }

        private void QryBtnEntered(object sender, EventArgs e)
        {
            QryLayout.Visible = true;
            QryBtn.Visible = false;
        }

        private void BookQryOnClicked(object sender, EventArgs e)
        {
            QryLayout.Visible = false;
            QryBtn.Visible = true;
        }

        private void QryLayerLeave(object sender, EventArgs e)
        {
            QryLayout.Visible = false;
            QryBtn.Visible = true;
        }

        private void BookQryBtnLeave(object sender, EventArgs e)
        {
            QryLayout.Visible = false;
            QryBtn.Visible = true;
        }

        private void UserQryBtnLeave(object sender, EventArgs e)
        {
            QryLayout.Visible = false;
            QryBtn.Visible = true;
        }

        private void RecordQryBtnLeave(object sender, EventArgs e)
        {
            QryLayout.Visible = false;
            QryBtn.Visible = true;
        }

        private void IndexAdminClosing(object sender, FormClosingEventArgs e) => parent.Close();
    }
}
