namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TB_Message = new System.Windows.Forms.TextBox();
            this.B_SendMessage = new System.Windows.Forms.Button();
            this.PictBox1 = new System.Windows.Forms.PictureBox();
            this.B_SendFoto = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSL_ID = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSL_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_SendReport = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_GetReport = new System.Windows.Forms.ToolStripMenuItem();
            this.OFD1 = new System.Windows.Forms.OpenFileDialog();
            this.B_GetFoto = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Message
            // 
            this.TB_Message.Location = new System.Drawing.Point(12, 303);
            this.TB_Message.Multiline = true;
            this.TB_Message.Name = "TB_Message";
            this.TB_Message.Size = new System.Drawing.Size(285, 90);
            this.TB_Message.TabIndex = 0;
            // 
            // B_SendMessage
            // 
            this.B_SendMessage.Location = new System.Drawing.Point(31, 408);
            this.B_SendMessage.Name = "B_SendMessage";
            this.B_SendMessage.Size = new System.Drawing.Size(107, 23);
            this.B_SendMessage.TabIndex = 1;
            this.B_SendMessage.Text = "Отправить текст";
            this.B_SendMessage.UseVisualStyleBackColor = true;
            this.B_SendMessage.Click += new System.EventHandler(this.button1_Click);
            // 
            // PictBox1
            // 
            this.PictBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PictBox1.Location = new System.Drawing.Point(12, 12);
            this.PictBox1.Name = "PictBox1";
            this.PictBox1.Size = new System.Drawing.Size(285, 285);
            this.PictBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictBox1.TabIndex = 2;
            this.PictBox1.TabStop = false;
            this.PictBox1.Click += new System.EventHandler(this.PictBox1_Click);
            // 
            // B_SendFoto
            // 
            this.B_SendFoto.Location = new System.Drawing.Point(173, 408);
            this.B_SendFoto.Name = "B_SendFoto";
            this.B_SendFoto.Size = new System.Drawing.Size(107, 23);
            this.B_SendFoto.TabIndex = 3;
            this.B_SendFoto.Text = "Отправить фото";
            this.B_SendFoto.UseVisualStyleBackColor = true;
            this.B_SendFoto.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSL_ID,
            this.TSSL_Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 465);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(309, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSSL_ID
            // 
            this.TSSL_ID.Name = "TSSL_ID";
            this.TSSL_ID.Size = new System.Drawing.Size(48, 17);
            this.TSSL_ID.Text = "Ваш ID:";
            // 
            // TSSL_Status
            // 
            this.TSSL_Status.Name = "TSSL_Status";
            this.TSSL_Status.Size = new System.Drawing.Size(147, 17);
            this.TSSL_Status.Text = "Подключение к серверу: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(309, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_SendReport,
            this.TSMI_GetReport});
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчетToolStripMenuItem.Text = "Отчет";
            // 
            // TSMI_SendReport
            // 
            this.TSMI_SendReport.Name = "TSMI_SendReport";
            this.TSMI_SendReport.Size = new System.Drawing.Size(180, 22);
            this.TSMI_SendReport.Text = "Отправить";
            this.TSMI_SendReport.Click += new System.EventHandler(this.TSMI_SendReport_Click);
            // 
            // TSMI_GetReport
            // 
            this.TSMI_GetReport.Name = "TSMI_GetReport";
            this.TSMI_GetReport.Size = new System.Drawing.Size(180, 22);
            this.TSMI_GetReport.Text = "Получить";
            this.TSMI_GetReport.Click += new System.EventHandler(this.TSMI_GetReport_Click);
            // 
            // OFD1
            // 
            this.OFD1.FileName = "openFileDialog1";
            // 
            // B_GetFoto
            // 
            this.B_GetFoto.Location = new System.Drawing.Point(82, 438);
            this.B_GetFoto.Name = "B_GetFoto";
            this.B_GetFoto.Size = new System.Drawing.Size(151, 23);
            this.B_GetFoto.TabIndex = 6;
            this.B_GetFoto.Text = "Получить последнее фото";
            this.B_GetFoto.UseVisualStyleBackColor = true;
            this.B_GetFoto.Click += new System.EventHandler(this.B_GetFoto_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 487);
            this.Controls.Add(this.B_GetFoto);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.B_SendFoto);
            this.Controls.Add(this.PictBox1);
            this.Controls.Add(this.B_SendMessage);
            this.Controls.Add(this.TB_Message);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(325, 525);
            this.MinimumSize = new System.Drawing.Size(325, 525);
            this.Name = "Form1";
            this.Text = "Клиент пользователя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Message;
        private System.Windows.Forms.Button B_SendMessage;
        private System.Windows.Forms.PictureBox PictBox1;
        private System.Windows.Forms.Button B_SendFoto;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_ID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SendReport;
        private System.Windows.Forms.ToolStripMenuItem TSMI_GetReport;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_Status;
        private System.Windows.Forms.OpenFileDialog OFD1;
        private System.Windows.Forms.Button B_GetFoto;
        private System.Windows.Forms.Timer timer1;
    }
}

