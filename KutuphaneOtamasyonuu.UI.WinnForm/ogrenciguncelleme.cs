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
using KutuphaneOtamasyonuu.BLL;//sadece BLL ile bağlanır unutma Form için geçerli
using KutuphaneOtamasyonuu.Entity;

namespace KutuphaneOtamasyonuu.UI.WinnForm
{
    public partial class ogrenciguncelleme : Form
    {
        public ogrenciguncelleme()
        {
            InitializeComponent();
        }
       
        private void btnduzenle_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.TcNo = txtTcno.Text;
            ogrenci.Adi = txtAdi.Text;
            ogrenci.Soyadi = txtSoyadi.Text;
            ogrenci.TelefonNo = txtTelno.Text;
            ogrenci.Adres = txtAdres.Text;
            OgrenciBLL bll = new OgrenciBLL();
            try
            {//eger burada hata alırsan cathdeki blogta yazılan mesaj bana hata vermesini göstercek
                int sonuc;
                sonuc = bll.UpdateItem(ogrenci);

                //eğer öğrenci bilgileri güncelleme yapıldıysa kitapver ve kitap iade tablolarında da güncelleme yapılmalıdır.
                if (sonuc == 1)
                {
                    MessageBox.Show("Öğrenci bilgilerinnde Güncelleme yapıldı.", "GÜNCELLEME");
                }
                else if (sonuc == 0)
                {
                    throw new Exception("Bu tc kimlik numarasına ait öğrenci bulunmamaktadır. O yüzden gücelleme yapamazsınız.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTcno_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnyeni_Click(object sender, EventArgs e)
        {
            txtTcno.Clear();
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTelno.Clear();
            txtAdres.Clear();
            txtAdi.Enabled = false;//giriş yasak çünkü tc girilmedi
            txtSoyadi.Enabled = false;
            txtTelno.Enabled = false;
            txtAdres.Enabled = false;
            errorProvider2.Clear();//eror  yasak çünkü tc girilmedi
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
            errorProvider6.Clear();
        }

        private void txtTcno_TextChanged_1(object sender, EventArgs e)
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
                txtAdi.Clear();
                txtSoyadi.Clear();
                txtTelno.Clear();
                txtAdres.Clear();
                txtAdi.Enabled = false;
                txtSoyadi.Enabled = false;
                txtTelno.Enabled = false;
                txtAdres.Enabled = false;
                errorProvider2.Clear();
                errorProvider3.Clear();
                errorProvider4.Clear();
                errorProvider6.Clear();
                errorProvider8.SetError(txtTcno, "");
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
                    errorProvider8.SetError(txtTcno, "Güncellemek istediğniz tc numarasına ait öğrenci yok textboxlar aktif olmaz");
                    // ErrorProvider açılacak ve
                    //üstteki satırda belirtilen msj çıkacak
                }
                else
                {
                    errorProvider5.Clear();

                    txtAdi.Enabled = true;
                    txtSoyadi.Enabled = true;
                    txtTelno.Enabled = true;
                    txtAdres.Enabled = true;
                    errorProvider8.SetError(txtTcno, "");
                }
            }

           
        }

        private void txtTcno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece sayi girişi
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTelno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece sayi girişi
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ogrenciguncelleme_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 100);//Form ekranın açılınca yernini belirleme Point(x,y)
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

            errorProvider6.BlinkRate = 400;
            errorProvider6.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;

            errorProvider8.BlinkRate = 400;
            errorProvider8.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
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

        private void txtAdi_VisibleChanged(object sender, EventArgs e)
        {
            //if (txtAdi.Text.Trim() == "")//eğer TextBox1 boş ise
            //{
            //    errorProvider2.SetError(txtAdi, "Bu alan boş geçilmez");
            //} // ErrorProvider açılacak ve
            ////üstteki satırda belirtilen msj çıkacak
            //else
            //{
            //    errorProvider2.SetError(txtAdi, "");
            //}// ErrorProvider kapanacak
        }

        private void txtSoyadi_VisibleChanged(object sender, EventArgs e)
        {
            //if (txtSoyadi.Text.Trim() == "")//eğer TextBox1 boş ise
            //{
            //    errorProvider3.SetError(txtSoyadi, "Bu alan boş geçilmez");
            //} // ErrorProvider açılacak ve
            ////üstteki satırda belirtilen msj çıkacak
            //else
            //{
            //    errorProvider3.SetError(txtSoyadi, "");
            //}// ErrorProvider kapanacak
        }

        private void txtTelno_VisibleChanged(object sender, EventArgs e)
        {
            //if (txtTelno.Text.Trim() == "")//eğer TextBox1 boş ise
            //{
            //    errorProvider4.SetError(txtTelno, "Bu alan boş geçilmez");
            //} // ErrorProvider açılacak ve
            ////üstteki satırda belirtilen msj çıkacak
            //else
            //{
            //    errorProvider4.SetError(txtTelno, "");
            //}// ErrorProvider kapanacak
        }

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {
            if (txtAdi.Text.Trim() == "")
            {
                errorProvider2.SetError(txtAdi, "Bu alan boş geçilemez");
            }
            else
            {
                errorProvider2.SetError(txtAdi, "");
            }
        }

        private void txtSoyadi_TextChanged(object sender, EventArgs e)
        {
            if (txtSoyadi.Text.Trim() == "")//eğer TextBox1 boş ise
            {
                errorProvider3.SetError(txtSoyadi, "Bu alan boş geçilmez");
            } // ErrorProvider açılacak ve
            //üstteki satırda belirtilen msj çıkacak
            else
            {
                errorProvider3.SetError(txtSoyadi, "");
            }// ErrorProvider kapanacak
        }

        private void txtTelno_TextChanged(object sender, EventArgs e)
        {
            if (txtTelno.Text.Trim() == "")//eğer TextBox1 boş ise
            {
                errorProvider4.SetError(txtTelno, "Bu alan boş geçilmez");
            } // ErrorProvider açılacak ve
            //üstteki satırda belirtilen msj çıkacak
            else
            {
                errorProvider4.SetError(txtTelno, "");
            }// ErrorProvider kapanacak
            if ((txtTelno.Text.Length < 10) || (txtTelno.Text.Length > 10))
            {
                errorProvider6.SetError(txtTelno, "Telefon numarısı 10 haneli olmalıdır. Örneğin : (5340829924)");
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void panel2_VisibleChanged(object sender, EventArgs e)
        {
          
        }
    }
}
