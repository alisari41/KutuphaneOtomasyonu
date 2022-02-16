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
    public partial class Kitabıteslimalanidaeedenlerinlistesi : Form
    {
        public Kitabıteslimalanidaeedenlerinlistesi()
        {
            InitializeComponent();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            Kitapver kitapver = new Kitapver();
            kitapver.Barkodno = txtbarkodno.Text;
            KitapverBLL bll = new KitapverBLL();
            Kitapiade kitapiade = new Kitapiade();
            KitapiadeBLL bll2 = new KitapiadeBLL();
            kitapiade.Barkodno = txtbarkodno.Text;
            if (txtbarkodno.Text == "")
            {
                MessageBox.Show("Lütfen geçmişte alındığı kitapları görmek istediğiniz kitabın barkod numarasını giriniz.", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if ((bll.KitaapBarkodNoArama(kitapver).Count <= 0) && (bll2.KitaapBarkodNoArama(kitapiade).Count <= 0))
                {
                    MessageBox.Show("Daha önce herhangi bir öğrenci bu  kitabı almamıştır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {//eğer kitap alındıysa listele
                    dataGridView1.DataSource = bll.KitaapBarkodNoArama(kitapver);
                    dataGridView2.DataSource = bll2.KitaapBarkodNoArama(kitapiade);
                }                
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                TimeSpan zamanfarki = DateTime.Now - Convert.ToDateTime(dataGridView1.Rows[i].Cells["Teslimtarihi"].Value.ToString());
                double gun = zamanfarki.TotalDays;
                if (gun > 0.0)//Teslim tarihi geçmiş ise
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else if ((gun <= 0) && (gun >= -2))//eger teslim tarihine iki gün var ise 
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {//teslim edilmiş kitaplar
                dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.Green;
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            txtbarkodno.Clear();
        }

        private void txtbarkodno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece sayi girişi
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtbarkodno_TextChanged(object sender, EventArgs e)
        {
            if (txtbarkodno.Text.Trim() == "")//eğer txtbarkodno boş ise
            {
                errorProvider1.SetError(txtbarkodno, "Bu alan boş geçilmez");
            } // ErrorProvider açılacak ve
            //üstteki satırda belirtilen msj çıkacak
            else
            {
                errorProvider1.SetError(txtbarkodno, "");
            }// ErrorProvider kapanacak
        }

        private void txtbarkodno_VisibleChanged(object sender, EventArgs e)
        {
            if (txtbarkodno.Text.Trim() == "")//eğer TextBox1 boş ise
            {
                errorProvider1.SetError(txtbarkodno, "Bu alan boş geçilmez");
            } // ErrorProvider açılacak ve
            //üstteki satırda belirtilen msj çıkacak
            else
            {
                errorProvider1.SetError(txtbarkodno, "");
            }// ErrorProvider kapanacak

        }

        private void Kitabıteslimalanidaeedenlerinlistesi_Load(object sender, EventArgs e)
        {
            this.Location = new Point(100, 100);//Form ekranın açılınca yernini belirleme Point(x,y)
            errorProvider1.BlinkRate = 100000;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;

            errorProvider2.BlinkRate = 400;
            errorProvider2.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
        }
    }
}
