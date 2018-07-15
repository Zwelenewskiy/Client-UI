using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Drawing;
using System.Drawing.Imaging;

namespace Client
{
    static class Program
    {
        private static Form1 _mainForm;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _mainForm = new Form1();
            Application.Run(_mainForm);
        }

        public static void Check(object obj)
        {
            Form1.client.Request(Form1.HOST, JsonConvert.SerializeObject(new Report(5, 
                Form1.Id, "", "", "", null, "", null)));


            try
            {
                if (JsonConvert.DeserializeObject<Report>(Form1.client.Response()).Id == Form1.Id)
                {
                    _mainForm.SetTsslTextColor(Color.Green);
                    _mainForm.SetTsslText("Подключение к серверу: есть");                    
                }
            }
            catch
            {
                _mainForm.SetTsslTextColor(Color.Red);
                _mainForm.SetTsslText("Подключение к серверу: отсутсвует");
                Form1.Disconnected = true;
            }                    
        }

        public static Image ByteArrayToImage(byte[] img)
        {
            using (var ms = new MemoryStream(img))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }
    }
}
