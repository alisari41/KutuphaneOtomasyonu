using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using KutuphaneOtamasyonuu.Entity;//bunu ekliyorum entityi kullanmak için


namespace KutuphaneOtamasyonuu.DAL
{
    public class kullanicigirisiDAL
    {
        private accessconnection Accessconnection;
        //new acceesscone.... yapma yapıcı metod altında yapılırmış
        public kullanicigirisiDAL()
        {
            Accessconnection = new accessconnection();
        }

        public List<kullanicigirisi> GetAllItems()///dalın entity yi referans alması lazım
        {//datatable üzerinde veriileri çekiyorum
            OleDbCommand cmd = Accessconnection.GetOleDbCommand();//bağlantı hazır komut yazılmadı daha
            cmd.CommandText = "select * from kullanicigirisi";



            //entity katmanından sonra data table işlevini yitirdi
            //DataTable dt = new DataTable();
            //dt.Load(cmd.ExecuteReader());

            //return dt;

            List<kullanicigirisi> kullanicigirisis = new List<kullanicigirisi>();//entity de oluşturduğum class ismi
            OleDbDataReader rdr = cmd.ExecuteReader();
            //cmd nesnesini çalıştırıp daha sonra dönüp tekeer teker okuyup bu kullanicigirisi listesini doldurmamız gerekiyor

            while (rdr.Read())
            {//bütün tablodaki kolonları(alanları) kullaniicgirisi classımın alanlarına koydum
                kullanicigirisi Kullanicigirisi = new kullanicigirisi();
                Kullanicigirisi.Kullaniciadi = rdr["Kullaniciadi"].ToString();
                Kullanicigirisi.Sifre = rdr["Sifre"].ToString();
                Kullanicigirisi.Adi = rdr["Adi"].ToString();
                Kullanicigirisi.Soyadi = rdr["Soyadi"].ToString();

                kullanicigirisis.Add(Kullanicigirisi);
                //int conver.toin() içine yazılır
            }
            return kullanicigirisis;//listeyi geriye döndermiş oldum
        }
        public string Arama(kullanicigirisi Kullanicigirisi)///dalın entity yi referans alması lazım
        {//datatable üzerinde veriileri çekiyorum
            OleDbCommand cmd = Accessconnection.GetOleDbCommand();//bağlantı hazır komut yazılmadı daha
            cmd.CommandText = "select * from kullanicigirisi ";
            OleDbDataReader rdr = cmd.ExecuteReader();
            //cmd nesnesini çalıştırıp daha sonra dönüp tekeer teker okuyup bu kullanicigirisi listesini doldurmamız gerekiyor
            string kullaniciadi = "";
            while (rdr.Read())
            {
                if ((rdr["Kullaniciadi"].ToString() == Kullanicigirisi.Kullaniciadi) && (rdr["Sifre"].ToString() == Kullanicigirisi.Sifre))
                {//kullanıcı adı ve şifre doğru ise bana kullanıcı adını ve soyadını dönder.
                    kullaniciadi = rdr["Adi"].ToString() + " " + rdr["Soyadi"].ToString();
                }              
            }
            return kullaniciadi;
        }
        public string AddNewItem(kullanicigirisi Kullanicigirisi)
        {
            string cmdText = "INSERT INTO [kullanicigirisi] ([Kullaniciadi],[Sifre],[Adi],[Soyadi])";
            cmdText += String.Format(" Values('{0}','{1}','{2}','{3}')", Kullanicigirisi.Kullaniciadi, Kullanicigirisi.Sifre, Kullanicigirisi.Adi, Kullanicigirisi.Soyadi);
            //tabloda hangi dergerimin geleceği indexi aynı olamak zorumda
            //string veya datetime tırnak içinde .Gerisi normal biçimde yani tırnak olmıcak 
            OleDbCommand cmd = Accessconnection.GetOleDbCommand();
            cmd.CommandText = cmdText;
            cmd.ExecuteNonQuery();            
            return Kullanicigirisi.Adi + " " + Kullanicigirisi.Soyadi;//açılır pencere mesajı için dönderiyorum
        }

        public int DeleteItem(kullanicigirisi Kullanicigirisi)
        {
            OleDbCommand cmd = Accessconnection.GetOleDbCommand();
            cmd.CommandText = string.Format("Delete From kullanicigirisi where Kullaniciadi='" + Kullanicigirisi.Kullaniciadi + "'");
            //{0} ilk paramametre demek
            //kullanıcı adına göre silme

            return cmd.ExecuteNonQuery();
        }

        public int UpdateItem(kullanicigirisi Kullanicigirisi)
        {//guncellemeyi sona bıraktım unutmaaaaaa
            OleDbCommand cmd = Accessconnection.GetOleDbCommand();
            cmd.CommandText = string.Format("Update kullanicigirisi set Sifre='" + Kullanicigirisi.Sifre + "',Adi='" + Kullanicigirisi.Adi + "',Soyadi='" + Kullanicigirisi.Soyadi + "'where Kullaniciadi='" + Kullanicigirisi.Kullaniciadi + "'");

            return cmd.ExecuteNonQuery();


        }

    }
}
