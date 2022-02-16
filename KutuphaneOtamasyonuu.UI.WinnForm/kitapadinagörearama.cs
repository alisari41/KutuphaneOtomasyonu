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
    public partial class kitapadinagörearama : Form
    {
        public kitapadinagörearama()
        {
            InitializeComponent();
        }

        private void btnarama_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.Kitapadi = txtkitapadi.Text;
            KitapBLL bll = new KitapBLL();
            try
            {//eger burada hata alırsan cathdeki blogta yazılan mesaj bana hata vermesini göstercek
                dataGridView1.DataSource = bll.KitapAdiArama(kitap);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            txtkitapadi.Clear();
        }

        private void kitapadinagörearama_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 100);//Form ekranın açılınca yernini belirleme Point(x,y)
        }
    }
}
