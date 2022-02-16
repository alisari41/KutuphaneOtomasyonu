using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneOtamasyonuu.DAL;//bunu eklemeyi unutma diğer BLL ler için
using KutuphaneOtamasyonuu.Entity;//ekle

namespace KutuphaneOtamasyonuu.BLL
{
    public class OgrenciBLL
    {//BLL DAL dan referans alıcak
          //BLL referens sağ tuş projects->solition dan kullaicigirisi.DAL referans alıp tamam 

          OgrenciDAL ogrenciDAL;//ataması yapıcı metoda yağılır
        public OgrenciBLL()
        {//ctor tab tab yapıcı metod yapar
            ogrenciDAL = new OgrenciDAL();
        }
        public List<Ogrenci> GetAllItems()
        {
            return ogrenciDAL.GetAllItems();
            //BLL gidip getallitem metodu tetiklendiğinde gidip kullanci......DAL a gidip getallaitem metodu çağırı geri dönderdi
        }
        public List<Ogrenci> TxtSearchDuzenleme(Ogrenci ogrenci)
        {
            return ogrenciDAL.TxtSearchDuzenleme(ogrenci);
        }
        public int AddNewItem(Ogrenci ogrenci)
        {
            if ((ogrenci.TcNo == "") && (ogrenci.Adi == "") && (ogrenci.Soyadi == "") && (ogrenci.TelefonNo == ""))
            {
                throw new Exception("Lütfen Alanları doldurunuz.");
            }
            else if (ogrenci.TcNo == "")
            {
                throw new Exception("Lütfen TC numaranızı giriniz.");
            }
            else if ((ogrenci.Adi == ""))
            {
                throw new Exception("Lütfen Adınızı giriniz.");
            }
            else if (ogrenci.Soyadi == "")
            {
                throw new Exception("Lütfen Soyadınızı giriniz.");
            }
            else if (ogrenci.TelefonNo == "")
            {
                throw new Exception("Lütfen Telefon numaranızı giriniz.");
            }
            else
            {
                if (ogrenci.TcNo.Length != 11)
                {
                    throw new Exception("Geçerli Tc kimlik numarası giriniz.");
                }
                else if (ogrenci.TelefonNo.Length != 10)
                {
                    throw new Exception("Geçerli Telefon numarası giriniz.");
                }
            }
            return ogrenciDAL.AddNewItem(ogrenci);//sıralama önemli
        }
        public int DeleteItem(Ogrenci ogrenci)
        {
            int sayi;
            sayi = ogrenciDAL.DeleteItem(ogrenci);
            if(ogrenci.TcNo=="")
            {
                throw new Exception("Öğrenci TC kimlik numarasını alanını doldurunuz.");
            }
            else if (sayi == 0)
            {
                throw new Exception("Kayıtlı öğrenci bulunmamaktadır. Silme işlemi gerçekleşmedi");
            }
            return sayi;
        }
        public int UpdateItem(Ogrenci ogrenci)
        {
            if (ogrenci.TcNo == "")
            {
                throw new Exception("Lütfen öğrencinin TC numarasını giriniz.");
            }
            if (ogrenci.TcNo.Count() != 11)
            {
                throw new Exception("Lütfen geçerli TC kimlik numarası giriniz.");
            }
            else if ((ogrenci.TcNo.Count() == 11) && (ogrenci.Adi == "") && (ogrenci.Soyadi == "") && (ogrenci.TelefonNo == ""))
            {
                throw new Exception("Girdiğiniz tc kimlik numarasına ait öğrenci bulunmamaktadır. O yüzden gücelleme yapamazsınız.");
            }
            else if ((ogrenci.Adi == ""))
            {
                throw new Exception("Lütfen Adınızı giriniz.");
            }
            else if (ogrenci.Soyadi == "")
            {
                throw new Exception("Lütfen Soyadınızı giriniz.");
            }
            else if (ogrenci.TelefonNo == "")
            {
                throw new Exception("Lütfen Telefon numaranızı giriniz.");
            }
            else
            {
                if (ogrenci.TelefonNo.Length != 10)
                {
                    throw new Exception("Geçerli Telefon numarası giriniz.");
                }
            }
            return ogrenciDAL.UpdateItem(ogrenci);
        }
        public int BorcUpdateItem()
        {
            return ogrenciDAL.BorcUpdateItem();
        }
        public int BorcUpdateSifirlama()
        {
            return ogrenciDAL.BorcUpdateSifirlama();
        }

    }
}
