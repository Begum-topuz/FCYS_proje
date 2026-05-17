using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FCYS_proje
{
    public partial class FreelancerPanel : Form
    {
        private int aktifFreelancerId;
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=FCYS_Zeynep_Mdf;AttachDbFilename=|DataDirectory|\FCYS_DB.mdf;Integrated Security=True;";

        public FreelancerPanel(int freelancerId)
        {
            InitializeComponent();
            this.aktifFreelancerId = freelancerId;
        }

        private void FreelancerPanel_Load(object sender, EventArgs e)
        {
            try
            {
                ProjeleriListele();
                CuzdanOzetiniGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Panel arayüzü yüklenirken bir sistem hatası oluştu: " + ex.Message, "Yükleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ProjeleriListele()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "SELECT p.proje_id, p.baslik, p.toplam_ucret, p.durum, p.teslim_tarihi, p.musteri_talebi, k.kullanici_adi AS [Müşteri Adı] " +
                                   "FROM Projeler p " +
                                   "INNER JOIN Kullanicilar k ON p.musteri_id = k.user_id " +
                                   "WHERE p.freelancer_id = @freelancerId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@freelancerId", this.aktifFreelancerId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        string mevcutDurum = row["durum"].ToString();

                        if (mevcutDurum != "Teslim Edildi" && mevcutDurum != "Tamamlandı" && mevcutDurum != "Reddedildi")
                        {
                            if (row["teslim_tarihi"] != DBNull.Value)
                            {
                                DateTime teslimTarihi = Convert.ToDateTime(row["teslim_tarihi"]);

                                if (teslimTarihi < DateTime.Now)
                                {
                                    int projeId = Convert.ToInt32(row["proje_id"]);
                                    row["durum"] = "Süresi Doldu";

                                    SqlCommand cmdGuncelle = new SqlCommand("UPDATE Projeler SET durum = 'Süresi Doldu' WHERE proje_id = @id", conn);
                                    cmdGuncelle.Parameters.AddWithValue("@id", projeId);
                                    cmdGuncelle.ExecuteNonQuery();
                                }

                                else
                                {
                                    TimeSpan kalanSure = teslimTarihi - DateTime.Now;

                                    if (kalanSure.TotalDays <= 2 && mevcutDurum == "Onay Bekliyor")
                                    {
                                        string projeBaslik = row["baslik"].ToString();
                                        MessageBox.Show($"⚠️ AKILLI HATIRLATICI ⚠️\n\n\"{projeBaslik}\" isimli projenizin teslim tarihine 2 günden az süre kalmıştır!\nLütfen çalışmalarınızı hızlandırın.", "Yaklaşan Teslim Tarihi Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                        }
                    }

                    dgvProjeler.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Projeler listelenirken hata oluştu: " + ex.Message, "Liste Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CuzdanOzetiniGetir()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    SqlCommand cmdToplam = new SqlCommand("SELECT SUM(toplam_ucret) FROM Projeler WHERE freelancer_id = @id AND (durum = 'Tamamlandı' OR durum = 'Teslim Edildi')", conn);
                    cmdToplam.Parameters.AddWithValue("@id", aktifFreelancerId);
                    object toplam = cmdToplam.ExecuteScalar();
                    lblToplamKazanc.Text = toplam != DBNull.Value && toplam != null ? toplam.ToString() + " TL" : "0 TL";

                    SqlCommand cmdBekleyen = new SqlCommand("SELECT SUM(toplam_ucret) FROM Projeler WHERE freelancer_id = @id AND (durum = 'Onay Bekliyor' OR durum = 'Devam Ediyor')", conn);
                    cmdBekleyen.Parameters.AddWithValue("@id", aktifFreelancerId);
                    object bekleyen = cmdBekleyen.ExecuteScalar();
                    lblBekleyenOdemeler.Text = bekleyen != DBNull.Value && bekleyen != null ? bekleyen.ToString() + " TL" : "0 TL";

                    SqlCommand cmdKasa = new SqlCommand("SELECT cuzdan_bakiyesi FROM Kullanicilar WHERE user_id = @id", conn);
                    cmdKasa.Parameters.AddWithValue("@id", aktifFreelancerId);
                    object kasa = cmdKasa.ExecuteScalar();
                    lblKasadakiPara.Text = kasa != DBNull.Value && kasa != null ? kasa.ToString() + " TL" : "0 TL";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cüzdan bilgileri hesaplanırken hata oluştu: " + ex.Message, "Finans Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjeEkleForm frm = new ProjeEkleForm();
            frm.ShowDialog();

            ProjeleriListele();
            CuzdanOzetiniGetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvProjeler.SelectedRows.Count > 0)
            {
                int secilenProjeId = Convert.ToInt32(dgvProjeler.SelectedRows[0].Cells[0].Value);

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        string sql = "UPDATE Projeler SET durum = 'Tamamlandı' WHERE proje_id = @id";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", secilenProjeId);

                        conn.Open();
                        int sonuc = cmd.ExecuteNonQuery();

                        if (sonuc > 0)
                        {
                            MessageBox.Show("Proje durumu 'Tamamlandı' olarak güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ProjeleriListele();
                            CuzdanOzetiniGetir();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Güncelleme hatası: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen durumunu güncellemek istediğiniz projeyi tablodan seçin.", "Seçim Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvProjeler.SelectedRows.Count > 0)
            {
                int secilenProjeId = Convert.ToInt32(dgvProjeler.SelectedRows[0].Cells[0].Value);
                decimal projeUcreti = Convert.ToDecimal(dgvProjeler.SelectedRows[0].Cells["toplam_ucret"].Value);
                string durum = dgvProjeler.SelectedRows[0].Cells["durum"].Value.ToString();

                if (durum != "Tamamlandı")
                {
                    MessageBox.Show("Yalnızca 'Tamamlandı' durumundaki projelerin ödemesini onaylayabilirsiniz!", "Onay Reddedildi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();

                        SqlCommand cmdProje = new SqlCommand("UPDATE Projeler SET durum = 'Teslim Edildi' WHERE proje_id = @id", conn);
                        cmdProje.Parameters.AddWithValue("@id", secilenProjeId);
                        cmdProje.ExecuteNonQuery();

                        SqlCommand cmdBakiye = new SqlCommand("UPDATE Kullanicilar SET cuzdan_bakiyesi = cuzdan_bakiyesi + @ucret WHERE user_id = @id", conn);
                        cmdBakiye.Parameters.AddWithValue("@ucret", projeUcreti);
                        cmdBakiye.Parameters.AddWithValue("@id", aktifFreelancerId);
                        cmdBakiye.ExecuteNonQuery();

                        MessageBox.Show("Ödeme başarıyla onaylandı ve kasaya aktarıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ProjeleriListele();
                        CuzdanOzetiniGetir();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ödeme onayı esnasında hata: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen ödemesini onaylamak istediğiniz projeyi tablodan seçin.", "Seçim Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            if (dgvProjeler.SelectedRows.Count > 0)
            {
                int secilenProjeId = Convert.ToInt32(dgvProjeler.SelectedRows[0].Cells[0].Value);
                string queryReddet = "UPDATE Projeler SET durum = 'Reddedildi' WHERE proje_id = @projeId";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(queryReddet, conn);
                        cmd.Parameters.AddWithValue("@projeId", secilenProjeId);

                        int sonuc = cmd.ExecuteNonQuery();
                        if (sonuc > 0)
                        {
                            MessageBox.Show("Proje talebini reddettiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ProjeleriListele();
                            CuzdanOzetiniGetir();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Reddetme işlemi sırasında hata oluştu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen reddetmek istediğiniz projeyi tablodan seçin!", "Seçim Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvProjeler.SelectedRows.Count > 0)
            {
                int secilenProjeId = Convert.ToInt32(dgvProjeler.SelectedRows[0].Cells[0].Value);
                string durum = dgvProjeler.SelectedRows[0].Cells["durum"].Value.ToString();

                if (durum != "Onay Bekliyor")
                {
                    MessageBox.Show("Yalnızca 'Onay Bekliyor' durumundaki projeleri kabul edebilirsiniz!", "İşlem Geçersiz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string queryKabul = "UPDATE Projeler SET durum = 'Devam Ediyor' WHERE proje_id = @projeId";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(queryKabul, conn);
                        cmd.Parameters.AddWithValue("@projeId", secilenProjeId);

                        int sonuc = cmd.ExecuteNonQuery();
                        if (sonuc > 0)
                        {
                            MessageBox.Show("Proje talebini başarıyla kabul ettiniz! Proje 'Devam Ediyor' durumuna getirildi.", "Proje Kabul Edildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ProjeleriListele();
                            CuzdanOzetiniGetir();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kabul etme işlemi sırasında hata oluştu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen kabul etmek istediğiniz projeyi tablodan seçin!", "Seçim Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Form girisFormu = Application.OpenForms["Form1"];
            if (girisFormu != null)
            {
                girisFormu.Show();
                this.Close();
            }
        }

        private void FreelancerPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms["Form1"] != null && !Application.OpenForms["Form1"].Visible)
            {
                Application.Exit();
            }
        }

        private void btnReddet_Click_1(object sender, EventArgs e)
        {
          
        }
    }
}