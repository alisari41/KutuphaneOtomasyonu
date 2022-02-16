using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtamasyonuu.DAL;//bunu eklemeyi unutma diğer BLL ler için
using KutuphaneOtamasyonuu.Entity;//ekle

namespace KutuphaneOtamasyonuu.BLL
{
    public class kullanicigirisiBLL
    {//BLL DAL dan referans alıcak  
        //BLL referens sağ tuş projects->solition dan kullaicigirisi.DAL referans alıp tamam 

        kullanicigirisiDAL KullanicigirisiDAL;//ataması yapıcı metoda yağılır
        public kullanicigirisiBLL()
        {//ctor tab tab yapıcı metod yapar
            KullanicigirisiDAL = new kullanicigirisiDAL();
        }
        public List<kullanicigirisi> GetAllItems()
        {
            // ilk önce güvenlik önlemleri alınana kodlar
            //Validasyon işlemlerini yapıldığı kodlar


            return KullanicigirisiDAL.GetAllItems();
            //BLL gidip getallitem metodu tetiklendiğinde gidip kullanci......DAL a gidip getallaitem metodu çağırı geri dönderdi

        }
        public string AddNewItem(kullanicigirisi Kullanicigirisi)
        {
            // ilk önce güvenlik önlemleri alınana kodlar
            //Validasyon işlemlerini yapıldığı kodlar
            if((Kullanicigirisi.Kullaniciadi == "")&& (Kullanicigirisi.Adi == "")&& (Kullanicigirisi.Soyadi == "")&&(Kullanicigirisi.Sifre==""))
            {
                throw new Exception("Boş alanları doldurunuz.");
            }
            else if(Kullanicigirisi.Kullaniciadi == "")
            {
                throw new Exception("Kullanıcı adını doldurunuz.");
            }
            else if (Kullanicigirisi.Sifre.Length < 3)
            {
                throw new Exception("Sifreniz en az 4 karakter olmalıdır.");
            }
            else if(Kullanicigirisi.Adi=="")
            {
                throw new Exception("Lütfen adınızı giriniz.");
            }
            else if(Kullanicigirisi.Soyadi=="")
            {
                throw new Exception("Lütfen soyadınızı giriniz.");
            }
            return KullanicigirisiDAL.AddNewItem(Kullanicigirisi);//sıralamaya dikkat et
        }
        public string Arama(kullanicigirisi Kullanicigirisi)///dalın entity yi referans alması lazım
        {
            string kullaniciadi = KullanicigirisiDAL.Arama(Kullanicigirisi);
            //kullanıcıadı =
            if ((Kullanicigirisi.Kullaniciadi == "") && (Kullanicigirisi.Sifre == ""))
            {
                throw new Exception("Kullanici adinizi ve şifrenizi giriniz");
            }
            else if (Kullanicigirisi.Kullaniciadi == "")
            {
                throw new Exception("Kullanici adinizi giriniz");
            }
            else if (Kullanicigirisi.Sifre == "")
            {
                throw new Exception("Şifrenizi giriniz");
            }
            else if (kullaniciadi == "")
            {
                throw new Exception("Kullanici adi veya şifreniz yanlış");
            }
            return kullaniciadi;
        }
        public int DeleteItem(kullanicigirisi Kullanicigirisi)
        {
            return KullanicigirisiDAL.DeleteItem(Kullanicigirisi);
        }
        public int UpdateItem(kullanicigirisi Kullanicigirisi)
        {
            return KullanicigirisiDAL.UpdateItem(Kullanicigirisi);
        }
    }
}
