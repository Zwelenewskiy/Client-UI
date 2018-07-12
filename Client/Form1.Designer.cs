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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.B_SendMsg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.B_SendFoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 303);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 90);
            this.textBox1.TabIndex = 0;
            // 
            // B_SendMsg
            // 
            this.B_SendMsg.Location = new System.Drawing.Point(31, 408);
            this.B_SendMsg.Name = "B_SendMsg";
            this.B_SendMsg.Size = new System.Drawing.Size(107, 23);
            this.B_SendMsg.TabIndex = 1;
            this.B_SendMsg.Text = "Отправить текст";
            this.B_SendMsg.UseVisualStyleBackColor = true;
            this.B_SendMsg.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // B_SendFoto
            // 
            this.B_SendFoto.Location = new System.Drawing.Point(173, 408);
            this.B_SendFoto.Name = "B_SendFoto";
            this.B_SendFoto.Size = new System.Drawing.Size(107, 23);
            this.B_SendFoto.TabIndex = 3;
            this.B_SendFoto.Text = "Отправить фото";
            this.B_SendFoto.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 435);
            this.Controls.Add(this.B_SendFoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.B_SendMsg);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button B_SendMsg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button B_SendFoto;
    }
}

