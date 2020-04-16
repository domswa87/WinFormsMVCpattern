using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMVC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // TEN FRAGMENT KODU JUZ BYL
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //TWORZE 2 WIDOKI
            Form1 f1 = new Form1();
            Form2 f2 = new Form2();
          
            // TWORZE KONTROLER I DAJE MU DWA WIDOKI W KONSTRUKTORZE
            Controller controller = new Controller(f1, f2);
            controller.StartController();
        }
    }
}
