using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using KutuphaneOtamasyonuu.Entity;

namespace KutuphaneOtamasyonuu.DAL
{
    public class KitapDAL
    {
        private accessconnection Accessconnection;
        //new acceesscone.... yapma yapıcı metod altında yapılırmış
        public KitapDAL()
        {
            Accessconnection = new accessconnection();
        }
        //Bütün Kitapları listeme(veri tabanından burdan çekilir)
        public List<Kitap> GetAllItems()///dalın entity yi referans alması lazım
        {
            OleDbCommand cmd = Accessconnection.GetOleDbCommand();//bağlantı hazır komut yazılmadı daha
            cmd.CommandText = "select * from Kitap";
            List<Kitap> kitaps = new List<Kitap>();//entity de oluşturduğum class ismi
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Kitap kitap= new Kitap();
                kitap.Borkodno = rdr["Borkodno"].ToString();
                kitap.Kitapadi = rdr["Kitapadi"].ToString();
                kitap.Yazari = rdr["Yazari"].ToString();
                kitap.Sayfasayisi = rdr["Sayfasayisi"].ToString();
                kitap.Rafno = rdr["Rafno"].ToString();
                kitap.Kitapadeti = Convert.ToInt16(rdr["Kitapadeti"]);
                kitaps.Add(kitap);
            }
            return kitaps;//listeyi geriye döndermiş oldum
        }
        public Tuple<string[], string[],double[]> Grafik()//grafik için adı barkodnumarası ve adeti için birden fazla dizi dönderiyorum
        { 
            OleDbCommand cmd = Accessconnection.GetOleDbCommand();
            cmd.CommandText = "select * from Kitap";
            OleDbDataReader rdr = cmd.ExecuteReader();
            OleDbCommand cmd2 = Accessconnection.GetOleDbCommand();
            cmd2.CommandText = "select * from Kitap";
            OleDbDataReader rdr2 = cmd2.ExecuteReader();
            double[] grafikKitapAdetleri = new double[20];//kitap adetlerini tutuyorum 
            string[] grafikBarkodnumarasi = new string[20];//barkodnumaralarını tutuyorum
            string[] grafikKitapadi = new string[20];//kitap adlarını tutuyorum
            int  kitapadetlerii = 0;//kütüphande birde fazla kitap olduğu için bilgileri dizinin indislerine atayabilmek için bunu dizi indisi olarak kullandım.
            while (rdr.Read())
            {//elimizde olan kitap adetleri yani verilmeye hazır kitaplar
                grafikBarkodnumarasi[kitapadetlerii] = rdr["Borkodno"].ToString();//barkodnumarasınıa göre adetleri getirmek görüntü açısı daha iyi
                grafikKitapadi[kitapadetlerii] = rdr["Kitapadi"].ToString();//kitap adına göre getirme üstüne getirerek kitap adı adetinden kaç tane olduğu gözükür
                grafikKitapAdetleri[kitapadetlerii] = Convert.ToDouble(rdr["Kitapadeti"].ToString());
                kitapadetlerii++;
            }
            int kitapadetlerii2 = 0;//bu değişkeni kullanmamım sebebi öğrencilere verilmiş kitab var mı var ise o kitabıın kaç tanesi öğrenciye verildiği bulunur sonrasında o kitabın kütüphandeki taoplam kitap adeti bulunur.
            while (rdr2.Read())
            {//kitap tablosundaki adetler saydı şimdi bu kitaba ait barkod numarasını alanlar kaç tane adetini bulup toplam kitap sayısını buluyorum
                OleDbCommand cmd3 = Accessconnection.GetOleDbCommand();
                cmd3.CommandText = "select * from Kitapver where Barkodno='" + rdr2["Borkodno"].ToString() + "'";
                OleDbDataReader rdr3 = cmd3.ExecuteReader();
                int alinmiskitapsayisi = 0;
                while (rdr3.Read())
                {//barkodnumarası aynı olanları say yani kitap tablosundaki barkodnumarasını kaç kişi kişi aldıysa toplam kitap sayısını arttır.
                    alinmiskitapsayisi++;
                }
                grafikKitapAdetleri[kitapadetlerii2] += alinmiskitapsayisi;//kitap tablosunda boşta kitap adetine o kitabın kaç tanesi öğrencilere vverilmiş onu kitap adetine ekler ve o kitapdan kaç tane olduğunu bulurum.
                kitapadetlerii2++;
            }
            return  Tuple.Create(grafikKitapadi, grafikBarkodnumarasi,grafikKitapAdetleri);//birden fazla dizi dönderiyorum
        }
       
