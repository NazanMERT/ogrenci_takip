namespace ogrenci_takip
{
    partial class ara
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
            cikisbtn = new Button();
            anasayfabtn = new Button();
            soyadtxt = new TextBox();
            adtxt = new TextBox();
            ogrnotxt = new TextBox();
            arabtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cikisbtn
            // 
            cikisbtn.Location = new Point(594, 279);
            cikisbtn.Name = "cikisbtn";
            cikisbtn.Size = new Size(86, 48);
            cikisbtn.TabIndex = 17;
            cikisbtn.Text = "Çıkış";
            cikisbtn.UseVisualStyleBackColor = true;
            cikisbtn.Click += cikisbtn_Click;
            // 
            // anasayfabtn
            // 
            anasayfabtn.Location = new Point(594, 188);
            anasayfabtn.Name = "anasayfabtn";
            anasayfabtn.Size = new Size(86, 48);
            anasayfabtn.TabIndex = 16;
            anasayfabtn.Text = "Anasayfa";
            anasayfabtn.UseVisualStyleBackColor = true;
            anasayfabtn.Click += anasayfabtn_Click;
            // 
            // soyadtxt
            // 
            soyadtxt.Location = new Point(307, 285);
            soyadtxt.Name = "soyadtxt";
            soyadtxt.Size = new Size(119, 23);
            soyadtxt.TabIndex = 15;
            // 
            // adtxt
            // 
            adtxt.Location = new Point(307, 212);
            adtxt.Name = "adtxt";
            adtxt.Size = new Size(119, 23);
            adtxt.TabIndex = 14;
            // 
            // ogrnotxt
            // 
            ogrnotxt.Location = new Point(307, 139);
            ogrnotxt.Name = "ogrnotxt";
            ogrnotxt.Size = new Size(119, 23);
            ogrnotxt.TabIndex = 13;
            // 
            // arabtn
            // 
            arabtn.Location = new Point(594, 98);
            arabtn.Name = "arabtn";
            arabtn.Size = new Size(86, 48);
            arabtn.TabIndex = 12;
            arabtn.Text = "Ara";
            arabtn.UseVisualStyleBackColor = true;
            arabtn.Click += arabtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 288);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 11;
            label3.Text = "Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 215);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 10;
            label2.Text = "Ad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 142);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 9;
            label1.Text = "Öğrenci No";
            // 
            // ara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cikisbtn);
            Controls.Add(anasayfabtn);
            Controls.Add(soyadtxt);
            Controls.Add(adtxt);
            Controls.Add(ogrnotxt);
            Controls.Add(arabtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ara";
            Text = "Öğrenci Ara";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cikisbtn;
        private Button anasayfabtn;
        private TextBox soyadtxt;
        private TextBox adtxt;
        private TextBox ogrnotxt;
        private Button arabtn;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}