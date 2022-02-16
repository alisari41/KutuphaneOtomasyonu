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
    public partial class kitaplistele : Form
    {
        public kitaplistele()
        {
            InitializeComponent();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {

        }
        

        private void kitaplistele_Load(object sender, EventArgs e)
        {
            this.Location = new Point(250, 60);//Form ekranın açılınca yernini belirleme Point(x,y)
            KitapBLL bll = new KitapBLL();            
            dataGridView1.DataSource = bll.GetAllItems();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }
    }
}
