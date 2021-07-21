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
    public partial class CheckInOut : Form
    {
        public IndexAdmin parent;
        public CheckInOut()
        {
            InitializeComponent();
        }

        public CheckInOut(IndexAdmin _parent)
        {
            InitializeComponent();
            parent = _parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkinout_Load(object sender, EventArgs e)
        {

        }


        private void BackbtnOnClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckInOutClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
    }
}
