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

namespace KutuphaneOtamasyonuu.UI.WinnForm
{
    public partial class ogrencisilme : Form
    {
        public ogrencisilme()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((txtsilme.Text.Length < 11) || (txtsilme.Text.Length > 11))
            {
                errorProvider1.SetError(txtsilme, "TC Kimlik numarısı 11 karakterli olmalıdır.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.TcNo = txtsilme.Text;
            OgrenciBLL bll = new OgrenciBLL();
            
            
            try
            {//eger burada hata alırsan cathdeki blogta yazılan mesaj bana hata vermesini göstercek
                int sayi;
                sayi = bll.DeleteItem(ogrenci);
                if(sayi==1)
                {
                    MessageBox.Show(ogrenci.TcNo+" TC kimlik numaralı Öğrenci silinmiştir.","Silme işlemi gerçekleşti", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtsilme_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece sayi girişi
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ogrencisilme_Load(object sender, EventArgs e)
        {
            this.Location = new Point(60, 160);//Form ekranın açılınca yernini belirleme Point(x,y)
        }
    }
}
