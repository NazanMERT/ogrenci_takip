namespace ogrenci_takip
{
    partial class bolum
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
            bolumtxt = new TextBox();
            label4 = new Label();
            bolumadtxt = new TextBox();
            label1 = new Label();
            anasayfabtn = new Button();
            cikisbtn = new Button();
            kaydetbtn = new Button();
            SuspendLayout();
            // 
            // bolumtxt
            // 
            bolumtxt.Location = new Point(265, 131);
            bolumtxt.Name = "bolumtxt";
            bolumtxt.Size = new Size(137, 23);
            bolumtxt.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 139);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 22;
            label4.Text = "Bölüm Id";
            // 
            // bolumadtxt
            // 
            bolumadtxt.Location = new Point(265, 190);
            bolumadtxt.Name = "bolumadtxt";
            bolumadtxt.Size = new Size(137, 23);
            bolumadtxt.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 198);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 24;
            label1.Text = "Bölüm Adı";
            // 
            // anasayfabtn
            // 
            anasayfabtn.Location = new Point(551, 261);
            anasayfabtn.Name = "anasayfabtn";
            anasayfabtn.Size = new Size(95, 56);
            anasayfabtn.TabIndex = 28;
            anasayfabtn.Text = "Anasayfa";
            anasayfabtn.UseVisualStyleBackColor = true;
            anasayfabtn.Click += anasayfabtn_Click;
            // 
            // cikisbtn
            // 
            cikisbtn.Location = new Point(551, 147);
            cikisbtn.Name = "cikisbtn";
            cikisbtn.Size = new Size(95, 56);
            cikisbtn.TabIndex = 27;
            cikisbtn.Text = "Çıkış";
            cikisbtn.UseVisualStyleBackColor = true;
            cikisbtn.Click += cikisbtn_Click;
            // 
            // kaydetbtn
            // 
            kaydetbtn.Location = new Point(551, 33);
            kaydetbtn.Name = "kaydetbtn";
            kaydetbtn.Size = new Size(95, 56);
            kaydetbtn.TabIndex = 26;
            kaydetbtn.Text = "Kaydet";
            kaydetbtn.UseVisualStyleBackColor = true;
            kaydetbtn.Click += kaydetbtn_Click;
            // 
            // bolum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(anasayfabtn);
            Controls.Add(cikisbtn);
            Controls.Add(kaydetbtn);
            Controls.Add(bolumadtxt);
            Controls.Add(label1);
            Controls.Add(bolumtxt);
            Controls.Add(label4);
            Name = "bolum";
            Text = "Bolum Ekle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox bolumtxt;
        private Label label4;
        private TextBox bolumadtxt;
        private Label label1;
        private Button anasayfabtn;
        private Button cikisbtn;
        private Button kaydetbtn;
    }
}