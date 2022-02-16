using System;
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
using System.Data.OleDb;
using Tulpep.NotificationWindow;

namespace KutuphaneOtamasyonuu.UI.WinnForm
{
    public partial class kullaniciuyeol : Form
    {
        public kullaniciuyeol()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKullaniciadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanicigirisi Kullanicigirisi = new kullanicigirisi();
            //önce textboxları değişkenlere atıyorum herhangi bir değişiklik yaptığımda kolay olsun 
            //tablodaki değişkenlerle aynı olacak dikkat et
            Kullanicigirisi.Kullaniciadi = txtKullaniciadi.Text;
            Kullanicigirisi.Sifre = txtSifre.Text;
            Kullanicigirisi.Adi = txtAdi.Text;
            Kullanicigirisi.Soyadi = txtsoyadi.Text;

            kullanicigirisiBLL bll = new kullanicigirisiBLL();
            try
            {//eger burada hata alırsan cathdeki blogta yazılan mesaj bana hata vermesini göstercek
                string kullaniciadisoyadi = bll.AddNewItem(Kullanicigirisi);
                if (kullaniciadisoyadi != "")
                {
                    MessageBox.Show("Kaydınız başarılya oluşturuldu.","ÜYE KAYIT");
                    PopupNotifier popup = new PopupNotifier();
                    popup.Image = Properties.Resources.userana;
                    popup.ImagePadding = new Padding(5);
                    popup.TitleText = "yeni üye kaydı.".ToUpper().PadLeft(1);
                    popup.TitleColor = Color.Green;//başlık yazı rengi


                    popup.HeaderHeight = 025;
                    popup.HeaderColor = Color.Green;//başlık  rengi
                    popup.ContentHoverColor = Color.Yellow;//
                    popup.TitleFont = new Font("Segoe Script", 12, FontStyle.Bold);// Font("Yazı tipi",boyutu,şekli); 
                    popup.ContentFont = new Font("Cooper Black", 14, FontStyle.Regular);// Font("Yazı tipi",boyutu,şekli); 

                    popup.ContentText = kullaniciadisoyadi.PadLeft(1);
                    popup.BorderColor = Color.Yellow;//mesajın dış çepesi çercevesi
                    popup.BodyColor = Color.Black;//mesajın içi
                    popup.ContentColor = Color.Green;//text yazı rengi

                    popup.ContentHoverColor = Color.Black;
                    popup.TitlePadding = new Padding(3, 12, 5, 3);//sol , yukarı, aşağı sağ
                    popup.ContentPadding = new Padding(5, 0, 0, 0);
                    //  popup.BodyColor = Color.Red;
                    popup.Popup();
                    Form kullanicigiriisi = new Kullanicigirisi();
                    kullanicigiriisi.Show();
                    this.Hide();
                }
            }
            catch (OleDbException ex)
            {
                if (ex.ErrorCode == -2147467259)
                {
                    MessageBox.Show("Girmiş olduğunuz kullanıcı adı kullanılmaktadır.", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {// Çıkış butonuna tıklanırsa uye ol formunu kapatıyorum kullanıcıgiriş formunu açıyorum.
            this.Close();
            Form kitapg = new Kullanicigirisi();
            kitapg.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form kullanicigirisekrani = new Kullanicigirisi();
            kullanicigirisekrani.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form kullanicigirisekrani = new Kullanicigirisi();
            kullanicigirisekrani.Show();
            this.Hide();
        }

        private void kullaniciuyeol_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtKullaniciadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //boşluk girişini engeller
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //boşluk girişini engeller
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
        }

        private void kullaniciuyeol_Load(object sender, EventArgs e)
        {
            this.Location = new Point(260, 150);//Form ekranın açılınca yernini belirleme Point(x,y)
        }
    }
}
