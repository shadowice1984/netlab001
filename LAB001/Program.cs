using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LAB001
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\shadowice1984\\Source\\Repos\\LAB001\\db.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection Con=new SqlConnection(conStr);
            Con.Open();
            Console.WriteLine();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IndexAdmin());
            Con.Close();
        }
    }
}
