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
    public partial class RecordQry : Form
    {
        public RecordQry()
        {
            InitializeComponent();
        }

        private void AddRecFilter_Click(object sender, EventArgs e)
        {
            string qryStr;
            if (String.Equals(comboBox1.Text, "学生学号"))
            {
                if (textBox1.Text.Length > 15)
                { MessageBox.Show("学号过长"); return; }

            }
            else if (String.Equals(comboBox1.Text, "图书ISBN码"))
            {
                if (textBox1.Text.Length > 20)
                { MessageBox.Show("ISBN过长"); return; }

            }
            else if (String.Equals(comboBox1.Text, "事件日期"))
            {
                DateTime dtTime;
                if (DateTime.TryParse(textBox1.Text, out dtTime))
                {

                }
                else
                {
                    MessageBox.Show("请输入合法日期"); return;
                }
            }
            else if (String.Equals(comboBox1.Text, "事件类型"))
            {
                if (String.Equals(textBox1.Text, "借书"))
                {

                }
                else if (String.Equals(textBox1.Text, "还书"))
                {

                }
                else if (String.Equals(textBox1.Text, "续借"))
                {

                }
                else
                {
                    MessageBox.Show("事件类型必须为“借书”，“还书”，“续借”三者之一");
                    return;
                }
            }
        }
    }
}
