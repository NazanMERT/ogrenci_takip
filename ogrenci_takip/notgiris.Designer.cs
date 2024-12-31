namespace ogrenci_takip
{
    partial class notgiris
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
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ogrnotxt = new TextBox();
            derstxt = new TextBox();
            vizetxt = new TextBox();
            finaltxt = new TextBox();
            orttxt = new TextBox();
            sonuctxt = new TextBox();
            eklebtn = new Button();
            degisbtn = new Button();
            anasayfabtn = new Button();
            cikisbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 67);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 113);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Ders Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 159);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 4;
            label5.Text = "Vize Notu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 205);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 5;
            label6.Text = "Final Notu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(82, 251);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 6;
            label7.Text = "Ortalama";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(82, 297);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 7;
            label8.Text = "Sonuç";
            // 
            // ogrnotxt
            // 
            ogrnotxt.Location = new Point(182, 59);
            ogrnotxt.Name = "ogrnotxt";
            ogrnotxt.Size = new Size(137, 23);
            ogrnotxt.TabIndex = 8;
            // 
            // derstxt
            // 
            derstxt.Location = new Point(182, 105);
            derstxt.Name = "derstxt";
            derstxt.Size = new Size(137, 23);
            derstxt.TabIndex = 11;
            // 
            // vizetxt
            // 
            vizetxt.Location = new Point(182, 151);
            vizetxt.Name = "vizetxt";
            vizetxt.Size = new Size(137, 23);
            vizetxt.TabIndex = 12;
            // 
            // finaltxt
            // 
            finaltxt.Location = new Point(182, 197);
            finaltxt.Name = "finaltxt";
            finaltxt.Size = new Size(137, 23);
            finaltxt.TabIndex = 13;
            // 
            // orttxt
            // 
            orttxt.Location = new Point(182, 243);
            orttxt.Name = "orttxt";
            orttxt.Size = new Size(137, 23);
            orttxt.TabIndex = 14;
            // 
            // sonuctxt
            // 
            sonuctxt.Location = new Point(182, 289);
            sonuctxt.Name = "sonuctxt";
            sonuctxt.Size = new Size(137, 23);
            sonuctxt.TabIndex = 15;
            // 
            // eklebtn
            // 
            eklebtn.Location = new Point(500, 67);
            eklebtn.Name = "eklebtn";
            eklebtn.Size = new Size(90, 61);
            eklebtn.TabIndex = 16;
            eklebtn.Text = "Ekle";
            eklebtn.UseVisualStyleBackColor = true;
            eklebtn.Click += eklebtn_Click;
            // 
            // degisbtn
            // 
            degisbtn.Location = new Point(500, 151);
            degisbtn.Name = "degisbtn";
            degisbtn.Size = new Size(90, 61);
            degisbtn.TabIndex = 17;
            degisbtn.Text = "Değiştir";
            degisbtn.UseVisualStyleBackColor = true;
            degisbtn.Click += degisbtn_Click;
            // 
            // anasayfabtn
            // 
            anasayfabtn.Location = new Point(500, 235);
            anasayfabtn.Name = "anasayfabtn";
            anasayfabtn.Size = new Size(90, 61);
            anasayfabtn.TabIndex = 18;
            anasayfabtn.Text = "Ana Sayfa";
            anasayfabtn.UseVisualStyleBackColor = true;
            anasayfabtn.Click += anasayfabtn_Click;
            // 
            // cikisbtn
            // 
            cikisbtn.Location = new Point(500, 319);
            cikisbtn.Name = "cikisbtn";
            cikisbtn.Size = new Size(90, 61);
            cikisbtn.TabIndex = 19;
            cikisbtn.Text = "Çıkış";
            cikisbtn.UseVisualStyleBackColor = true;
            cikisbtn.Click += cikisbtn_Click;
            // 
            // notgiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cikisbtn);
            Controls.Add(anasayfabtn);
            Controls.Add(degisbtn);
            Controls.Add(eklebtn);
            Controls.Add(sonuctxt);
            Controls.Add(orttxt);
            Controls.Add(finaltxt);
            Controls.Add(vizetxt);
            Controls.Add(derstxt);
            Controls.Add(ogrnotxt);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "notgiris";
            Text = "Not Giriş Sayfası";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox ogrnotxt;
        private TextBox derstxt;
        private TextBox vizetxt;
        private TextBox finaltxt;
        private TextBox orttxt;
        private TextBox sonuctxt;
        private Button eklebtn;
        private Button degisbtn;
        private Button anasayfabtn;
        private Button cikisbtn;
    }
}