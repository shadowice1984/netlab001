﻿using System;
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
        public IndexAdmin()
        {
            InitializeComponent();

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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private CheckInOut checkinout_window;
        private BookMng bookmng_window;

        private void BookMngBtnOnClicked(object sender, EventArgs e)
        {

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
    }
}
