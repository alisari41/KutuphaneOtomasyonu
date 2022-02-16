using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneOtamasyonuu.BLL;
using KutuphaneOtamasyonuu.Entity;

namespace KutuphaneOtamasyonuu.UI.WinnForm
{
    public partial class kitapsilme : Form
    {
        public kitapsilme()
        {
            InitializeComponent();
        }

        private void btnsilme_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.Borkodno = txtbarkodno.Text;
            KitapBLL bll = new KitapBLL();
            try
            {//eger burada hata alırsan cathdeki blogta yazılan mesaj bana hata vermesini göstercek
                bll.DeleteItem(kitap);
                MessageBox.Show("Kütüphanemizden ("+kitap.Borkodno+ ") barkod numaralı kitap silinmiştir.","Silme işlemi başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtbarkodno_KeyPress(object sender, KeyPressEventArgs e)
        {            //sadece sayi girişi
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void kitapsilme_Load(object sender, EventArgs e)
        {
            this.Location = new Point(100, 200);//Form ekranın açılınca yernini belirleme Point(x,y)
        }
    }
}
