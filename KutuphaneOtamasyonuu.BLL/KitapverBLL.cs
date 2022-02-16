using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtamasyonuu.DAL;
using KutuphaneOtamasyonuu.Entity;

namespace KutuphaneOtamasyonuu.BLL
{
    public class KitapverBLL
    {
        KitapverDAL kitapverDAL;
        public KitapverBLL()
        {
            kitapverDAL = new KitapverDAL();
        }
        public List<Kitapver> GetAllItems()
        {          
            return kitapverDAL.GetAllItems();
            //BLL gidip getallitem metodu tetiklendiğinde gidip kitapverDAL a gidip getallaitem metodu çağırı geri dönderdi
        }
        public int AddNewItem(Kitapver kitapver)
        {
            int sonuc = 0;
            if ((kitapver.Tcno == "") && (kitapver.Barkodno == ""))
            {
                throw new Exception("Lüften Tc kimlik numarası ve Barkod numarası alanlarını giriniz!!");
            }
            else if (kitapver.Barkodno == "")
            {
                throw new Exception("Lütfen Barkod numarası kısmını boş bırakmayınız.");
            }
            else if (kitapver.Tcno == "")
            {
                throw new Exception("Lütfen öğrenci TC kimlik numarasını giriniz.");
            }
            else
            {
                sonuc = kitapverDAL.AddNewItem(kitapver);//sıralamaya dikkat et
                if (sonuc != 11 && sonuc != 5 && sonuc != 4)
                {
                    if (sonuc == 1)
                    {
                        throw new Exception("Kütüphanemizde girdiğiniz barkod numarasına kayıtlı kitap bulunmamaktadır.");
                    }
                    else if (sonuc == 3)
                    {
                        throw new Exception("Kütüphanemizde Kayıtlı öğrenci bulumamaktatır.");
                    }
                    else
                    {
                        throw new Exception("Kütüphanemizde Kayıtlı öğrenci ve kayıtlı kitap bulunmamaktadır.");
                    }
                }
                else if (sonuc == 5)
                {
                    throw new Exception("Aynı öğrenci bir kitabı birden fazla kez alamaz.");
                }
               
            }
            return sonuc;
        }
        public List<Kitapver> TcArama(Kitapver kitapver)
        {
            return kitapverDAL.TcArama(kitapver);
            //BLL gidip TcArama metodu tetiklendiğinde gidip kitapverDAL a gidip TcArama metodu çağırı geri dönderdi
        }
        public List<Kitapver> KitaapBarkodNoArama(Kitapver kitapver)
        {
            return kitapverDAL.KitaapBarkodNoArama(kitapver);
            //BLL gidip KitaapBarkodNoArama metodu tetiklendiğinde gidip kitapverDAL a gidip KitaapBarkodNoArama metodu çağırı geri dönderdi
        }
        public List<Kitapver> TxtSearchDuzenleme(Kitapver kitapver)
        {
            return kitapverDAL.TxtSearchDuzenleme(kitapver);
        }
        public List<Kitapver> BarkodArama(Kitapver kitapver)
        {
            return kitapverDAL.BarkodArama(kitapver);
            //BLL gidip BarkodArama metodu tetiklendiğinde gidip kitapverDAL a gidip BarkodArama metodu çağırı geri dönderdi
        }
        public int DeleteItem(Kitapver kitapver)
        {
            return kitapverDAL.DeleteItem(kitapver);
        }
        public int UpdateItem(Kitapver kitapver)
        {
            return kitapverDAL.UpdateItem(kitapver);
        }
    }
}
