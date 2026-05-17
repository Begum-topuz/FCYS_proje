using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FCYS_proje
{
    public partial class ProjeEkleForm : Form
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=FCYS_Zeynep_Mdf;AttachDbFilename=|DataDirectory|\FCYS_DB.mdf;Integrated Security=True;";
        public ProjeEkleForm()
        {
            InitializeComponent();
        }

        private void btnProjeKaydet_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    if (string.IsNullOrEmpty(txtBaslik.Text) || string.IsNullOrEmpty(txtMusteriId.Text) || string.IsNullOrEmpty(txtUcret.Text))
                    {
                        MessageBox.Show("Lütfen boş alan bırakmayınız!");
                        return;
                    }

                    string sql = "INSERT INTO Projeler (musteri_id, baslik, musteri_talebi, toplam_ucret, durum, teslim_tarihi) " +
                                 "VALUES (@musteri, @baslik, @talep, @ucret, 'Onay Bekliyor', @teslim)";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@musteri", Convert.ToInt32(txtMusteriId.Text));
                    cmd.Parameters.AddWithValue("@baslik", txtBaslik.Text);
                    cmd.Parameters.AddWithValue("@talep", txtTalep.Text);
                    cmd.Parameters.AddWithValue("@ucret", Convert.ToDecimal(txtUcret.Text));
                    cmd.Parameters.AddWithValue("@teslim", dtpTeslimTarihi.Value);

                    conn.Open();
                    int sonuc = cmd.ExecuteNonQuery();

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Yeni proje talebi teslim tarihiyle birlikte başarıyla sisteme eklendi!");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Proje eklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        private void ProjeEkleForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}