namespace ogrenci_takip
{
    partial class sil
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
            label2 = new Label();
            label3 = new Label();
            silbtn = new Button();
            ogrnotxt = new TextBox();
            adtxt = new TextBox();
            soyadtxt = new TextBox();
            anasayfabtn = new Button();
            cikisbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 93);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 166);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 1;
            label2.Text = "Ad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 239);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Soyad";
            // 
            // silbtn
            // 
            silbtn.Location = new Point(517, 82);
            silbtn.Name = "silbtn";
            silbtn.Size = new Size(86, 48);
            silbtn.TabIndex = 3;
            silbtn.Text = "Sil";
            silbtn.UseVisualStyleBackColor = true;
            silbtn.Click += silbtn_Click;
            // 
            // ogrnotxt
            // 
            ogrnotxt.Location = new Point(198, 90);
            ogrnotxt.Name = "ogrnotxt";
            ogrnotxt.Size = new Size(119, 23);
            ogrnotxt.TabIndex = 4;
            // 
            // adtxt
            // 
            adtxt.Location = new Point(198, 163);
            adtxt.Name = "adtxt";
            adtxt.Size = new Size(119, 23);
            adtxt.TabIndex = 5;
            // 
            // soyadtxt
            // 
            soyadtxt.Location = new Point(198, 236);
            soyadtxt.Name = "soyadtxt";
            soyadtxt.Size = new Size(119, 23);
            soyadtxt.TabIndex = 6;
            // 
            // anasayfabtn
            // 
            anasayfabtn.Location = new Point(517, 166);
            anasayfabtn.Name = "anasayfabtn";
            anasayfabtn.Size = new Size(86, 48);
            anasayfabtn.TabIndex = 7;
            anasayfabtn.Text = "Anasayfa";
            anasayfabtn.UseVisualStyleBackColor = true;
            anasayfabtn.Click += anasayfabtn_Click;
            // 
            // cikisbtn
            // 
            cikisbtn.Location = new Point(517, 250);
            cikisbtn.Name = "cikisbtn";
            cikisbtn.Size = new Size(86, 48);
            cikisbtn.TabIndex = 8;
            cikisbtn.Text = "Çıkış";
            cikisbtn.UseVisualStyleBackColor = true;
            cikisbtn.Click += cikisbtn_Click;
            // 
            // sil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cikisbtn);
            Controls.Add(anasayfabtn);
            Controls.Add(soyadtxt);
            Controls.Add(adtxt);
            Controls.Add(ogrnotxt);
            Controls.Add(silbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "sil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğrenci Sil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button silbtn;
        private TextBox ogrnotxt;
        private TextBox adtxt;
        private TextBox soyadtxt;
        private Button anasayfabtn;
        private Button cikisbtn;
    }
}