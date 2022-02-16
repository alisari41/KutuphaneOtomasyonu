using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneOtamasyonuu.BLL;
using KutuphaneOtamasyonuu.Entity;

namespace KutuphaneOtamasyonuu.UI.WinnForm
{
    public partial class kitapver : Form
    {
        public kitapver()
        {
            InitializeComponent();
        }

        private void txtTcno_TextChanged(object sender, EventArgs e)
        {
         
            if (txtTcno.Text.Trim() == "")//eğer TextBox1 boş ise
            {
                errorProvider1.SetError(txtTcno, "Bu alan boş geçilmez");
            } // ErrorProvider açılacak ve
            //üstteki satırda belirtilen msj çıkacak
            else
            {
                errorProvider1.SetError(txtTcno, "");
            }// ErrorProvider kapanacak
            if ((txtTcno.Text.Length < 11) || (txtTcno.Text.Length > 11))
            {
                errorProvider5.SetError(txtTcno, "TC Kimlik numarısı 11 karakterli olmalıdır.");
                //txtAdi.Clear();
                //txtSoyadi.Clear();
                //txtTelno.Clear();
                //txtAdres.Clear();

                //txtAdi.Enabled = false;
                //txtSoyadi.Enabled = false;
                //txtTelno.Enabled = false;
                //txtAdres.Enabled = false;

                //errorProvider2.Clear();
                //errorProvider3.Clear();
                //errorProvider4.Clear();
                //errorProvider6.Clear();

                errorProvider8.SetError(txtTcno, "");
                txtAdi.Clear();
                txtSoyadi.Clear();
                txtTelno.Clear();
                txtAdres.Clear();
            }
            else
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.TcNo = txtTcno.Text;
                OgrenciBLL bll = new OgrenciBLL();
                bll.TxtSearchDuzenleme(ogrenci);
                txtAdi.Text = ogrenci.Adi;
                txtSoyadi.Text = ogrenci.Soyadi;
                txtTelno.Text = ogrenci.TelefonNo;
                txtAdres.Text = ogrenci.Adres;

                errorProvider5.Clear();



                if ((txtAdi.Text.Trim() == "") && (txtSoyadi.Text.Trim() == "") && (txtTelno.Text.Trim() == ""))
                {
                    errorProvider5.Clear();
                    errorProvider8.SetError(txtTcno, "Girdiğniz tc kimlik numarasına ait öğrenci yok. ");
                    // ErrorProvider açılacak ve
                    //üstteki satırda belirtilen msj çıkacak



                }
                else
                {
                    errorProvider5.Clear();

                    //txtAdi.Enabled = true;
                    //txtSoyadi.Enabled = true;
                    //txtTelno.Enabled = true;
                    //txtAdres.Enabled = true;
                    errorProvider8.SetError(txtTcno, "");
                }
            }
            //Ogrenci ogrenci = new Ogrenci();
            //ogrenci.TcNo = txtTcno.Text;
            //OgrenciBLL bll = new OgrenciBLL();
            //bll.TxtSearchDuzenleme(ogrenci);
            //txtAdi.Text = ogrenci.Adi;
            //txtSoyadi.Text = ogrenci.Soyadi;
            //txtTelno.Text = ogrenci.TelefonNo;
            //txtAdres.Text = ogrenci.Adres;
        }

