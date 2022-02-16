using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using KutuphaneOtamasyonuu.Entity;//bunu ekliyorum entityi kullanmak için



namespace KutuphaneOtamasyonuu.DAL
{
    public class OgrenciDAL
    {
        private accessconnection Accessconnection;
        //new acceesscone.... yapma yapıcı metod altında yapılırmış
        public OgrenciDAL()
        {
            Accessconnection = new accessconnection();
        }
        public List<Ogrenci> GetAllItems()///dalın entity yi referans alması lazım
        {//datatable üzerinde veriileri çekiyorum
            OleDbCommand cmd = Accessconnection.GetOleDbCommand();//bağlantı hazır komut yazılmadı daha
            cmd.CommandText = "select * from Ogrenci";

            List<Ogrenci> ogrencis = new List<Ogrenci>();//entity de oluşturduğum class ismi
            OleDbDataReader rdr = cmd.ExecuteReader();
            //cmd nesnesini çalıştırıp daha sonra dönüp tekeer teker okuyup bu kullanicigirisi listesini doldurmamız gerekiyor

            while (rdr.Read())
            {//bütün tablodaki kolonları(alanları) kullaniicgirisi classımın alanlarına koydum
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.TcNo = rdr["TcNo"].ToString();
                ogrenci.Adi = rdr["Adi"].ToString();
                ogrenci.Soyadi = rdr["Soyadi"].ToString();
                ogrenci.TelefonNo = rdr["TelefonNo"].ToString();
                ogrenci.Adres = rdr["Adres"].ToString();
                ogrenci.Borc = Convert.ToInt32(rdr["Borc"]);

                ogrencis.Add(ogrenci);
                //int conver.toin() içine yazılır
            }
            return ogrencis;//listeyi geriye döndermiş oldum
        }
        public List<Ogrenci> TxtSearchDuzenleme(Ogrenci ogrenci)
        {//bunu txtboxların içini direk güncelleme yapmak istediği şeyi doldurması için getirdim
            OleDbCommand cmd = Accessconnection.GetOleDbCommand();//bağlantı hazır komut yazılmadı daha
            cmd.CommandText = "select * from Ogrenci";
            List<Ogrenci> ogrencis = new List<Ogrenci>();//entity de oluşturduğum class ismi
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (ogrenci.TcNo == rdr["TcNo"].ToString())
                {
                    ogrenci.Adi = rdr["Adi"].ToString();
                    ogrenci.Soyadi = rdr["Soyadi"].ToString();
                    ogrenci.TelefonNo = rdr["TelefonNo"].ToString();
                    ogrenci.Adres = rdr["Adres"].ToString();
                    ogrenci.Borc=Convert.ToInt32(rdr["Borc"]);//kullanmıyorum txt lerde fakat kullanırsam diye yaptım
                    ogrencis.Add(ogrenci);
                    break;
                }
            }
            return ogrencis;
        }
        public int AddNewItem(Ogrenci ogrenci)
        {
            string cmdText = "INSERT INTO [Ogrenci] ([TcNo],[Adi],[Soyadi],[TelefonNo],[Adres])";
            cmdText += String.Format(" Values('{0}','{1}','{2}','{3}','{4}')", ogrenci.TcNo, ogrenci.Adi, ogrenci.Soyadi, ogrenci.TelefonNo,ogrenci.Adres);
            OleDbCommand cmd = Accessconnection.GetOleDbCommand();
            cmd.CommandText = cmdText;
            return cmd.ExecuteNonQuery();//eğer çalışırsa değeri 0 dünmez 1 döner
        }
        public int DeleteItem(Ogrenci ogrenci)
        {
            OleDbCommand cmd = Accessconnection.GetOleDbCommand();
            cmd.CommandText = string.Format("Delete From Ogrenci where TcNo='" + ogrenci.TcNo + "'");
            return cmd.ExecuteNonQuery();
        }
        public int UpdateItem(Ogrenci ogrenci)
        {
            //Eğer öğrencinin bilgilerini güncelleştiriyorsa kitapiadede ve kitapver tablosundada güncellemesi lazım o yüzden cmd2 ve cmd3 ü yazdım
            OleDbCommand cmd = Accessconnection.GetOleDbCommand();
            OleDbCommand cmd2 = Accessconnection.GetOleDbCommand();
            OleDbCommand cmd3 = Accessconnection.GetOleDbCommand();
            cmd.CommandText = string.Format("Update Ogrenci set  Adi='" + ogrenci.Adi+ "',Soyadi='" + ogrenci.Soyadi+ "',TelefonNo='" + ogrenci.TelefonNo+ "',Adres='" + ogrenci.Adres + "'where TcNo='" + ogrenci.TcNo+ "'");
            cmd2.CommandText = string.Format("Update Kitapver set  Adi='" + ogrenci.Adi + "',Soyadi='" + ogrenci.Soyadi + "',Telefon='" + ogrenci.TelefonNo + "',Adres='" + ogrenci.Adres + "'where Tcno='" + ogrenci.TcNo + "'");
            cmd3.CommandText = string.Format("Update Kitapiade set  Adi='" + ogrenci.Adi + "',Soyadi='" + ogrenci.Soyadi + "',Telefon='" + ogrenci.TelefonNo + "',Adres='" + ogrenci.Adres + "'where Tcno='" + ogrenci.TcNo + "'");
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            return cmd.ExecuteNonQuery();
        }
        public int BorcUpdateItem()
        {//guncellemeyi sona bıraktım unutmaaaaaa
         //OleDbCommand cmd = Accessconnection.GetOleDbCommand();//tabloyu getirdim okuma işlmei yapıcam
         //OleDbCommand cmd2 = Accessconnection.GetOleDbCommand();//tabloya yazma işlemi yapıcam
         //cmd.CommandText = "select * from Ogrenci where TcNo='"+ogrenci.TcNo+"'";
         //OleDbDataReader rdr = cmd.ExecuteReader();
         //if(rdr.Read())//sadece bir veriyi okuma için yaptım
         //{        ogrenci.Borc = Convert.ToInt32(rdr["Borc"]) + Convert.ToInt32(ogrenci.Borc);
         //        cmd2.CommandText = string.Format("Update Ogrenci set Borc='" + ogrenci.Borc + "'where TcNo='" + ogrenci.TcNo + "'");
         //}
            OleDbCommand cmd4 = Accessconnection.GetOleDbCommand();
            //buradaki komutu çıkarmak için çok deneme yaptım accessde deneme veri tabanı oluşturduğum tablolara sorgu yaparak bu sonucu elde ettim
            //bunu elde etmeden önce borc hesaplarken ççooookkk zaman kaybı yaşıyordum buradaki teslim tarihi datetime şeklinde
            // burada tek tablo içinde veri aramıyorum o zaman kolaydı fakat iki tablo içinde birinde veri arayıp diğerinde güncelleme yapmak zordu 
            // uzun uzun bay deneme yaparak bu kodu çıkardım ve çalıştı 
            // bu komutta teslim tarihine bakıyorum teslim tarihi geçmişse(bugünden küçükse) Ogrenci tablosunda Borc alanına bugünün tarihi-teslim edilecek tarih + Borcu
            // + Borc yapmamım sebebi belki bir öğreinci birden fazla kitap almış olabilir.
            //bu komut sayesinde zamandan tesatüf ettim diğer türlü en az 2 wihle kullanıyordum 
            //görüldüğü gibi açıklama satırları ne kadar fazla oysaki tek satır bütün işlmei çözüyor
            cmd4.CommandText = "update Ogrenci AS o, Kitapver AS k  set Borc=Borc+Date()-k.TeslimTarihi   where Teslimtarihi<#" + DateTime.Now.ToString("yyyy/MM/dd").Replace('.', '/') + "# and k.Tcno=o.Tcno";
            return cmd4.ExecuteNonQuery();

            {   /* BAŞTA BUNU YAPTIM FAKAT ZAMANDAN ÇOK KAYBETTİM SONRA TEK VERİ OKUDUM*/                
                //OleDbCommand cmd2 = Accessconnection.GetOleDbCommand();//tabloya yazma işlemi yapıcam
                //cmd.CommandText = "select * from Ogrenci ";
                //OleDbDataReader rdr = cmd.ExecuteReader();
                //while (rdr.Read())
                //{ 
                //    if ((Convert.ToInt32(rdr["Borc"]) > 0) && (rdr["TcNo"].ToString() == ogrenci.TcNo))
                //    {
                //        ogrenci.Borc = Convert.ToInt32(rdr["Borc"]) + Convert.ToInt32(ogrenci.Borc);
                //        cmd2.CommandText = string.Format("Update Ogrenci set Borc='" + ogrenci.Borc + "'where TcNo='" + ogrenci.TcNo + "'");
                //        // cmd.ExecuteNonQuery();
                //    }
                //    else
                //    {
                //        cmd2.CommandText = string.Format("Update Ogrenci set Borc='" + ogrenci.Borc + "'where TcNo='" + ogrenci.TcNo + "'");
                //        // cmd.ExecuteNonQuery();
                //    }
                //}
            }            
        }
        public int BorcUpdateSifirlama()
        {
            OleDbCommand cmd = Accessconnection.GetOleDbCommand();
            cmd.CommandText = "update Ogrenci   set Borc=0  where Borc >" + 0;
            return cmd.ExecuteNonQuery();
        }

    }
}
