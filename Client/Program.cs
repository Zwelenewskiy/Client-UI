using System;
using System.Windows.Forms;

namespace Client
{
    static class Program
    {
        public static Form1 F1;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            F1 = new Form1();
            Application.Run(F1);
        }
    }
}
