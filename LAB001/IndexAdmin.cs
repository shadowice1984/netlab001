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

        private CheckInOut checkinout_window;
        private BookMng bookmng_window;
        private UserMng usermng_window;
        private BookQry bookqry_window;
        private UserQry userqry_window;
        private RecordQry recordqry_window;
        //private 


        private void BookMngBtnOnClicked(object sender, EventArgs e)
        {
            bookmng_window = new BookMng(this);
            bookmng_window.Show();
            this.Hide();
        }

        private void CheckInOutBtnOnClicked(object sender, EventArgs e)
        {
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
            
            bookqry_window = new BookQry(this);
            bookqry_window.Show();
            QryLayout.Visible = true;
            QryBtn.Visible = false;
            this.Hide();
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

        private void UserQryBtn_Click(object sender, EventArgs e)
        {
            userqry_window = new UserQry(this);
            userqry_window.Show();
            QryLayout.Visible = true;
            QryBtn.Visible = false;
            this.Hide();
        }

        private void RecordQryBtn_Click(object sender, EventArgs e)
        {
            recordqry_window = new RecordQry(this);
            recordqry_window.Show();
            QryLayout.Visible = true;
            QryBtn.Visible = false;
            this.Hide();
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
