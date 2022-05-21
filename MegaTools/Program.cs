
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaTools
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (File.Exists(Application.UserAppDataPath + @"Name.megatool"))
            {
                Application.Run(new Form1());
            }
            else
            {
                Application.Run(new Logname());
            }
        }
    }
}
