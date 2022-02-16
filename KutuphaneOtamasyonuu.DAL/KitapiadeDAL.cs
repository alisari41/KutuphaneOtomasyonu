using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using KutuphaneOtamasyonuu.Entity;

namespace KutuphaneOtamasyonuu.DAL
{
     public class KitapiadeDAL
    {
        private accessconnection Accessconnection;
        public KitapiadeDAL()
        {
            Accessconnection = new accessconnection();
        }
        public List<Kitapiade> GetAllItems()
        {//datatable üzerinde veriileri çekiyorum
            OleDbCommand cmd = Accessconnection.GetOleDbCommand();//bağlantı hazır komut yazılmadı daha
            cmd.CommandText = "select * from Kitapiade";




            List<Kitapiade> kitapiades = new List<Kitapiade>();//entity de oluşturduğum class ismi
            OleDbDataReader rdr = cmd.ExecuteReader();
            //cmd nesnesini çalıştırıp daha sonra dönüp tekeer teker okuyup bu kullanicigirisi listesini doldurmamız gerekiyor

            while (rdr.Read())
            {//bütün tablodaki kolonları(alanları) kitapiade classımın alanlarına koydum
                Kitapiade kitapiade = new Kitapiade();
                kitapiade.Tcno = rdr["Tcno"].ToString();
                kitapiade.Adi = rdr["Adi"].ToString();
                kitapiade.Soyadi = rdr["Soyadi"].ToString();
                kitapiade.Telefon = rdr["Telefon"].ToString();
                kitapiade.Adres = rdr["Adres"].ToString();
                kitapiade.Barkodno = rdr["Barkodno"].ToString();
                kitapiade.Kitapadi = rdr["Kitapadi"].ToString();
                kitapiade.Yazari = rdr["Yazar"].ToString();
                kitapiade.Sayfasayi = rdr["Sayfasayisi"].ToString();
                kitapiade.Rafno = rdr["Rafno"].ToString();
                kitapiade.Verilistarihi = Convert.ToDateTime(rdr["Verilistarihi"]);
                kitapiade.Iadetarihi = Convert.ToDateTime(rdr["Iadetarihi"]);




                kitapiades.Add(kitapiade);
                //int conver.toin() içine yazılır
            }
            return kitapiades;//listeyi geriye döndermiş oldum
        }
        //öğrenci  daha önce hangi kitabı geri vermiş onların listesi tutuluyor
        public List<Kitapiade> TcArama(Kitapiade kitapiade)///dalın entity yi referans alması lazım
        {//datatable üzerinde veriileri çekiyorum
            OleDbCommand cmd = Accessconnection.GetOleDbCommand();//bağlantı hazır komut yazılmadı daha
            cmd.CommandText = "select * from Kitapiade";
            List<Kitapiade> kitapiades = new List<Kitapiade>();//entity de oluşturduğum class ismi
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (kitapiade.Tcno == rdr["Tcno"].ToString())
                {
                    Kitapiade kitapiade2 = new Kitapiade();
                    kitapiade2.Tcno = rdr["Tcno"].ToString();
                    kitapiade2.Adi = rdr["Adi"].ToString();
                    kitapiade2.Soyadi = rdr["Soyadi"].ToString();
                    kitapiade2.Telefon = rdr["Telefon"].ToString();
                    kitapiade2.Adres = rdr["Adres"].ToString();
                    kitapiade2.Barkodno = rdr["Barkodno"].ToString();
                    kitapiade2.Kitapadi = rdr["Kitapadi"].ToString();
                    kitapiade2.Yazari = rdr["Yazar"].ToString();
                    kitapiade2.Sayfasayi = rdr["Sayfasayisi"].ToString();
                    kitapiade2.Rafno = rdr["Rafno"].ToString();
                    kitapiade2.Verilistarihi = Convert.ToDateTime(rdr["Verilistarihi"]);
                    kitapiade2.Iadetarihi = Convert.ToDateTime(rdr["Iadetarihi"]);
                    kitapiades.Add(kitapiade2);
                }
            }
            return kitapiades;//listeyi geriye döndermiş oldum
        }
        //kitabı daha önce kimler geri vermiş onların listesi tutuluyor
        public List<Kitapiade> KitaapBarkodNoArama(Kitapiade kitapiade)
        {//datatable üzerinde veriileri çekiyorum
            OleDbCommand cmd = Accessconnection.GetOleDbCommand();//bağlantı hazır komut yazılmadı daha
            cmd.CommandText = "select * from Kitapiade";
            List<Kitapiade> kitapiades = new List<Kitapiade>();//entity de oluşturduğum class ismi
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (kitapiade.Barkodno == rdr["Barkodno"].ToString())
                {//Kitabı daha önce kimler almış ve geri vermiş olanların listesi
                    Kitapiade kitapiade2 = new Kitapiade();
                    kitapiade2.Tcno = rdr["Tcno"].ToString();
                    kitapiade2.Adi = rdr["Adi"].ToString();
                    kitapiade2.Soyadi = rdr["Soyadi"].ToString();
                    kitapiade2.Telefon = rdr["Telefon"].ToString();
                    kitapiade2.Adres = rdr["Adres"].ToString();
                    kitapiade2.Barkodno = rdr["Barkodno"].ToString();
                    kitapiade2.Kitapadi = rdr["Kitapadi"].ToString();
                    kitapiade2.Yazari = rdr["Yazar"].ToString();
                    kitapiade2.Sayfasayi = rdr["Sayfasayisi"].ToString();
                    kitapiade2.Rafno = rdr["Rafno"].ToString();
                    kitapiade2.Verilistarihi = Convert.ToDateTime(rdr["Verilistarihi"]);
                    kitapiade2.Iadetarihi = Convert.ToDateTime(rdr["Iadetarihi"]);

                    kitapiades.Add(kitapiade2);
                }
            }
            return kitapiades;//listeyi geriye döndermiş oldum
        }
        //kitap iade ederken sadece barkod numarasını yazarak dierğ alanları doldurmak için kullanıyorum
        public List<Kitapiade> BarkodArama(Kitapiade kitapiade)///dalın entity yi referans alması lazım
        {//datatable üzerinde veriileri çekiyorum
            OleDbCommand cmd = Accessconnection.GetOleDbCommand();//bağlantı hazır komut yazılmadı daha
            cmd.CommandText = "select * from Kitapiade";

            List<Kitapiade> kitapiades = new List<Kitapiade>();//entity de oluşturduğum class ismi
            OleDbDataReader rdr = cmd.ExecuteReader();
            //cmd nesnesini çalıştırıp daha sonra dönüp tekeer teker okuyup bu kullanicigirisi listesini doldurmamız gerekiyor

            while (rdr.Read())
            {//bütün tablodaki kolonları(alanları) kitapiade classımın alanlarına koydum

                //Kitap kitap = new Kitap();

                if (kitapiade.Tcno == rdr["Barkodno"].ToString())
                {
                    //Kitapver kitapver = new Kitapver();
                    kitapiade.Tcno = rdr["Tcno"].ToString();
                    kitapiade.Adi = rdr["Adi"].ToString();
                    kitapiade.Soyadi = rdr["Soyadi"].ToString();
                    kitapiade.Telefon = rdr["Telefon"].ToString();
                    kitapiade.Adres = rdr["Adres"].ToString();
                    kitapiade.Barkodno = rdr["Barkodno"].ToString();
                    kitapiade.Kitapadi = rdr["Kitapadi"].ToString();
                    kitapiade.Yazari = rdr["Yazar"].ToString();
                    kitapiade.Sayfasayi = rdr["Sayfasayisi"].ToString();
                    kitapiade.Rafno = rdr["Rafno"].ToString();
                    kitapiade.Verilistarihi = Convert.ToDateTime(rdr["Verilistarihi"]);
                    kitapiade.Iadetarihi = Convert.ToDateTime(rdr["Iadetarihi"]);



                    kitapiades.Add(kitapiade);
                }

                //int conver.toin() içine yazılır
            }
            return kitapiades;//listeyi geriye döndermiş oldum
        }
        //alınan kitabı iade ederken bunları iade edilenleri tutmak için kitapiade tablosuna iade edilen öğrenci kitap bilgilerini ekliyorum
        public int AddNewItem(Kitapiade kitapiade)
        {
            OleDbCommand cmd2 = Accessconnection.GetOleDbCommand();//bağlantı hazır komut yazılmadı daha
            cmd2.CommandText = "select * from Kitapver";//kullanmamım sebebi gelen öğrenci tcno ve barkodno ya ait bilgi var mı diiye bakıcam
            OleDbDataReader rdr = cmd2.ExecuteReader();
            int sayi = 0;//kullanmamımm sebebi öğrenci bu kitabı almışmı almadıysa dışarda hata mesajı vermek için
            while (rdr.Read())
            {
                if ((rdr["Tcno"].ToString() == kitapiade.Tcno) && (rdr["Barkodno"].ToString() == kitapiade.Barkodno))
                {//kitapver tablosunda öğrenci bu kitabı aldımı diye soruyorum aldıysa kitapiade tablosuna sargu ile ekleme yapıyorum
                    string cmdText = "INSERT INTO [Kitapiade] ([Tcno],[Adi],[Soyadi],[Telefon]," +
                "[Adres],[Barkodno],[Kitapadi],[Yazar],[Sayfasayisi],[Rafno],[Verilistarihi],[Iadetarihi])";
                    cmdText += String.Format(" Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", kitapiade.Tcno, kitapiade.Adi, kitapiade.Soyadi, kitapiade.Telefon,
                        kitapiade.Adres, kitapiade.Barkodno, kitapiade.Kitapadi, kitapiade.Yazari, kitapiade.Sayfasayi, kitapiade.Rafno, kitapiade.Verilistarihi, kitapiade.Iadetarihi);

                    //tabloda hangi dergerimin geleceği indexi düngünce yazdım
                    //string veya datetime tırnak içinde .Gerisi normal biçimde yani tırnak olmıcak 
                    OleDbCommand cmd = Accessconnection.GetOleDbCommand();
                    cmd.CommandText = cmdText;
                    cmd.ExecuteNonQuery();
                    sayi += 1;//öğrenci bu kitabı almıştır anlamına geliyor yani geri iade işlemi yapılıyor yapıldığı için dışarda hata mesajı vermicem
                }
            }
            return sayi;
        }
    }
}
