namespace ogrenci_takip
{
    partial class ogrencipaneli
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
            ogrnprofilbtn = new Button();
            cikisbtn = new Button();
            SuspendLayout();
            // 
            // ogrnprofilbtn
            // 
            ogrnprofilbtn.Location = new Point(173, 186);
            ogrnprofilbtn.Name = "ogrnprofilbtn";
            ogrnprofilbtn.Size = new Size(110, 85);
            ogrnprofilbtn.TabIndex = 0;
            ogrnprofilbtn.Text = "Öğrenci Profili";
            ogrnprofilbtn.UseVisualStyleBackColor = true;
            ogrnprofilbtn.Click += ogrnprofilbtn_Click;
            // 
            // cikisbtn
            // 
            cikisbtn.Location = new Point(463, 186);
            cikisbtn.Name = "cikisbtn";
            cikisbtn.Size = new Size(110, 85);
            cikisbtn.TabIndex = 2;
            cikisbtn.Text = "Çıkış";
            cikisbtn.UseVisualStyleBackColor = true;
            cikisbtn.Click += cikisbtn_Click;
            // 
            // ogrencipaneli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cikisbtn);
            Controls.Add(ogrnprofilbtn);
            Name = "ogrencipaneli";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğrenci Sayfası";
            ResumeLayout(false);
        }

        #endregion

        private Button ogrnprofilbtn;
        private Button cikisbtn;
    }
}