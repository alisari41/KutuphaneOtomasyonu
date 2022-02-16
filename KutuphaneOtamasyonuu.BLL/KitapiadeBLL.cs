using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtamasyonuu.DAL;
using KutuphaneOtamasyonuu.Entity;

namespace KutuphaneOtamasyonuu.BLL
{
    public class KitapiadeBLL
    {
        KitapiadeDAL kitapiadeDAL;
        public KitapiadeBLL()
        {
            kitapiadeDAL = new KitapiadeDAL();
        }
        public List<Kitapiade> GetAllItems()
        {

            return kitapiadeDAL.GetAllItems();
            //BLL gidip getallitem metodu tetiklendiğinde gidip KitapiadeDAL a gidip getallaitem metodu çağırı geri dönderdi
        }
        public int AddNewItem(Kitapiade kitapiade)
        {
            int sayi;
            if ((kitapiade.Tcno == "") && (kitapiade.Barkodno == ""))
            {
                throw new Exception("Lüften Tc kimlik numarası ve Barkod numarası alanlarını giriniz!!");
            }
            else if (kitapiade.Barkodno == "")
            {
                throw new Exception("Lütfen Barkod numarası kısmını boş bırakmayınız");
            }
            else if (kitapiade.Tcno == "")
            {
                throw new Exception("Lütfen öğrenci TC kimlik numarasını giriniz");
            }
            else
            {
                sayi = kitapiadeDAL.AddNewItem(kitapiade);//eğer sorgu çalışmadıysa öğrenci bu kitabı almamıştır bilgisi  dönecek
                if (sayi == 0)
                {
                    throw new Exception("Öğrencimiz Bu kitabı almamıştır.");
                }
            }            
            return sayi;
        }
        public List<Kitapiade> TcArama(Kitapiade kitapiade)
        {
            return kitapiadeDAL.TcArama(kitapiade);
            //BLL gidip TcArama metodu tetiklendiğinde gidip KitapiadeDALL a gidip TcArama metodu çağırı geri dönderdi
        }
        public List<Kitapiade> KitaapBarkodNoArama(Kitapiade kitapiade)
        {
            return kitapiadeDAL.KitaapBarkodNoArama(kitapiade);
            //BLL gidip KitaapBarkodNoArama metodu tetiklendiğinde gidip KitapiadeDAL a gidip KitaapBarkodNoArama metodu çağırı geri dönderdi
        }
        public List<Kitapiade> BarkodArama(Kitapiade kitapiade)
        {
            return kitapiadeDAL.BarkodArama(kitapiade);
            //BLL gidip BarkodArama metodu tetiklendiğinde gidip KitapiadeDAL a gidip BarkodArama metodu çağırı geri dönderdi
        }
    }
}
