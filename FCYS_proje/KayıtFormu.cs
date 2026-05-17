using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCYS_proje
{
    public partial class KayıtFormu : Form
    {
        public KayıtFormu()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=FCYS_Zeynep_Mdf;AttachDbFilename=|DataDirectory|\FCYS_DB.mdf;Integrated Security=True;";

            if (txtKullaniciAdi.Text == "" || txtSifre.Text == "" || txtEPosta.Text == "" || cmbRol.SelectedItem == null)
            {
                MessageBox.Show("Lütfen E-posta dahil tüm alanları doldurun ve rolünüzü seçin!");
                return;
            }

            if (!txtEPosta.Text.Contains("@") || !txtEPosta.Text.Contains("gmail.com") & !txtEPosta.Text.Contains("hotmail.com"))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz! (Örn: isim@gmail.com veya isim@hotmail.com)");
                return;
            }

            if (txtSifre.Text.Length < 4 || txtSifre.Text.Length > 8)
            {
                MessageBox.Show("Güvenliğiniz için şifreniz en az 4, en fazla 12 karakter uzunluğunda olmalıdır!");
                return; 
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    string query = "INSERT INTO Kullanicilar (kullanici_adi, sifre, rol, cuzdan_bakiyesi, e_posta) " +
                                   "VALUES (@username, @password, @role, @balance, @email)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtKullaniciAdi.Text);
                    cmd.Parameters.AddWithValue("@password", txtSifre.Text);
                    cmd.Parameters.AddWithValue("@role", cmbRol.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@balance", 0);
                    cmd.Parameters.AddWithValue("@email", txtEPosta.Text);

                    conn.Open();
                    int sonuc = cmd.ExecuteNonQuery();

                    if (sonuc > 0)
                    {
                        MessageBox.Show("E-posta adresinizle başarıyla kayıt oldunuz!");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt sırasında bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void KayıtFormu_Load(object sender, EventArgs e)
        {

        }

        private void txtEPosta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
