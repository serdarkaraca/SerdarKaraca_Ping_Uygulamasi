namespace Ping
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.list_Sonuc = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IpAdress = new System.Windows.Forms.TextBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "172.20.1.254",
            "172.20.1.56"});
            this.listBox1.Location = new System.Drawing.Point(43, 134);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 186);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 83);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ping Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // list_Sonuc
            // 
            this.list_Sonuc.FormattingEnabled = true;
            this.list_Sonuc.Location = new System.Drawing.Point(398, 134);
            this.list_Sonuc.Name = "list_Sonuc";
            this.list_Sonuc.Size = new System.Drawing.Size(159, 186);
            this.list_Sonuc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kontrol Edilecek İp Adres Listesi";
            // 
            // txt_IpAdress
            // 
            this.txt_IpAdress.Location = new System.Drawing.Point(43, 56);
            this.txt_IpAdress.Name = "txt_IpAdress";
            this.txt_IpAdress.Size = new System.Drawing.Size(100, 20);
            this.txt_IpAdress.TabIndex = 4;
            this.txt_IpAdress.Text = "İp Adresi Yazın";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(158, 54);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_Ekle.TabIndex = 5;
            this.btn_Ekle.Text = "Listeye Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ping Sonuçları";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 371);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.txt_IpAdress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_Sonuc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox list_Sonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IpAdress;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Label label2;
    }
}

