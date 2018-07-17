using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

struct Image
{
    public string name;
    public long size;
    public byte[] image;

    public Image(string n, long s, byte[] img)
    {
        name = n;
        size = s;
        image = img;
    }
}

struct Images
{
    public List<Image> images;
}

namespace Client
{
    public partial class SelectImage : Form
    {
        MemoryStream ms;
        Images ImagesArray;

        public SelectImage()
        {
            InitializeComponent();
        }

        private void SelectImage_Load(object sender, EventArgs e)
        {
            Form1.client.Request(Form1.HOST, JsonConvert.SerializeObject(new Report(7, Form1.Id, "", "", "",
                null, null, null)));

            ImagesArray = JsonConvert.DeserializeObject<Images>(Form1.client.Response());

            if(ImagesArray.images.Count == 0)
            {
                MessageBox.Show("Список изображений пуст");
                Close();
                return;
            }

            for(int i = 0; i < ImagesArray.images.Count; i++)
            {
                DGV_Images.Rows.Add(ImagesArray.images[i].name, ImagesArray.images[i].size);
            }

            ms = new MemoryStream(ImagesArray.images[0].image);
            PB_Preview.Image = System.Drawing.Image.FromStream(ms);
        }

        private void DGV_Images_Click(object sender, EventArgs e)
        {
            if(DGV_Images.Rows[DGV_Images.SelectedCells[0].RowIndex].Index < ImagesArray.images.Count)
            {
                try
                {
                    ms = new MemoryStream(ImagesArray.images[DGV_Images.Rows[DGV_Images.SelectedCells[0].RowIndex].Index].image);
                    PB_Preview.Image = System.Drawing.Image.FromStream(ms);
                }
                catch
                {
                    MessageBox.Show("Файл поврежден");
                    return;
                }
            }                      
        }

        private void DGV_Images_DoubleClick(object sender, EventArgs e)
        {
            if (DGV_Images.Rows[DGV_Images.SelectedCells[0].RowIndex].Index < ImagesArray.images.Count)
            {
                ms = new MemoryStream(ImagesArray.images[DGV_Images.Rows[DGV_Images.SelectedCells[0].RowIndex].Index].image);
                Program.F1.SetImage(System.Drawing.Image.FromStream(ms));
            }            
        }
    }
}
