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
    public partial class BookQry : Form
    {
        public BookQry()
        {
            InitializeComponent();
        }
        IndexAdmin parent;
        public BookQry(IndexAdmin _parent)
        {
            parent = _parent;
            InitializeComponent();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddBookFilter_Click(object sender, EventArgs e)
        {
            string qryStr;
            if (String.Equals(comboBox1.Text, "ISBN码"))
            {
                if (textBox1.Text.Length > 25)
                { MessageBox.Show("ISBN码过长"); return; }
                PreviewLabel.Text += "ISBN="+textBox1.Text+";";
                //Console.WriteLine(label1.Text);

            }
            else if (String.Equals(comboBox1.Text, "书名"))
            {
                if (textBox1.Text.Length > 50)
                { MessageBox.Show("书名过长"); return; }
                PreviewLabel.Text += "书名=" + textBox1.Text + ";";

            }
            else if (String.Equals(comboBox1.Text, "出版日期"))
            {
                DateTime dtTime;
                if (DateTime.TryParse(textBox1.Text, out dtTime))
                {
                    PreviewLabel.Text += "日期=" + textBox1.Text + ";";
                }
                else
                {
                    MessageBox.Show("请输入合法日期"); return;
                }
            }
            else if (String.Equals(comboBox1.Text, "出版社"))
            {
                if (textBox1.Text.Length > 15)
                { MessageBox.Show("出版社名过长"); return; }
                PreviewLabel.Text += "出版社=" + textBox1.Text + ";";
            }
            else if (String.Equals(comboBox1.Text, "在馆数目"))
            {
                PreviewLabel.Text += "在馆数目=" + textBox1.Text + ";";

            }
            else if (String.Equals(comboBox1.Text, "数目"))
            {
                PreviewLabel.Text += "数目=" + textBox1.Text + ";";
            }
            else if (String.Equals(comboBox1.Text, "作者"))
            {
                if (textBox1.Text.Length > 25)
                { MessageBox.Show("作者姓名过长"); return; }
                PreviewLabel.Text += "作者=" + textBox1.Text + ";";
            }
            else if (String.Equals(comboBox1.Text, "其他作者"))
            {
                if (textBox1.Text.Length > 50)
                { MessageBox.Show("其他作者姓名过长"); return; }
                PreviewLabel.Text += "其他作者=" + textBox1.Text + ";";
            }
            else if (String.Equals(comboBox1.Text, "图书代码"))
            {
                if (textBox1.Text.Length > 20)
                { MessageBox.Show("其他作者姓名过长"); return; }
                PreviewLabel.Text += "其他作者=" + textBox1.Text + ";";
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookQryClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void BookQryLoad(object sender, EventArgs e)
        {

        }
    }
}