        private void btnyeni_Click(object sender, EventArgs e)
        {
            txtAdi.Clear();
            txtAdres.Clear();
            txtbarkod.Clear();
            txtkitapadi.Clear();
            txtrafno.Clear();
            txtsayfasayisi.Clear();
            txtSoyadi.Clear();
            txtTcno.Clear();
            txtTelno.Clear();
            txtyazar.Clear();
            dtpteslimtarih.CustomFormat = " ";
            dtpverilistarih.CustomFormat = " ";
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Kitapver kitapver = new Kitapver();
            kitapver.Tcno = txtTcno.Text;
            kitapver.Adi = txtAdi.Text;
            kitapver.Soyadi = txtSoyadi.Text;
            kitapver.Telefon = txtTelno.Text;
            kitapver.Adres = txtAdres.Text;
            kitapver.Barkodno = txtbarkod.Text;
            kitapver.Kitapadi = txtkitapadi.Text;
            kitapver.Yazari = txtyazar.Text;
            kitapver.Sayfasayi = txtyazar.Text;
            kitapver.Rafno = txtrafno.Text;
            kitapver.Verilistarihi = dtpverilistarih.Value;
            kitapver.Teslimtarihi = dtpteslimtarih.Value;

            KitapverBLL bll = new KitapverBLL();
            try
            {//eger burada hata alırsan cathdeki blogta yazılan mesaj bana hata vermesini göstercek                
                Kitap kitap = new Kitap();
                kitap.Borkodno = txtbarkod.Text;
                int sonuc = bll.AddNewItem(kitapver);
                if (sonuc == 4)
                {
                    KitapBLL bll2 = new KitapBLL();
                    bll2.UpdateKitapadetiazalt(kitap);//kitap öğrenciye verilirse kitap adetini azalt
                    MessageBox.Show("'" + kitapver.Adi + "' Öğrencimize '" + kitapver.Kitapadi + "' kitabı verilmiştir.","Başarılı");
                }
                else if (sonuc == 11)
                {
                    DialogResult Cikis;
                    Cikis = MessageBox.Show("Şuan kütüphanemizde aradığınız "+kitapver.Kitapadi +" kitabı kalmadı. "+kitapver.Kitapadi+ " Kitabını teslim alan öğrencilerin teslim tarihleri sırasına göre listelensin mi?", "Kitap Kalmadı Uyarısı!", MessageBoxButtons.YesNo);
                    if (Cikis == DialogResult.Yes)
                    {
                        kalmayankitaplarogrencilistesi aranankitaplar = new kalmayankitaplarogrencilistesi();
                        aranankitaplar.Show();
                        aranankitaplar.dataGridView1.DataSource = bll.BarkodArama(kitapver);
                        for (int i = 0; i < aranankitaplar.dataGridView1.Rows.Count; i++)
                        {//Kitabı alanların listesi eger geçikti ise kırmızı eğer 2 güün kaldı ise sarı renlte gözüksün
                            TimeSpan zamanfarki = DateTime.Now - Convert.ToDateTime(aranankitaplar.dataGridView1.Rows[i].Cells["Teslimtarihi"].Value.ToString());
                            double gun = zamanfarki.TotalDays;
                            if (gun > 0.0)
                            {
                                aranankitaplar.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            }
                            else if ((gun <= 0) && (gun >= -2))//eger teslim tarihine iki gün var ise 
                            {
                                aranankitaplar.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                            }
                        }

                    }
                    if (Cikis == DialogResult.No)
                    {
                       
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void txtbarkod_TextChanged(object sender, EventArgs e)
        {
            

            if (txtbarkod.Text.Trim() == "")//eğer TextBox1 boş ise
            {
                errorProvider2.SetError(txtbarkod, "Bu alan boş geçilemez");

                txtkitapadi.Clear();
                txtyazar.Clear();
                txtsayfasayisi.Clear();
                txtrafno.Clear();

            } // ErrorProvider açılacak ve
            //üstteki satırda belirtilen msj çıkacak
            else
            {
                Kitap kitap = new Kitap();
                kitap.Borkodno = txtbarkod.Text;
                KitapBLL bll = new KitapBLL();
                bll.TxtSearchDuzenleme(kitap);
                txtkitapadi.Text = kitap.Kitapadi;
                txtyazar.Text = kitap.Yazari;
                txtsayfasayisi.Text = kitap.Sayfasayisi;
                txtrafno.Text = kitap.Rafno;

                errorProvider2.SetError(txtbarkod, "");

                if ((txtkitapadi.Text.Trim() == "") && (txtyazar.Text.Trim() == "") && (txtsayfasayisi.Text.Trim() == "") && (txtrafno.Text.Trim() == ""))
                {
                    //errorProvider5.Clear();
                    errorProvider8.SetError(txtbarkod, "Güncellemek istediğniz barkod numarasına ait kitap bulunmamaktadır.Textboxlar aktif olmaz");
                    // ErrorProvider açılacak ve
                    //üstteki satırda belirtilen msj çıkacak
                    //txtkitapadi.Enabled = false;
                    //txtyazar.Enabled = false;
                    //txtsayfasayisi.Enabled = false;
                    //txtrafno.Enabled = false;


                }
                else
                {
                    //errorProvider5.Clear();

                    //txtkitapadi.Enabled = true;
                    //txtyazar.Enabled = true;
                    //txtsayfasayisi.Enabled = true;
                    //txtrafno.Enabled = true;
                    errorProvider8.SetError(txtbarkod, "");
                }


            }// ErrorProvider kapanacak


        }

        private void kitapver_Load(object sender, EventArgs e)
        {
            this.Location = new Point(250, 100);//Form ekranın açılınca yernini belirleme Point(x,y)
            errorProvider1.BlinkRate = 100000;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;

            errorProvider2.BlinkRate = 100000;
            errorProvider2.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;

            errorProvider3.BlinkRate = 100000;
            errorProvider3.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;

            errorProvider4.BlinkRate = 1000000;
            errorProvider4.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;

            errorProvider5.BlinkRate = 400;
            errorProvider5.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;

            errorProvider8.BlinkRate = 400;
            errorProvider8.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTcno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece sayi girişi
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtbarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece sayi girişi
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTcno_VisibleChanged(object sender, EventArgs e)
        {
            if (txtTcno.Text.Trim() == "")//eğer TextBox1 boş ise
            {
                errorProvider1.SetError(txtTcno, "Bu alan boş geçilmez");
            } // ErrorProvider açılacak ve
            //üstteki satırda belirtilen msj çıkacak
            else
            {
                errorProvider1.SetError(txtTcno, "");
            }// ErrorProvider kapanacak
        }

        private void txtbarkod_VisibleChanged(object sender, EventArgs e)
        {
            if (txtbarkod.Text.Trim() == "")//eğer TextBox1 boş ise
            {
                errorProvider2.SetError(txtbarkod, "Bu alan boş geçilemez");
            } // ErrorProvider açılacak ve
            //üstteki satırda belirtilen msj çıkacak
            else
            {
                errorProvider2.SetError(txtbarkod, "");
            }// ErrorProvider kapanacak
        }
    }
}
