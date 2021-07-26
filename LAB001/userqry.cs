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
    public partial class UserQry : Form
    {
        public UserQry()
        {
            InitializeComponent();
        }
        IndexAdmin parent;
       public UserQry(IndexAdmin _parent)
        {
            parent = _parent;
            InitializeComponent();


        }
        private void AddFilter_Click(object sender, EventArgs e)
        {
            string qryStr;
            if (String.Equals(comboBox1.Text, "学号"))
            {
                if (textBox1.Text.Length > 15)
                { MessageBox.Show("学号过长"); return; }
                label1.Text += "学号=" + textBox1.Text + ";";

            }
            else if (String.Equals(comboBox1.Text, "姓名"))
            {
                if (textBox1.Text.Length > 15)
                { MessageBox.Show("姓名过长"); return; }
                label1.Text += "姓名=" + textBox1.Text + ";";
            }
            else if (String.Equals(comboBox1.Text, "注册日期"))
            {
                DateTime dtTime;
                if (DateTime.TryParse(textBox1.Text, out dtTime))
                {
                    label1.Text += "注册日期=" + textBox1.Text + ";";
                }
                else
                {
                    MessageBox.Show("请输入合法日期");return;
                }
            }
            else if (String.Equals(comboBox1.Text, "是否为管理员"))
            {
                if (String.Equals(textBox1.Text, "是"))
                {
                    label1.Text += "为管理员;";
                }
                else if (String.Equals(textBox1.Text, "否"))
                {
                    label1.Text += "不为管理员;";
                }
                else
                {
                    MessageBox.Show("请输入“是”或“否”");return;
                }
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {

        }
    }
}
