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
    public partial class kitapguncelleme : Form
    {
        public kitapguncelleme()
        {
            InitializeComponent();
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.Borkodno = txtbarkod.Text.ToString();
            kitap.Kitapadi = txtkitapadi.Text;
            kitap.Yazari = txtyazar.Text;
            kitap.Sayfasayisi = txtsayfasayisi.Text;
            kitap.Rafno = txtrafno.Text;
            try
            {
                kitap.Kitapadeti = Convert.ToInt16(txtkitapadeti.Text);
            }
            catch (FormatException hata)
            {

                MessageBox.Show("Lütfen Kitap adeti alanını boş bırakmayınız.Sayısal değer giriniz.");
                kitap.Kitapadeti = -1;
            }
           
            KitapBLL bll = new KitapBLL();
            try
            {//eger burada hata alırsan cathdeki blogta yazılan mesaj bana hata vermesini göstercek
                bll.UpdateItem(kitap);
                MessageBox.Show("Kitap bilgileri düzenlendi.","İşlem Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtbarkod_TextChanged(object sender, EventArgs e)
        {
            if (txtbarkod.Text.Trim() == "")//eğer txtbarkod boş ise
            {//textnboxlar boş ve aktif olmasın
                errorProvider1.SetError(txtbarkod, "Bu alan boş geçilemez");
                txtkitapadeti.Clear();
                txtkitapadi.Clear();
                txtyazar.Clear();
                txtsayfasayisi.Clear();
                txtrafno.Clear();
                txtkitapadeti.Clear();
                txtkitapadeti.Enabled = false;
                txtkitapadi.Enabled = false;
                txtyazar.Enabled = false;
                txtsayfasayisi.Enabled = false;
                txtrafno.Enabled = false;
                txtkitapadeti.Enabled = false;
            } 
            else
            {//eğer txtbarkod dolu ise bLL katmanına gidicek Bll deal katmanına gidicek ve bana değiişkenler gelicek.Sonrasında tekrar if else
                Kitap kitap = new Kitap();
                kitap.Borkodno = txtbarkod.Text;
                KitapBLL bll = new KitapBLL();
                bll.TxtSearchDuzenleme(kitap);
                txtkitapadi.Text = kitap.Kitapadi;
                txtyazar.Text = kitap.Yazari;
                txtsayfasayisi.Text = kitap.Sayfasayisi;
                txtrafno.Text = kitap.Rafno;
                txtkitapadeti.Text = kitap.Kitapadeti.ToString();
                errorProvider1.SetError(txtbarkod, "");
                if ((txtkitapadi.Text.Trim() == "") && (txtyazar.Text.Trim() == "") && (txtsayfasayisi.Text.Trim() == "")&&(txtrafno.Text.Trim()==""))
                {//Eğer  barkod numarasına ait kkitap yok ise textboxlar aktif olamasın
                    errorProvider8.SetError(txtbarkod, "Güncellemek istediğniz barkod numarasına ait kitap bulunmamaktadır.Textboxlar aktif olmaz");
                    // ErrorProvider açılacak ve
                    //üstteki satırda belirtilen msj çıkacak
                    txtkitapadeti.Enabled = false;
                    txtkitapadi.Enabled = false;
                    txtyazar.Enabled = false;
                    txtsayfasayisi.Enabled = false;
                    txtrafno.Enabled = false;
                    txtkitapadeti.Enabled = false;
                }
                else
                {//Eğere barkod numarasına ait kitap var ise textboxları aktif yap ve değerlerini ata Sonra Hata MEsajını KALDIR.
                    txtkitapadeti.Enabled = true;
                    txtkitapadi.Enabled = true;
                    txtyazar.Enabled = true;
                    txtsayfasayisi.Enabled = true;
                    txtrafno.Enabled = true;
                    txtkitapadeti.Enabled = true;
                    errorProvider8.SetError(txtbarkod, "");
                }
            }// ErrorProvider kapanacak
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtbarkod.Clear();
            txtkitapadi.Clear();
            txtrafno.Clear();
            txtsayfasayisi.Clear();
            txtyazar.Clear();
        }

        private void txtbarkod_KeyPress(object sender, KeyPressEventArgs e)
        {//sadece sayi girişi
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtsayfasayisi_KeyPress(object sender, KeyPressEventArgs e)
        {//sadece sayi girişi
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtrafno_KeyPress(object sender, KeyPressEventArgs e)
        {//sadece sayi girişi
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtkitapadeti_KeyPress(object sender, KeyPressEventArgs e)
        {//sadece sayi girişi
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtbarkod_VisibleChanged(object sender, EventArgs e)
        {
            if (txtbarkod.Text.Trim() == "")//eğer TextBox1 boş ise
            {
                errorProvider1.SetError(txtbarkod, "Bu alan boş geçilemez");
            } // ErrorProvider açılacak ve
            //üstteki satırda belirtilen msj çıkacak
            else
            {
                errorProvider1.SetError(txtbarkod, "");
            }// ErrorProvider kapanacak
        }

        private void txtsayfasayisi_TextChanged(object sender, EventArgs e)
        {
            if (txtsayfasayisi.Text.Trim() == "")//eğer TextBox1 boş ise
            {
                errorProvider4.SetError(txtsayfasayisi, "Bu alan boş geçilemez");
            } // ErrorProvider açılacak ve
            //üstteki satırda belirtilen msj çıkacak
            else
            {
                errorProvider4.SetError(txtsayfasayisi, "");
            }// ErrorProvider kapanacak
        }

        private void txtkitapadi_TextChanged(object sender, EventArgs e)
        {
            if (txtkitapadi.Text.Trim() == "")//eğer TextBox1 boş ise
            {
                errorProvider2.SetError(txtkitapadi, "Bu alan boş geçilemez");
            } // ErrorProvider açılacak ve
            //üstteki satırda belirtilen msj çıkacak
            else
            {
                errorProvider2.SetError(txtkitapadi, "");
            }// ErrorProvider kapanacak
        }

        private void txtyazar_TextChanged(object sender, EventArgs e)
        {
            if (txtyazar.Text.Trim() == "")//eğer TextBox1 boş ise
            {
                errorProvider3.SetError(txtyazar, "Bu alan boş geçilemez");
            } // ErrorProvider açılacak ve
            //üstteki satırda belirtilen msj çıkacak
            else
            {
                errorProvider3.SetError(txtyazar, "");
            }// ErrorProvider kapanacak
        }

        private void txtrafno_TextChanged(object sender, EventArgs e)
        {
            if (txtrafno.Text.Trim() == "")//eğer TextBox1 boş ise
            {
                errorProvider5.SetError(txtrafno, "Bu alan boş geçilemez");
            } // ErrorProvider açılacak ve
            //üstteki satırda belirtilen msj çıkacak
            else
            {
                errorProvider5.SetError(txtrafno, "");
            }// ErrorProvider kapanacak
        }

        private void txtkitapadeti_TextChanged(object sender, EventArgs e)
        {

        }

        private void kitapguncelleme_Load(object sender, EventArgs e)
        {
            this.Location = new Point(400, 100);//Form ekranın açılınca yernini belirleme Point(x,y)
        }
    }
}
