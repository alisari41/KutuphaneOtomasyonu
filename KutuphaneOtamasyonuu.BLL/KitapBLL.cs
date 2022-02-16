using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtamasyonuu.DAL;
using KutuphaneOtamasyonuu.Entity;

namespace KutuphaneOtamasyonuu.BLL
{
    public class KitapBLL
    {
        KitapDAL kitapdal;
        public KitapBLL()
        {
            kitapdal = new KitapDAL();
        }
        public List<Kitap> GetAllItems()
        {
            return kitapdal.GetAllItems();
        }
        public Tuple<string[], string[],double[]> Grafik()
        {//birden fazla dizi grafik yapmak için
            return kitapdal.Grafik();
        }
        public List<Kitap> Arama(Kitap kitap)
        {
            if (kitap.Borkodno == "")
            {
                throw new Exception("Lütfen Barkod numarasını giriniz!!");
            }
            else if (kitapdal.Arama(kitap).Count <= 0)
            {
                throw new Exception("Kütüphanemizde kitap mevcut değil");
            }
            return kitapdal.Arama(kitap);
        }
        public List<Kitap> KitapAdiArama(Kitap kitap)
        {
            if (kitap.Kitapadi == "")
            {
                throw new Exception("Lütfen kitap adını giriniz!!");
            }
            else if (kitapdal.KitapAdiArama(kitap).Count <= 0)
            {
                throw new Exception("Kütüphanemizde kitap mevcut değil");
            }           
            return kitapdal.KitapAdiArama(kitap);
        }
        public List<Kitap> TxtSearchDuzenleme(Kitap kitap)
        {
            return kitapdal.TxtSearchDuzenleme(kitap);
        }
        public int AddNewItem(Kitap kitap)
        {
            if((kitap.Borkodno == "")&& (kitap.Kitapadi == "")&& (kitap.Yazari == "")&& (kitap.Sayfasayisi == "")&& (kitap.Rafno == "")&& (kitap.Kitapadeti <= 0))
            {
                throw new Exception("Lütfen Alanları doldurunuz");
            }
            else if (kitap.Borkodno == "")
            {
                throw new Exception("Lütfen Barkod numarasını giriniz!!");
            }
            else if ((kitap.Kitapadi == ""))
            {
                throw new Exception("Lütfen Kitap Adını giriniz!!");
            }
            else if(kitap.Yazari == "")
            {
                throw new Exception("Lütfen Kitabın Yazarı'nın ismini giriniz!!");
            }
            else if(kitap.Sayfasayisi == "")
            {
                throw new Exception("Lütfen Kitabın sayfa sayısını giriniz!!");
            }
            else if(kitap.Rafno == "")
            {
                throw new Exception("Lütfen Kitabın raf numarasını  giriniz!!");
            }
            else if(kitap.Kitapadeti<=0)
            {
                throw new Exception("Lütfen Geçerli kitap adeti giriniz.");
            }            
            return kitapdal.AddNewItem(kitap);//sıralamaya dikkat et
        }
        public int DeleteItem(Kitap kitap)
        {
            int sonuc= kitapdal.DeleteItem(kitap);
            if (kitap.Borkodno == "")
            {
                throw new Exception("Silmek istediğiniz Kitabın Barkod numarasını giriniz");
            }
            else  if (sonuc == 0)
            {
                throw new Exception("Kütüphanemizde silmek için girdiğiniz barkod numarasına ait kitap mevcut değildir. Silme işlemi gerçekleşemez.");
            }            
            return kitapdal.DeleteItem(kitap);
        }
        public int UpdateItem(Kitap kitap)
        {
            if (kitap.Borkodno == "")
            {
                throw new Exception("Lütfen Barkod numarasını giriniz!!");
            }
            else if ((kitap.Borkodno != "") && (kitap.Kitapadi == "") && (kitap.Yazari == "") && (kitap.Sayfasayisi == "") && (kitap.Rafno == ""))
            {
                throw new Exception("Güncellemek istedğiniz barkod numarasına ait kütüphanemizde kitap bulunmamaktadır.");
            }
            else if ((kitap.Kitapadi == ""))
            {
                throw new Exception("Lütfen Kitap Adını giriniz!!");
            }
            else if (kitap.Yazari == "")
            {
                throw new Exception("Lütfen Kitabın Yazarı'nın ismini giriniz!!");
            }
            else if (kitap.Sayfasayisi == "")
            {
                throw new Exception("Lütfen Kitabın sayfa sayısını giriniz!!");
            }
            else if (kitap.Rafno == "")
            {
                throw new Exception("Lütfen Kitabın raf numarasını  giriniz!!");
            }
            else if (kitap.Kitapadeti < 0)
            {
                throw new Exception("Lütfen Geçerli kitap adeti giriniz.");
            }
            return kitapdal.UpdateItem(kitap);
        }
        public int UpdateKitapadetiazalt(Kitap kitap)
        {
            return kitapdal.UpdateKitapadetiazalt(kitap);
        } 
        public int UpdateKitapadetiarttir(Kitap kitap)
        {
            return kitapdal.UpdateKitapadetiarttir(kitap);
        }
    }
}
