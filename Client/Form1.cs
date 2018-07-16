using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading;
using System.Linq;

namespace Client
{
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
       

    public partial class Form1 : Form
    {
        public static string HOST = "http://localhost:8888/connection/", Id = null, answer;
        public static Client client = new Client();
        public string ImgNameTmp = null;
        public static bool Disconnected = false;
        public MemoryStream ms;
                    
        public Form1()
        {
            InitializeComponent();
        }

        public void SetTsslText(string text)
        {
            TSSL_Status.Text = text;
        }

        public void SetTsslTextColor(Color Color)
        {
            TSSL_Status.ForeColor = Color;
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
            client.SetId(Convert.ToInt32(Id));
            TSSL_ID.Text = "Ваш ID: "+ Id;

            var timer = new System.Threading.Timer(new TimerCallback(Program.Check), null, 0, 5000);            
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

                ImgNameTmp = OFD1.FileName;
            }
            else return;
        }

        private void B_GetFoto_Click(object sender, EventArgs e)
        {
            client.Request(HOST, JsonConvert.SerializeObject(new Report(7, Id, "", "", "", null, "", null)));

            ms = new MemoryStream(JsonConvert.DeserializeObject<Report>(client.Response()).Image);
            PictBox1.Image = Image.FromStream(ms);
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            PictBox1.Image = null;
        }

        private void TSMI_SendReport_Click(object sender, EventArgs e)
        {
            var RepForm = new ReportForm();
            RepForm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!Disconnected)
                client.Request(HOST, JsonConvert.SerializeObject(new Report(4, Id, "", "", "", null, "", null)));
        }
    }    

    /// <summary> 
    /// Определяет методы для работы клиента 
    /// </summary> 
    public class Client
    {
        private int id = -1;
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
        public string Response()
        {
            try
            {
                resp = (HttpWebResponse)req.GetResponse();//ответ 
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public void SetId(int ID)
        {
            id = ID;
        }
    }
      
}
