namespace ogrenci_takip
{
    partial class girisekranı
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ogrencitxt = new TextBox();
            ogrnsifretxt = new TextBox();
            ogretmentxt = new TextBox();
            ogrtmnsifretxt = new TextBox();
            ogrbtn = new Button();
            ogrtmnbtn = new Button();
            ogriptalbtn = new Button();
            ogtmniptalbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 176);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci Girişi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(561, 176);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Öğretmen Girişi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 223);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 278);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "Şifre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(477, 232);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 4;
            label5.Text = "Kullanıcı Adı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(477, 278);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 5;
            label6.Text = "Şifre";
            // 
            // ogrencitxt
            // 
            ogrencitxt.Location = new Point(132, 220);
            ogrencitxt.Name = "ogrencitxt";
            ogrencitxt.Size = new Size(116, 23);
            ogrencitxt.TabIndex = 6;
            // 
            // ogrnsifretxt
            // 
            ogrnsifretxt.Location = new Point(132, 278);
            ogrnsifretxt.Name = "ogrnsifretxt";
            ogrnsifretxt.Size = new Size(116, 23);
            ogrnsifretxt.TabIndex = 7;
            // 
            // ogretmentxt
            // 
            ogretmentxt.Location = new Point(581, 224);
            ogretmentxt.Name = "ogretmentxt";
            ogretmentxt.Size = new Size(119, 23);
            ogretmentxt.TabIndex = 8;
            // 
            // ogrtmnsifretxt
            // 
            ogrtmnsifretxt.Location = new Point(581, 278);
            ogrtmnsifretxt.Name = "ogrtmnsifretxt";
            ogrtmnsifretxt.Size = new Size(119, 23);
            ogrtmnsifretxt.TabIndex = 9;
            // 
            // ogrbtn
            // 
            ogrbtn.Location = new Point(49, 342);
            ogrbtn.Name = "ogrbtn";
            ogrbtn.Size = new Size(75, 23);
            ogrbtn.TabIndex = 10;
            ogrbtn.Text = "Tamam";
            ogrbtn.UseVisualStyleBackColor = true;
            ogrbtn.Click += ogrbtn_Click;
            // 
            // ogrtmnbtn
            // 
            ogrtmnbtn.Location = new Point(506, 342);
            ogrtmnbtn.Name = "ogrtmnbtn";
            ogrtmnbtn.Size = new Size(75, 23);
            ogrtmnbtn.TabIndex = 11;
            ogrtmnbtn.Text = "Tamam";
            ogrtmnbtn.UseVisualStyleBackColor = true;
            ogrtmnbtn.Click += ogrtmnbtn_Click;
            // 
            // ogriptalbtn
            // 
            ogriptalbtn.Location = new Point(227, 342);
            ogriptalbtn.Name = "ogriptalbtn";
            ogriptalbtn.Size = new Size(75, 23);
            ogriptalbtn.TabIndex = 12;
            ogriptalbtn.Text = "İptal";
            ogriptalbtn.UseVisualStyleBackColor = true;
            ogriptalbtn.Click += ogriptalbtn_Click;
            // 
            // ogtmniptalbtn
            // 
            ogtmniptalbtn.Location = new Point(682, 342);
            ogtmniptalbtn.Name = "ogtmniptalbtn";
            ogtmniptalbtn.Size = new Size(75, 23);
            ogtmniptalbtn.TabIndex = 13;
            ogtmniptalbtn.Text = "İptal";
            ogtmniptalbtn.UseVisualStyleBackColor = true;
            ogtmniptalbtn.Click += ogtmniptalbtn_Click;
            // 
            // girisekranı
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ogtmniptalbtn);
            Controls.Add(ogriptalbtn);
            Controls.Add(ogrtmnbtn);
            Controls.Add(ogrbtn);
            Controls.Add(ogrtmnsifretxt);
            Controls.Add(ogretmentxt);
            Controls.Add(ogrnsifretxt);
            Controls.Add(ogrencitxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "girisekranı";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox ogrencitxt;
        private TextBox ogrnsifretxt;
        private TextBox ogretmentxt;
        private TextBox ogrtmnsifretxt;
        private Button ogrbtn;
        private Button ogrtmnbtn;
        private Button ogriptalbtn;
        private Button ogtmniptalbtn;
    }
}
