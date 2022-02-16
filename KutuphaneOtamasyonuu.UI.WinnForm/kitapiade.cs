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
    public partial class kitapiade : Form
    {
        public kitapiade()
        {
            InitializeComponent();
        }

        

        private void btniade_Click(object sender, EventArgs e)
        {
            Kitapver kitapver2 = new Kitapver();
            kitapver2.Barkodno = txtbarkodver.Text;
            kitapver2.Tcno =txtTcno.Text;
            KitapverBLL bll5 = new KitapverBLL();
            bll5.TxtSearchDuzenleme(kitapver2);
            Kitapiade kitapiade = new Kitapiade();
            kitapiade.Tcno = txtTcno.Text;
            kitapiade.Adi = txtAdi.Text;
            kitapiade.Soyadi = txtSoyadi.Text;
            kitapiade.Telefon = txtTelno.Text;
            kitapiade.Adres = txtAdres.Text;
            kitapiade.Barkodno = txtbarkodver.Text;
            kitapiade.Kitapadi = txtkitapadi.Text;
            kitapiade.Yazari = txtyazar.Text;
            kitapiade.Sayfasayi = txtyazar.Text;
            kitapiade.Rafno = txtrafno.Text;
            kitapiade.Verilistarihi = kitapver2.Verilistarihi;
            kitapiade.Iadetarihi = dtpteslimtarih.Value;
            Kitapver kitapvers = new Kitapver();
            //önce textboxları değişkenlere atıyorum herhangi bir değişiklik yaptığımda kolay olsun 
            kitapvers.Tcno = txtTcno.Text;
            kitapvers.Barkodno = txtbarkodver.Text;
            KitapiadeBLL bll2 = new KitapiadeBLL();
            try
            {//eger burada hata alırsan cathdeki blogta yazılan mesaj bana hata vermesini göstercek
                bll2.AddNewItem(kitapiade);//kitap iade tablosuna öğrencinin bilgileri kitap bilgileri teslim edilen tarhi girilir.
                MessageBox.Show("Teslim işlemi gerçekleşti.","Başarılı");
                KitapverBLL bllkitapver = new KitapverBLL();                
                Kitap kitap = new Kitap();
                kitap.Borkodno = txtbarkodver.Text;
                KitapBLL bll3 = new KitapBLL();
                bll3.UpdateKitapadetiarttir(kitap);//kitabı geri teslim ettiyse Kitabın Adeti artar
                bllkitapver.DeleteItem(kitapvers);//Kitabı teslim ettiği için kitapver tablosunda silinir.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtAdi.Clear();
            txtAdres.Clear();
            txtbarkodver.Clear();
            txtkitapadi.Clear();
            txtrafno.Clear();
            txtsayfasayisi.Clear();
            txtSoyadi.Clear();
            txtTcno.Clear();
            txtTelno.Clear();
            txtyazar.Clear();
            dtpteslimtarih.CustomFormat = " "; 
        }

        private void txtbarkod_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtTcno_TextChanged_1(object sender, EventArgs e)
        {
            if (txtTcno.Text.Trim() == "")//eğer txtTcno boş ise
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
                bll.TxtSearchDuzenleme(ogrenci);//eğer girilen tc 11 haneli ise bilgileri getir
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
                    errorProvider8.SetError(txtTcno, "");
                }
            }
        }

        private void txtbarkod_TextChanged_1(object sender, EventArgs e)
        {
            if (txtbarkodver.Text.Trim() == "")//eğer txtbarkodver boş ise
            {
                errorProvider2.SetError(txtbarkodver, "Bu alan boş geçilemez");
                txtkitapadi.Clear();
                txtyazar.Clear();
                txtsayfasayisi.Clear();
                txtrafno.Clear();
            } 
            else
            {
                Kitapver kitapver = new Kitapver();
                kitapver.Barkodno = txtbarkodver.Text;
                kitapver.Tcno = txtTcno.Text;
                KitapverBLL bll = new KitapverBLL();
                bll.TxtSearchDuzenleme(kitapver);//eğer öğrenci bu kitabı aldıysa bu kitabın bilgilerini getir
                txtkitapadi.Text = kitapver.Kitapadi;
                txtyazar.Text = kitapver.Yazari;
                txtsayfasayisi.Text = kitapver.Sayfasayi;
                txtrafno.Text = kitapver.Rafno;

                errorProvider2.SetError(txtbarkodver, "");

                if ((txtkitapadi.Text.Trim() == "") && (txtyazar.Text.Trim() == "") && (txtsayfasayisi.Text.Trim() == "") && (txtrafno.Text.Trim() == ""))
                {
                    errorProvider8.SetError(txtbarkodver, "Öğrenci girdiğniz barkod numaralı kitabı almamıştır.Geri teslim işlemi gerçekleştiremez.");
                }
                else
                {
                    errorProvider8.SetError(txtbarkodver, "");
                }
            }
        }

        private void txtTcno_KeyPress(object sender, KeyPressEventArgs e)
        {//sadece sayi girişi
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtbarkodver_KeyPress(object sender, KeyPressEventArgs e)
        {//sadece sayi girişi
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

        private void txtbarkodver_VisibleChanged(object sender, EventArgs e)
        {
            if (txtbarkodver.Text.Trim() == "")//eğer TextBox1 boş ise
            {
                errorProvider2.SetError(txtbarkodver, "Bu alan boş geçilemez");
            } // ErrorProvider açılacak ve
            //üstteki satırda belirtilen msj çıkacak
            else
            {
                errorProvider2.SetError(txtbarkodver, "");
            }// ErrorProvider kapanacak
        }

        private void kitapiade_Load(object sender, EventArgs e)
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
    }
}
