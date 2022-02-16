using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneOtamasyonuu.BLL;//sadece BLL ile bağlanır unutma Form için geçerli
using KutuphaneOtamasyonuu.Entity;


namespace KutuphaneOtamasyonuu.UI.WinnForm
{
    public partial class ogrenciekle : Form
    {
        public ogrenciekle()
        {
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
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
                int ekleme;
                ekleme = bll.AddNewItem(ogrenci);
                if (ekleme == 1)
                {
                    MessageBox.Show("Öğrenci başarıyla kaydedildi.","Başarılı kayıt");
                }
            }
            catch (OleDbException ex)
            {
                if (ex.ErrorCode == -2147467259)
                {
                    MessageBox.Show("Girmiş olduğunuz Tc kimlik numaralı öğrenci zaten kayıtlıdır!!!","HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtTcno.Clear();
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTelno.Clear();
            txtAdres.Clear();
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

        private void ogrenciekle_Load(object sender, EventArgs e)
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

            errorProvider5.BlinkRate = 400;
            errorProvider5.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;

            errorProvider6.BlinkRate = 400;
            errorProvider6.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
        }

        private void txtAdi_VisibleChanged(object sender, EventArgs e)
        {
            if (txtAdi.Text.Trim() == "")//eğer TextBox1 boş ise
            {
                errorProvider2.SetError(txtAdi, "Bu alan boş geçilmez");
            } // ErrorProvider açılacak ve
            //üstteki satırda belirtilen msj çıkacak
            else
            {
                errorProvider2.SetError(txtAdi, "");
            }// ErrorProvider kapanacak
        }

        private void txtSoyadi_VisibleChanged(object sender, EventArgs e)
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

        private void txtTelno_VisibleChanged(object sender, EventArgs e)
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
            }
            else
            {
                errorProvider5.Clear();
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
    }
}
