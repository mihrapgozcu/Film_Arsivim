using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace Film_Arsivim
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        private Color[] colors = new Color[10];

        public Form1()
        {
            InitializeComponent();
            InitializeColors();
        }

        // Connection string with the correct settings
        SqlConnection baglanti = new SqlConnection(@"Data source=MIHRAP-PC\SQLEXPRESS; Initial catalog=FilmArsivim; Integrated security=true; TrustServerCertificate=true");

        void filmler()
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * FROM TBLFILMLER", baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filmler y�klenirken bir hata olu�tu: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilmAd.Text) || string.IsNullOrEmpty(txtKategori.Text) || string.IsNullOrEmpty(txtLink.Text))
            {
                MessageBox.Show("L�tfen t�m alanlar� doldurunuz.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Insert into TBLFILMLER (AD, KATEGOR�, LINK) values (@P1, @P2, @P3)", baglanti);
                cmd.Parameters.AddWithValue("@P1", txtFilmAd.Text);
                cmd.Parameters.AddWithValue("@P2", txtKategori.Text);
                cmd.Parameters.AddWithValue("@P3", txtLink.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Film listenize ba�ar�yla eklendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filmler();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Film eklenirken bir hata olu�tu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            // Ensure the link is not empty or null
            if (!string.IsNullOrEmpty(link))
            {
                webView21.Source = new Uri(link);
            }
            else
            {
                MessageBox.Show("Ge�erli bir link bulunamad�.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje kendimi geli�tirmek i�in alm�� oldu�um bir e�itim dersinde yap�ld�", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnTamEkran_Click(object sender, EventArgs e)
        {
            // WebView2 i�erik tam ekran yapma
            if (webView21.CoreWebView2 != null)
            {
                await webView21.CoreWebView2.ExecuteScriptAsync(@"
                    var video = document.querySelector('video');
                    if (video) {
                        if (video.requestFullscreen) {
                            video.requestFullscreen();
                        } else if (video.mozRequestFullScreen) { /* Firefox */
                            video.mozRequestFullScreen();
                        } else if (video.webkitRequestFullscreen) { /* Chrome, Safari & Opera */
                            video.webkitRequestFullscreen();
                        } else if (video.msRequestFullscreen) { /* IE/Edge */
                            video.msRequestFullscreen();
                        }
                    } else {
                        alert('Video bulunamad�.');
                    }
                ");
            }
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            // Change the form's background color to a random color from the colors array
            this.BackColor = colors[rnd.Next(colors.Length)];
        }

        private void InitializeColors()
        {
            colors[0] = Color.Red;
            colors[1] = Color.Green;
            colors[2] = Color.Blue;
            colors[3] = Color.Yellow;
            colors[4] = Color.Purple;
            colors[5] = Color.Orange;
            colors[6] = Color.Pink;
            colors[7] = Color.Brown;
            colors[8] = Color.Gray;
            colors[9] = Color.Cyan;
        }
    }
}
