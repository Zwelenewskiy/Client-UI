namespace Client
{
    partial class ReportForm
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
            this.TB_P = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_P2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_P1 = new System.Windows.Forms.TextBox();
            this.B_SendRerort = new System.Windows.Forms.Button();
            this.B_GetLastReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_P
            // 
            this.TB_P.Location = new System.Drawing.Point(141, 15);
            this.TB_P.Name = "TB_P";
            this.TB_P.Size = new System.Drawing.Size(72, 20);
            this.TB_P.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1-й параметр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "3-й параметр";
            // 
            // TB_P2
            // 
            this.TB_P2.Location = new System.Drawing.Point(141, 67);
            this.TB_P2.Name = "TB_P2";
            this.TB_P2.Size = new System.Drawing.Size(72, 20);
            this.TB_P2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "2-й параметр";
            // 
            // TB_P1
            // 
            this.TB_P1.Location = new System.Drawing.Point(141, 41);
            this.TB_P1.Name = "TB_P1";
            this.TB_P1.Size = new System.Drawing.Size(72, 20);
            this.TB_P1.TabIndex = 4;
            // 
            // B_SendRerort
            // 
            this.B_SendRerort.Location = new System.Drawing.Point(44, 117);
            this.B_SendRerort.Name = "B_SendRerort";
            this.B_SendRerort.Size = new System.Drawing.Size(75, 23);
            this.B_SendRerort.TabIndex = 6;
            this.B_SendRerort.Text = "Отправить";
            this.B_SendRerort.UseVisualStyleBackColor = true;
            this.B_SendRerort.Click += new System.EventHandler(this.B_SendRerort_Click);
            // 
            // B_GetLastReport
            // 
            this.B_GetLastReport.Location = new System.Drawing.Point(159, 117);
            this.B_GetLastReport.Name = "B_GetLastReport";
            this.B_GetLastReport.Size = new System.Drawing.Size(75, 23);
            this.B_GetLastReport.TabIndex = 7;
            this.B_GetLastReport.Text = "Получитть";
            this.B_GetLastReport.UseVisualStyleBackColor = true;
            this.B_GetLastReport.Click += new System.EventHandler(this.B_GetLastReport_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 152);
            this.Controls.Add(this.B_GetLastReport);
            this.Controls.Add(this.B_SendRerort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_P1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_P2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_P);
            this.Name = "ReportForm";
            this.Text = "Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_P;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_P2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_P1;
        private System.Windows.Forms.Button B_SendRerort;
        private System.Windows.Forms.Button B_GetLastReport;
    }
}