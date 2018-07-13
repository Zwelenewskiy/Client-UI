using System;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Client
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void Count(object obj)
        {
            Form1.client.Request(Form1.HOST, JsonConvert.SerializeObject(new Report(5, 
                Form1.Id, "", "", "")));

            if (JsonConvert.DeserializeObject<Report>(Form1.client.Response()).Id == Form1.Id)
            {
                //MessageBox.Show("Проверка успешно прошла");
                
            }              
               
        }
    }
}
