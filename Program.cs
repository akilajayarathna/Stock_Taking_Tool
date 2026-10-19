using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Taking_Tool
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var login = new frm_Loging())
            {
                if (login.ShowDialog() != DialogResult.OK)
                    return;
            }
            cls_MainDb.Load();
            cls_DbCreate.Init();
                Application.Run(new frm_Stock_Taking_Tool());
        }
    }
}
