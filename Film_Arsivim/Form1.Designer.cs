namespace Film_Arsivim
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            btnCikis = new Button();
            btnRenkDegistir = new Button();
            btnHakkimizda = new Button();
            btnTamEkran = new Button();
            btnKaydet = new Button();
            txtLink = new TextBox();
            txtKategori = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtFilmAd = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1417, 77);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(521, 19);
            label1.Name = "label1";
            label1.Size = new Size(362, 58);
            label1.TabIndex = 1;
            label1.Text = "Benim Sinemam";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1271, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(401, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(536, 546);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Film Listesi";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(530, 513);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(webView21);
            groupBox2.Location = new Point(981, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(409, 537);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = " Ekran";
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.BackColor = Color.White;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.Transparent;
            webView21.ForeColor = Color.White;
            webView21.Location = new Point(6, 33);
            webView21.Name = "webView21";
            webView21.Size = new Size(397, 498);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(btnKaydet);
            groupBox3.Controls.Add(txtLink);
            groupBox3.Controls.Add(txtKategori);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtFilmAd);
            groupBox3.Location = new Point(13, 112);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(363, 546);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Yeni Film";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnCikis);
            groupBox4.Controls.Add(btnRenkDegistir);
            groupBox4.Controls.Add(btnHakkimizda);
            groupBox4.Controls.Add(btnTamEkran);
            groupBox4.Location = new Point(15, 304);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(277, 227);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "İşlemler";
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(6, 167);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(265, 35);
            btnCikis.TabIndex = 11;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnRenkDegistir
            // 
            btnRenkDegistir.Location = new Point(6, 126);
            btnRenkDegistir.Name = "btnRenkDegistir";
            btnRenkDegistir.Size = new Size(265, 35);
            btnRenkDegistir.TabIndex = 10;
            btnRenkDegistir.Text = "Renk Değiştir";
            btnRenkDegistir.UseVisualStyleBackColor = true;
            btnRenkDegistir.Click += btnRenkDegistir_Click;
            // 
            // btnHakkimizda
            // 
            btnHakkimizda.Location = new Point(6, 85);
            btnHakkimizda.Name = "btnHakkimizda";
            btnHakkimizda.Size = new Size(265, 35);
            btnHakkimizda.TabIndex = 9;
            btnHakkimizda.Text = "Hakkımızda";
            btnHakkimizda.UseVisualStyleBackColor = true;
            btnHakkimizda.Click += btnHakkimizda_Click;
            // 
            // btnTamEkran
            // 
            btnTamEkran.Location = new Point(6, 44);
            btnTamEkran.Name = "btnTamEkran";
            btnTamEkran.Size = new Size(265, 35);
            btnTamEkran.TabIndex = 8;
            btnTamEkran.Text = "Tam Ekran";
            btnTamEkran.UseVisualStyleBackColor = true;
            btnTamEkran.Click += btnTamEkran_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(109, 240);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(190, 35);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtLink
            // 
            txtLink.Location = new Point(109, 188);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(190, 34);
            txtLink.TabIndex = 6;
            // 
            // txtKategori
            // 
            txtKategori.Location = new Point(109, 127);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(190, 34);
            txtKategori.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 194);
            label4.Name = "label4";
            label4.Size = new Size(51, 28);
            label4.TabIndex = 4;
            label4.Text = "Link:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(91, 28);
            label3.TabIndex = 3;
            label3.Text = "Kategori:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 61);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 2;
            label2.Text = "Film Adı:";
            // 
            // txtFilmAd
            // 
            txtFilmAd.Location = new Point(109, 58);
            txtFilmAd.Name = "txtFilmAd";
            txtFilmAd.Size = new Size(190, 34);
            txtFilmAd.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(1441, 670);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Label label1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btnTamEkran;
        private Button btnKaydet;
        private TextBox txtLink;
        private TextBox txtKategori;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtFilmAd;
        private DataGridView dataGridView1;
        private Button btnCikis;
        private Button btnRenkDegistir;
        private Button btnHakkimizda;
    }
}
