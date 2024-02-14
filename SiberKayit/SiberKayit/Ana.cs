using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiberKayit
{
    public partial class Ana : Form
    {
        SiberKayitEntities vt = new SiberKayitEntities();
        private int kullaniciid;

        public Ana()
        {
            InitializeComponent();


        }




        private void button1_Click(object sender, EventArgs e)
        {
            string tc = txt_tc.Text;
            string adi = txt_adi.Text;
            string soyadi = txt_soyadi.Text;
            DateTime giris = DateTime.Now;



            try
            {

                if (tc.Length != 11)
                {
                    MessageBox.Show("Geçerli Bir Tc Giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    islemler ekle = new islemler();
                    ekle.kayit(adi, soyadi, tc, giris);
                    temizle();
                    listele();
                }






            }

            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Meydana Geldi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                temizle();
            }

        }

        public void temizle()
        {
            txt_adi.Text = string.Empty;
            txt_soyadi.Text = string.Empty;
            txt_tc.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            listele();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;

            tarihsaat.Text = DateTime.Now.ToLongDateString();

        }
        public void listele()
        {
            dataGridView1.DataSource = vt.siber.ToList();
            dataGridView1.Columns["id"].HeaderText = "Ziyaretçi No";
            dataGridView1.Columns["tcNo"].HeaderText = "TC No";
            dataGridView1.Columns["adi"].HeaderText = "Adı";
            dataGridView1.Columns["soyadi"].HeaderText = "Soyadı";
            dataGridView1.Columns["girisTarihi"].HeaderText = "Giriş Tarihi";
            dataGridView1.Columns["cikisTarihi"].HeaderText = "Çıkış Tarihi";
            dataGridView1.Columns["tcNo"].DisplayIndex = 3;
            dataGridView1.Columns["id"].Width = 100;
            dataGridView1.Columns["tcNo"].Width = 130;
            dataGridView1.Columns["adi"].Width = 130;
            dataGridView1.Columns["soyadi"].Width = 130;
            dataGridView1.Columns["girisTarihi"].Width = 130;
            dataGridView1.Columns["cikisTarihi"].Width = 130;
        }


        private void txt_tc_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult sonuc = MessageBox.Show("Seçili Kaydı Silmek İstediğinizden Emin Misiniz?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    try
                    {
                        DataGridViewRow row = dataGridView1.CurrentRow;
                        int secilenid = (int)row.Cells["id"].Value;
                        islemler sil = new islemler();
                        sil.sil(secilenid);
                        listele();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir Hata Meydana Geldi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Satır Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

            if (columnName == "cikisTarihi" && e.Value == null)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void dataGridView1_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int secilenid = (int)row.Cells["id"].Value;
                var secilenKayit = vt.siber.FirstOrDefault(x => x.id == secilenid);
                if (secilenKayit != null)
                {
                    var sorgu = vt.siber.Where(x => x.id == secilenid && x.cikisTarihi != null).ToList();

                    if (sorgu.Count > 0)
                    {
                        MessageBox.Show("Kişi Zaten Çıkış Yapmış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {


                        secilenKayit.cikisTarihi = DateTime.Now;
                        vt.SaveChanges();
                        listele();



                    }

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_arama_TextChanged(object sender, EventArgs e)
        {
            string aramaKelimesi = txt_arama.Text.ToLower();

            var filtrelenmisVeri = vt.siber.Where(x =>
                x.TcNo.ToLower().Contains(aramaKelimesi) ||
                x.adi.ToLower().Contains(aramaKelimesi) ||
                x.Soyadi.ToLower().Contains(aramaKelimesi)
            ).ToList();

            dataGridView1.DataSource = filtrelenmisVeri;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                int secilenid = (int)row.Cells["id"].Value;
                guncelle gunc = new guncelle(secilenid);
                gunc.dataguncelleme += dataguncelle;
                gunc.Show();
            }


        }

        private void dataguncelle(object sender, EventArgs e)
        {
            listele();

            int guncelid = ((guncelle)sender).kullaniciid;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells["id"].Value) == guncelid)
                {
                    row.Cells["adi"].Value = ((guncelle)sender).txt_adi.Text;
                    row.Cells["soyadi"].Value = ((guncelle)sender).txt_soyadi.Text;
                    row.Cells["tcNo"].Value = ((guncelle)sender).txt_tc.Text;
                    break;
                }
            }
        }

    }
    
 }