        //Gelen barkodnumarasına göre veritabanından kitap bilgilerini listede tutuyorum
        public List<Kitap> Arama(Kitap kitap)
        {
            OleDbCommand cmd = Accessconnection.GetOleDbCommand();
            cmd.CommandText = "select * from Kitap";
            List<Kitap> kitaps = new List<Kitap>();//entity de oluşturduğum class ismi
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if(kitap.Borkodno==rdr["Borkodno"].ToString())
                {
                    kitap.Borkodno = rdr["Borkodno"].ToString();
                    kitap.Kitapadi = rdr["Kitapadi"].ToString();
                    kitap.Yazari = rdr["Yazari"].ToString();
                    kitap.Sayfasayisi = rdr["Sayfasayisi"].ToString();
                    kitap.Rafno = rdr["Rafno"].ToString();
                    kitap.Kitapadeti = Convert.ToInt16(rdr["Kitapadeti"]);

                    kitaps.Add(kitap);
                }
            }
            return kitaps;//listeyi geriye döndermiş oldum
        }

        //Gelen kitap adına göre veritabanından kitap bilgilerini listede tutuyorum
        public List<Kitap> KitapAdiArama(Kitap kitap)
        {//datatable üzerinde veriileri çekiyorum
            OleDbCommand cmd = Accessconnection.GetOleDbCommand();//bağlantı hazır komut yazılmadı daha
            cmd.CommandText = "select * from Kitap";
            List<Kitap> kitaps = new List<Kitap>();//entity de oluşturduğum class ismi
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {//Dışardan gelen kitapadi tablomda var mı diye kontrol ediyorum var ise oluşturduğum listeme ekliyorum.
                if (kitap.Kitapadi == rdr["Kitapadi"].ToString())
                {
                    kitap.Borkodno = rdr["Borkodno"].ToString();
                    kitap.Kitapadi = rdr["Kitapadi"].ToString();
                    kitap.Yazari = rdr["Yazari"].ToString();
                    kitap.Sayfasayisi = rdr["Sayfasayisi"].ToString();
                    kitap.Rafno = rdr["Rafno"].ToString();
                    kitap.Kitapadeti = Convert.ToInt16(rdr["Kitapadeti"]);

                    kitaps.Add(kitap);
                }
            }
            return kitaps;//listeyi geriye döndermiş oldum
        }

        public List<Kitap> TxtSearchDuzenleme(Kitap kitap)
        {//bunu txtboxların içini direk güncelleme yapmak istediği şeyi doldurması için getirdim
            OleDbCommand cmd = Accessconnection.GetOleDbCommand();//bağlantı hazır komut yazılmadı daha
            cmd.CommandText = "select * from Kitap";
            List<Kitap> kitaps = new List<Kitap>();//entity de oluşturduğum class ismi
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {//gelen barkod numarası tablodaki ile aynı ise nesnemdeki değişkenlere tablomdaki verileri ata.sonra oluşturduğum listeme nesnemi ata en son listemi dönder
                if (kitap.Borkodno == rdr["Borkodno"].ToString())
                {
                    kitap.Borkodno = rdr["Borkodno"].ToString();
                    kitap.Kitapadi = rdr["Kitapadi"].ToString();
                    kitap.Yazari = rdr["Yazari"].ToString();
                    kitap.Sayfasayisi = rdr["Sayfasayisi"].ToString();
                    kitap.Rafno = rdr["Rafno"].ToString();
                    kitap.Kitapadeti = Convert.ToInt16(rdr["Kitapadeti"]);
                    kitaps.Add(kitap);
                    break;
                }
            }
            return kitaps;
        }
        //veritabanına ekleme işlemi yapıyorum
        public int AddNewItem(Kitap kitap)
        {
            string cmdText = "INSERT INTO [Kitap] ([Borkodno],[Kitapadi],[Yazari],[Sayfasayisi],[Rafno],[Kitapadeti])";
            cmdText += String.Format(" Values('{0}','{1}','{2}','{3}','{4}',{5})", kitap.Borkodno, kitap.Kitapadi, kitap.Yazari, kitap.Sayfasayisi,kitap.Rafno,kitap.Kitapadeti);
            OleDbCommand cmd = Accessconnection.GetOleDbCommand();
            cmd.CommandText = cmdText;
            return cmd.ExecuteNonQuery();
        }
        //veritabanından silme işlemi yapıyorum
        public int DeleteItem(Kitap kitap)
        {
            OleDbCommand cmd = Accessconnection.GetOleDbCommand();
            cmd.CommandText = string.Format("Delete From Kitap where Borkodno='" + kitap.Borkodno + "'");           
            return cmd.ExecuteNonQuery();
        }
        public int UpdateItem(Kitap kitap)
        {//Eğer kitap bilgilerini güncelleştiriyorsa kitapiadede ve kitapver tablosundada güncellemesi lazım o yüzden cmd2 ve cmd3 ü yazdım
            OleDbCommand cmd = Accessconnection.GetOleDbCommand(); 
            OleDbCommand cmd2 = Accessconnection.GetOleDbCommand(); 
            OleDbCommand cmd3= Accessconnection.GetOleDbCommand();
            cmd.CommandText = string.Format("Update Kitap set Kitapadeti=" + kitap.Kitapadeti + " , Kitapadi='" + kitap.Kitapadi + "',Yazari='" + kitap.Yazari + "',Sayfasayisi='" + kitap.Sayfasayisi + "',Rafno='" + kitap.Rafno + "' where Borkodno='" + kitap.Borkodno.ToString() + "'");
            cmd2.CommandText = string.Format("Update Kitapver set  Kitapadi='" + kitap.Kitapadi + "',Yazar='" + kitap.Yazari + "',Sayfasayisi='" + kitap.Sayfasayisi + "',Rafno='" + kitap.Rafno + "' where Barkodno='" + kitap.Borkodno.ToString() + "'");
            cmd3.CommandText = string.Format("Update Kitapiade set  Kitapadi='" + kitap.Kitapadi + "',Yazar='" + kitap.Yazari + "',Sayfasayisi='" + kitap.Sayfasayisi + "',Rafno='" + kitap.Rafno + "' where Barkodno='" + kitap.Borkodno.ToString() + "'");
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            return cmd.ExecuteNonQuery();
        }
        public int UpdateKitapadetiazalt(Kitap kitap)
        {//eğer öğrenciye kitap verirsek adetten düşer
            OleDbCommand cmd = Accessconnection.GetOleDbCommand();
            cmd.CommandText = string.Format("Update Kitap set Kitapadeti=Kitapadeti - 1  where Borkodno='" + kitap.Borkodno + "'");
            return cmd.ExecuteNonQuery();
        }
        public int UpdateKitapadetiarttir(Kitap kitap)
        {//eğer öğrenci kitabı geri teslim ederse kitap adeti artar
            OleDbCommand cmd = Accessconnection.GetOleDbCommand();
            cmd.CommandText = string.Format("Update Kitap set Kitapadeti=Kitapadeti + 1 where Borkodno='" + kitap.Borkodno + "'");
            return cmd.ExecuteNonQuery();
        }

    }
}
