using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace Client
    struct Report
    {
        public int Command;
        public string Id, P, P1, P2, ImgName;
        public ImageFormat Format;
        public byte[] Image;

        public Report(int com, string id, string p, string p1, string p2, ImageFormat format, string name, byte[] img)
        {
            Command = com;
            Id = id;
            P = p;
            P1 = p1;
            P2 = p2;
            ImgName = name;
            Image = img;
            Format = format;
        }
    }
  
    /// <summary> 
    /// Определяет методы для работы клиента 
    /// </summary> 
    class Client
    {
        private int id = -1;
        private HttpWebRequest req;
        private HttpWebResponse resp;

        public Client()
        {
            //Random rand = new Random(); 
            //id = rand.Next(1000); 
        }
        ~Client() { }

        /// <summary> 
        /// Создает запрос к серверу 
        /// </summary> 
        /// <param name="host">Адрес сервера</param> 
        public void Request(string host, string text)
        {
            try
            {
                req = (HttpWebRequest)HttpWebRequest.Create(host);//запрос 
                req.Method = "POST";

                byte[] dataArray = Encoding.UTF8.GetBytes(text);
                req.ContentType = "application/x-www-form-urlencoded";
                req.ContentLength = dataArray.Length;

                try
                {
                    using (Stream dataStream = req.GetRequestStream())
                    {
                        dataStream.Write(dataArray, 0, dataArray.Length);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary> 
        /// Возвращает ответ сервера 
        /// </summary> 
        public void Response(ref string answer)
        {
            try
            {
                resp = (HttpWebResponse)req.GetResponse();//ответ 
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }

            try
            {
                using (StreamReader stream = new StreamReader(
                resp.GetResponseStream(), Encoding.UTF8))
                {
                    answer = stream.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void SetId(int ID)
        {
            id = ID;
        }
    }
    public partial class Form1 : Form
    {
        public static string HOST = "http://localhost:8888/connection/", Id = null, answer;
        public static Client client = new Client();
        public static bool Disconnected = false;
        public MemoryStream ms;
        public static byte OpenMode;
        

        List<Image> images = new List<Image>();

        public Form1()
        {
            InitializeComponent();
        }

        public void SetImage(System.Drawing.Image image)
        {
            PictBox1.Image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TB_Message.Text != "")
                client.Request(HOST, JsonConvert.SerializeObject(new Report(1, Id, TB_Message.Text, "", "", null, "", null)));

            MessageBox.Show(client.Response());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client.Request(HOST, JsonConvert.SerializeObject(new Report(0, "", "", "", "", null, "", null)));
            Id = client.Response();
            TSSL_ID.Text = "Ваш ID: "+ Id;

            client.Request(HOST, JsonConvert.SerializeObject(new Report(5, Id, "", "", "", null, "", null)));

            try
            {
                if (JsonConvert.DeserializeObject<Report>(client.Response()).Id == Id)
                {
                    TSSL_Status.ForeColor = Color.Green;
                    TSSL_Status.Text = "Подключение к серверу: есть";
                }
            }
            catch
            {
                MessageBox.Show("Подключение к серверу отсутствует");
                Disconnected = true;
                TSSL_Status.ForeColor = Color.Red;
                TSSL_Status.Text = "Подключение к серверу: отсутствует";
            }

            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PictBox1.Image != null)
            {
                using (var ms = new MemoryStream())
                {
                    PictBox1.Image.Save(ms, PictBox1.Image.RawFormat);
                    client.Request(HOST, JsonConvert.SerializeObject(new Report(6, Id, "", "", "",
                         PictBox1.Image.RawFormat, "", ms.ToArray())));
                }

                MessageBox.Show(client.Response());
            }
            else
                MessageBox.Show("Изображение отсутствует");            
        }

        private void PictBox1_Click(object sender, EventArgs e)
        {
            OFD1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;";

            if (OFD1.ShowDialog() == DialogResult.OK)
            {
                PictBox1.Image = new Bitmap(OFD1.FileName);
            }
            else return;
        }

        private void B_GetFoto_Click(object sender, EventArgs e)
        {
            new SelectImage().Show();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {     
            if(Id == null)
            {
                client.Request(HOST, JsonConvert.SerializeObject(new Report(0, "", "", "", "", null, "", null)));
                Id = client.Response();
            }
            
            try
            {
                client.Request(HOST, JsonConvert.SerializeObject(new Report(5, Id, "", "", "", null, "", null)));

                if (JsonConvert.DeserializeObject<Report>(client.Response()).Id == Id)
                {
                    Disconnected = false;
                    TSSL_Status.ForeColor = Color.Green;
                    TSSL_Status.Text = "Подключение к серверу: есть";
                }
            }
            catch
            {
                Disconnected = true;
                TSSL_Status.ForeColor = Color.Red;
                TSSL_Status.Text = "Подключение к серверу: отсутствует";
            }
        }

        private void TSMI_GetReport_Click(object sender, EventArgs e)
        {
            OpenMode = 2;
            var RepForm = new ReportForm();
            RepForm.Show();
        }

        private void TB_Message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(this, e);
        }

        private void TSMI_SendReport_Click(object sender, EventArgs e)
        {
            OpenMode = 1;
            var RepForm = new ReportForm();
            RepForm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();

            if(!Disconnected)
                client.Request(HOST, JsonConvert.SerializeObject(new Report(4, Id, "", "", "", null, "", null)));
        }
    }    

    /// <summary> 
    /// Определяет методы для работы клиента 
    /// </summary> 
    public class Client
    {
        static private HttpWebRequest req;
        private HttpWebResponse resp;

        public Client(){}
        ~Client() { }

        /// <summary> 
        /// Создает запрос к серверу 
        /// </summary> 
        /// <param name="host">Адрес сервера</param> 
        public void Request(string host, string text)
        {
            try
            {
                req = (HttpWebRequest)HttpWebRequest.Create(host);//запрос 
                req.Method = "POST"; 

                byte[] dataArray = Encoding.UTF8.GetBytes(text);
                req.ContentType = "application/x-www-form-urlencoded";
                req.ContentLength = dataArray.Length;

                try
                {
                    using (Stream dataStream = req.GetRequestStream())
                    {
                        dataStream.Write(dataArray, 0, dataArray.Length);
                    }
                }
                catch
                {}

            }
            catch
            {}
        }

        /// <summary> 
        /// Возвращает ответ сервера 
        /// </summary> 
        public string Response()
        {
            try
            {
                resp = (HttpWebResponse)req.GetResponse();//ответ 
            }
            catch 
            {
                return null;
            }

            try
            {
                using (StreamReader stream = new StreamReader(
                resp.GetResponseStream(), Encoding.UTF8))
                {
                    return stream.ReadToEnd();
                }
            }
            catch
            {
                return null;
            }
        }
    }
      
}
