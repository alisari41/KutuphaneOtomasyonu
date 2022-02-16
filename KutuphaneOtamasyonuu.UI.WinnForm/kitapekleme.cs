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
    public partial class kitapekleme : Form
    {
        public kitapekleme()
        {
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.Borkodno = txtbarkod.Text;
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

                MessageBox.Show("Lütfen Kitap adeti alanını boş bırakmayınız.Sayısal değer giriniz.", "FormatException HATASI",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            KitapBLL bll = new KitapBLL();
            try
            {//eger burada hata alırsan cathdeki blogta yazılan mesaj bana hata vermesini göstercek
                int ekleme;
                ekleme = bll.AddNewItem(kitap);
                if (ekleme == 1)
                {
                    MessageBox.Show("Kitap kaydı başarılya oluşturuldu.","Başarılı Kayıt");
                }
            }
            catch (OleDbException ex)
            {
                if (ex.ErrorCode == -2147467259)
                {
                    MessageBox.Show("Girmiş olduğunuz barkod numarası kullanılmaktadır.","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtbarkod.Clear();
            txtkitapadi.Clear();
            txtrafno.Clear();
            txtsayfasayisi.Clear();
            txtyazar.Clear();
            txtkitapadeti.Clear();
        }

        private void txtbarkod_KeyPress(object sender, KeyPressEventArgs e)
        {//sadece sayi girişi
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtsayfasayisi_KeyPress(object sender, KeyPressEventArgs e)
        {//sadece sayi girişi
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtkitapadeti_KeyPress(object sender, KeyPressEventArgs e)
        {//sadece sayı girişi
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtrafno_KeyPress(object sender, KeyPressEventArgs e)
        {//sadece sayi girişi
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtkitapadi_VisibleChanged(object sender, EventArgs e)
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

        private void txtyazar_VisibleChanged(object sender, EventArgs e)
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

        private void txtsayfasayisi_VisibleChanged(object sender, EventArgs e)
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

        private void txtrafno_VisibleChanged(object sender, EventArgs e)
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

        private void txtkitapadeti_VisibleChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtkitapadeti.Text) <= 0)//eğer TextBox1 boş ise
            {
                errorProvider8.SetError(txtkitapadeti, "Kitap adeti 0'dan büyük olmak zorunda.");
            }// ErrorProvider açılacak ve
            //üstteki satırda belirtilen msj çıkacak
            else
            {
                errorProvider8.Clear();
            }// ErrorProvider kapanacak
        }

        private void kitapekleme_Load(object sender, EventArgs e)
        {
            this.Location = new Point(400, 100);//Form ekranın açılınca yernini belirleme Point(x,y)
            errorProvider1.BlinkRate = 100000;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;

            errorProvider2.BlinkRate = 100000;
            errorProvider2.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;

            errorProvider3.BlinkRate = 100000;
            errorProvider3.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;

            errorProvider4.BlinkRate = 1000000;
            errorProvider4.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;

            errorProvider5.BlinkRate = 1000000;
            errorProvider5.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;

            errorProvider6.BlinkRate = 400;
            errorProvider6.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
        }

        private void txtbarkod_TextChanged(object sender, EventArgs e)
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
            if (txtkitapadeti.Text.Trim() == "")//eğer TextBox1 boş ise
            {
                errorProvider6.SetError(txtkitapadeti, "Bu alan boş geçilemez");
            } // ErrorProvider açılacak ve
            //üstteki satırda belirtilen msj çıkacak
            else
            {
                errorProvider6.SetError(txtkitapadeti, "");
            }// ErrorProvider kapanacak
            if(txtkitapadeti.Text=="0" || txtkitapadeti.Text == "")
            {
                errorProvider8.SetError(txtkitapadeti, "Kitap adeti 0'dan büyük olmak zorunda.");
            }
            //else if (Convert.ToInt32(txtkitapadeti.Text) <= 0)//eğer TextBox1 boş ise
            //{
                
            //}// ErrorProvider açılacak ve
            ////üstteki satırda belirtilen msj çıkacak
            else
            {
                errorProvider8.SetError(txtkitapadeti, "");
            }// ErrorProvider kapanacak
        }
    }
}
