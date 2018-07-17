using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Client
{
    public partial class SelectImage : Form
    {
        public SelectImage()
        {
            InitializeComponent();
        }

        private void SelectImage_Load(object sender, EventArgs e)
        {
            Form1.client.Request(Form1.HOST, JsonConvert.SerializeObject(new Report(8, "", "", "", "",
                null, null, null)));
        }
    }
}
