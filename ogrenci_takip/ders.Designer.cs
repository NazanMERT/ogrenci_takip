namespace ogrenci_takip
{
    partial class ders
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
            derstxt = new TextBox();
            label4 = new Label();
            dersadtxt = new TextBox();
            label1 = new Label();
            bolumtxt = new TextBox();
            label2 = new Label();
            anasayfabtn = new Button();
            cikisbtn = new Button();
            kaydetbtn = new Button();
            SuspendLayout();
            // 
            // derstxt
            // 
            derstxt.Location = new Point(221, 100);
            derstxt.Name = "derstxt";
            derstxt.Size = new Size(137, 23);
            derstxt.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(116, 100);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 32;
            label4.Text = "Ders Id";
            // 
            // dersadtxt
            // 
            dersadtxt.Location = new Point(221, 159);
            dersadtxt.Name = "dersadtxt";
            dersadtxt.Size = new Size(137, 23);
            dersadtxt.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 159);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 34;
            label1.Text = "Ders Adı";
            // 
            // bolumtxt
            // 
            bolumtxt.Location = new Point(221, 211);
            bolumtxt.Name = "bolumtxt";
            bolumtxt.Size = new Size(137, 23);
            bolumtxt.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 219);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 36;
            label2.Text = "Bölüm Id";
            // 
            // anasayfabtn
            // 
            anasayfabtn.Location = new Point(542, 273);
            anasayfabtn.Name = "anasayfabtn";
            anasayfabtn.Size = new Size(95, 56);
            anasayfabtn.TabIndex = 40;
            anasayfabtn.Text = "Anasayfa";
            anasayfabtn.UseVisualStyleBackColor = true;
            anasayfabtn.Click += anasayfabtn_Click;
            // 
            // cikisbtn
            // 
            cikisbtn.Location = new Point(542, 159);
            cikisbtn.Name = "cikisbtn";
            cikisbtn.Size = new Size(95, 56);
            cikisbtn.TabIndex = 39;
            cikisbtn.Text = "Çıkış";
            cikisbtn.UseVisualStyleBackColor = true;
            cikisbtn.Click += cikisbtn_Click;
            // 
            // kaydetbtn
            // 
            kaydetbtn.Location = new Point(542, 45);
            kaydetbtn.Name = "kaydetbtn";
            kaydetbtn.Size = new Size(95, 56);
            kaydetbtn.TabIndex = 38;
            kaydetbtn.Text = "Kaydet";
            kaydetbtn.UseVisualStyleBackColor = true;
            kaydetbtn.Click += kaydetbtn_Click;
            // 
            // ders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(anasayfabtn);
            Controls.Add(cikisbtn);
            Controls.Add(kaydetbtn);
            Controls.Add(bolumtxt);
            Controls.Add(label2);
            Controls.Add(dersadtxt);
            Controls.Add(label1);
            Controls.Add(derstxt);
            Controls.Add(label4);
            Name = "ders";
            Text = "Ders Ekle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox derstxt;
        private Label label4;
        private TextBox dersadtxt;
        private Label label1;
        private TextBox bolumtxt;
        private Label label2;
        private Button anasayfabtn;
        private Button cikisbtn;
        private Button kaydetbtn;
    }
}