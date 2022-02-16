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
using System.Diagnostics;

namespace KutuphaneOtamasyonuu.UI.WinnForm
{
    public partial class ogrencilistele : Form
    {
        public ogrencilistele()
        {
            InitializeComponent();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            OgrenciBLL bll = new OgrenciBLL();
            dataGridView1.DataSource = bll.GetAllItems();

            //bll.getallitems bll e gidicek bll DAL a gidicek sonra verilerim gelicek 
            //o yüzden form BLL bağlanır hemde güvenlik
        }

        private void ogrencilistele_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 100);//Form ekranın açılınca yernini belirleme Point(x,y)
        }
    }
}
