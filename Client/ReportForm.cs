using System;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Client
{
    struct NewReport
    {
        public int Command;
        public string Id, P, P1, P2;

        public NewReport(int com, string id, string p, string p1, string p2)
        {
            Command = com;
            Id = id;
            P = p;
            P1 = p1;
            P2 = p2;
        }
    }

    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            if(Form1.OpenMode == 1)
                B_Report.Text = "Отправить";
            else if(Form1.OpenMode == 2)
                B_Report.Text = "Получить";
        }

        private void B_Report_Click(object sender, EventArgs e)
        {
            if (Form1.OpenMode == 1)
            {
                Form1.client.Request(Form1.HOST, JsonConvert.SerializeObject(new Report(2, Form1.Id,
                TB_P.Text, TB_P1.Text, TB_P2.Text, null, "", null)));

                MessageBox.Show(Form1.client.Response());
            }
            else if (Form1.OpenMode == 2)
            {
                Form1.client.Request(Form1.HOST, JsonConvert.SerializeObject(new Report(3, Form1.Id, "", "", "", null, "", null)));

                Report NewReport = JsonConvert.DeserializeObject<Report>(Form1.client.Response());
                TB_P.Text = NewReport.P;
                TB_P1.Text = NewReport.P1;
                TB_P2.Text = NewReport.P2;
            }

        }
    }
}
