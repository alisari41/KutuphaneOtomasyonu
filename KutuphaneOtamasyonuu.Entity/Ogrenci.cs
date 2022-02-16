using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtamasyonuu.Entity
{
    public class Ogrenci
    {//butün tablo alanlarını burada oluşturcam class halinde olucak
     //artık tablo ile işim olmaması gerekiyor
     //prop tab tab yaparak uzun hali gelir 
     //kolonlarını hepsini tipleriyle beraber yazdım
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TelefonNo { get; set; }
        public string Adres { get; set; }
        public int Borc { get; set; }

    }
}
