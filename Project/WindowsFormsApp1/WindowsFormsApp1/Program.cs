using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.Resources;

namespace WindowsFormsApp1
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Menu());
           // DbCon obj = new DbCon();
            //obj.OpenConnection();
            //Console.ReadKey();
        }
    }
}
