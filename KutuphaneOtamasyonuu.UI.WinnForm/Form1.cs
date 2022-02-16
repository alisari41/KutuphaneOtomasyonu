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

namespace KutuphaneOtamasyonuu.UI.WinnForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls= false;//backgroundWorker1_DoWork kullanmak için yazdım yoksa hata veriyor 
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ogrencie = new ogrenciekle();
            ogrencie.Show();
            
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ogrencis = new ogrencisilme();
            ogrencis.Show();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ogrencig = new ogrenciguncelleme();
            ogrencig.Show();
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ogrencil = new ogrencilistele();
            ogrencil.Show();
        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form kitape = new kitapekleme();
            kitape.Show();
        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form kitaps = new kitapsilme();
            kitaps.Show();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kitapg = new kitapguncelleme();
            kitapg.Show();
        }

        private void listeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form kitapl = new kitaplistele();
            kitapl.Show();
        }

        private void araToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void kitapVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kitapv = new kitapver();
            kitapv.Show();
        }

        private void kitapİadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kitapi = new kitapiade();
            kitapi.Show();
        }

        private void öğrencininAlmışOlduğuKitaplarListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ogrenckitapliste = new ogrencikitaplistele();
            ogrenckitapliste.Show();
        }

        private void barkoNumarasınaGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kitapbarkod = new kitaparama();
            kitapbarkod.Show();
        }

        private void kitapAdınaGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kitapadina = new kitapadinagörearama();
            kitapadina.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(30, 100);//Form ekranın açılınca yernini belirleme Point(x,y)
            backgroundWorker1.RunWorkerAsync();//form1 i aç arkada işlemlerine devam et
                                               //programı hızlandırdım fakat işlemler arkada yapılmaya devam ediyor            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            OgrenciBLL bll2 = new OgrenciBLL();
            bll2.BorcUpdateSifirlama();

            OgrenciBLL bll = new OgrenciBLL();
            bll.BorcUpdateItem();

            ////İlk girişş yaptığımda arkada borcları hesaplıyorum o yüzdem program çok kasıyordu o yüzden 
            //////program arkada çalışırken(verileri öğrenci listesine yazarrken) form açılmasını sağlayan 
            //OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\alisa\\source\\repos\\KutuphaneOtamasyonuu\\kutuphane.accdb");
            //baglanti.Open();
            //OleDbCommand cmd = new OleDbCommand("select * from Kitapver", baglanti);//bunları sadece tabloyu çağırdım okuma yapmak için çağırdım yoksa işlmelerim katmanlı mimaride yapıldı 
            //                                                                        //verilerde katmanlı mimaride alınıp işlendi
            //OleDbDataReader okuyucu = cmd.ExecuteReader();
            //OleDbCommand cmd2 = new OleDbCommand("select * from Ogrenci", baglanti);
            //OleDbDataReader okuyucu2 = cmd2.ExecuteReader();
            //while (okuyucu2.Read())
            //{
            //    Ogrenci ogrenci2 = new Ogrenci();
            //    ogrenci2.TcNo = okuyucu2["TcNo"].ToString();
            //    ogrenci2.Borc = 0;
            //    OgrenciBLL bll2 = new OgrenciBLL();
            //    bll2.BorcUpdateSifirlama(ogrenci2);
            //}
            //while (okuyucu.Read())
            //{
            //    TimeSpan zamanfarki = DateTime.Now - Convert.ToDateTime(okuyucu["Teslimtarihi"].ToString());
            //    double gün = zamanfarki.TotalDays;
            //    if (gün > 0.0)
            //    {//eğer teslim tarihi ile bu gün arasında fark varsa git onu öğrenci tablosuna borc olarak ekle

            //        Ogrenci ogrenci = new Ogrenci();
            //        ogrenci.TcNo = okuyucu["Tcno"].ToString();
            //        ogrenci.Borc = Convert.ToInt32(gün);
            //        OgrenciBLL bll = new OgrenciBLL();
            //        bll.BorcUpdateItem(ogrenci);

            //    }
            //}
            // cmd4.CommandText = string.Format();
            //string tel = "55555532";
            ////  string tc = "12313241231";
            //string tc = "111";
            //OleDbCommand cmd4 = new OleDbCommand();
            //cmd4.Connection = baglanti;
            //DateTime tarih = DateTime.Now;
            //cmd4.CommandText = "update  Kitapver  set Telefon='" + tel + "' where Teslimtarihi<'"  + #31/10/2020# + "'";
            //cmd4.Parameters.AddWithValue("@tarih", DateTime.Now);
            //cmd4.ExecuteNonQuery();
            //baglanti.Close();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Program Kapatılacak Emin siniz?", "Kapatma Uyarısı!", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (Cikis == DialogResult.No)
            {
                Form formekranı = new Form1();
                formekranı.Show();
            }
        }

        private void ögrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void grafiklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form grafik = new KitapAdetleriGrafikGosterimi();
            grafik.Show();
        }

        private void kitabıKmAldıKimTeslimEttiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kitabikimalmis = new Kitabıteslimalanidaeedenlerinlistesi();
            kitabikimalmis.Show();
        }
    }
}
