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
    public partial class UserMng : Form
    {
        public UserMng()
        {
            InitializeComponent();
        }
        private IndexAdmin parent;
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

        }
    }
}
