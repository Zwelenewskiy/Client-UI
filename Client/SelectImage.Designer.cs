namespace Client
{
    partial class SelectImage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PB_Preview = new System.Windows.Forms.PictureBox();
            this.DGV_Images = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Images)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Preview
            // 
            this.PB_Preview.Location = new System.Drawing.Point(12, 28);
            this.PB_Preview.Name = "PB_Preview";
            this.PB_Preview.Size = new System.Drawing.Size(367, 200);
            this.PB_Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Preview.TabIndex = 0;
            this.PB_Preview.TabStop = false;
            // 
            // DGV_Images
            // 
            this.DGV_Images.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_Images.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Images.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DGV_Images.Location = new System.Drawing.Point(12, 234);
            this.DGV_Images.Name = "DGV_Images";
            this.DGV_Images.ReadOnly = true;
            this.DGV_Images.Size = new System.Drawing.Size(367, 118);
            this.DGV_Images.TabIndex = 1;
            this.DGV_Images.Click += new System.EventHandler(this.DGV_Images_Click);
            this.DGV_Images.DoubleClick += new System.EventHandler(this.DGV_Images_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(138, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Предпросмотр";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 217;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Объем, Kб";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 90;
            // 
            // SelectImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Images);
            this.Controls.Add(this.PB_Preview);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(405, 400);
            this.MinimumSize = new System.Drawing.Size(405, 400);
            this.Name = "SelectImage";
            this.Text = "Загрузка изображения";
            this.Load += new System.EventHandler(this.SelectImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Images)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Preview;
        private System.Windows.Forms.DataGridView DGV_Images;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}