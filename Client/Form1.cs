using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Client
{
    struct Report
    {
        public int Command;
        public string Id, P, P1, P2;

        public Report(int com, string id, string p, string p1, string p2)
        {
            Command = com;
            Id = id;
            P = p;
            P1 = p1;
            P2 = p2;
        }
    }

    public partial class Form1 : Form
    {
        public static string HOST = "http://localhost:8888/connection/";
        public static string Id = null, answer;
        public static Client client = new Client();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TB_Message.Text != "")
                client.Request(HOST, JsonConvert.SerializeObject(new Report(1, Id, TB_Message.Text, "", "")));

            MessageBox.Show(client.Response());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client.Request(HOST, JsonConvert.SerializeObject(new Report(0, "", "", "", "")));
            Id = client.Response();
            client.SetId(Convert.ToInt32(Id));

            TSSL_ID.Text = "Ваш ID: "+ Id;
        }

        private void TSMI_SendReport_Click(object sender, EventArgs e)
        {
            var RepForm = new ReportForm();
            RepForm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Request(HOST, JsonConvert.SerializeObject(new Report(4, Id, "", "", "")));
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
