
# Kütüphane Otomasyonu
## KATMANLI MİMARİ
### KutuphaneOtamasyonuu.Entity
Diğer katmanlardan referans almıyor sadece referans veriyor.
Kullandığım tabloları sınıf içinde tanımladım bütün değişkenleri tablo alanlarıyla aynı oluşturdum.Bu katmanda sınıfları  oluşturdum.Yani bu katmanda proje boyunca kullanacağımız ana classlarımızı belirliyoruz yani gerçek nesnelerimizi belirlediğimiz yer burası. Diğer katmanlarda nesnelerini oluşturarak nesneye dayalı yapıcam.
### KutuphaneOtamasyonuu.DAL
Entity katmanından referans alıyor.
#### Data Access Layer 
Veri tabanı bağlantı kodlarının bulunduğu katman.  Bu katmanda sadece veritabanı işlemleri yapılmaktadır. Bu katmanın görevi veriyi ekleme, silme, güncelleme ve veritabanından çekme işlemidir.Veri tabanı buradan işlenir.
KutuphaneOtamasyonuu.BLL
Entity ve DAL katmanlarından referans alır.
### Business Layer
Bu katman iş yüklerimiz yapılıyor.Bu katman DAL katmanı tarafından projeye çekilmiş olan verileri alarak işleyecek olan katmandır.Kullanıcıdan gelen veriler öncelikle bu katmana (iş katmanı) na gelir buradan işlenerek DAL(data Access layer) katmanına aktarılır.
### KutuphaneOtamasyonuu.UI.WinnForm
Entity ve BLL katmanlarından referans alır.
#### Sunum Katmanı 
Bu katman kullanıcı ile etkileşimin yapıldığı katmandır. Burada temel amaç kullaniciya verileri göstermek ve kullanıcıdan gelen verileri Business Katmanı ile Data Access’e iletmektir.Burada BLL katmanına ulaşacağız blll katmanı gidip DAL katmanına iletecektir.Tabi BLL katmanında işlemler yapılacak.Sonrasında DAL katmanına gidicek.




## Geliştiriciler

- [Ali SARI](https://www.github.com/alisari41) tasarım ve geliştirme için.

  
## Kurulum Notları
- Kullandığım Access 32bit sürüm olduğu için bilgisayarınızda AccessDatabaseEnginex86'nin yüklü olması gerekiyor.
- Değilse Lütfen programının kurulumunu yapmadan önce AccessDatabaseEngine.exe kurulumunu gerçekleştiriniz.
- Sonrasında SETUP -> Debug içerisinden kurulum yapabilirsiniz.
  
## Demo

- Personel Giriş ekranı ayrıca Personel kayıtlı değilse kayıt olabilir.
![image](https://user-images.githubusercontent.com/81421228/155904302-6f71c9ad-b67c-488a-8247-e728d986a122.png)

- Eğer personel giriş yaptıysa pop-up

![image](https://user-images.githubusercontent.com/81421228/155904401-546f0108-beaf-41e8-a24f-490fcc5b58ec.png)

- Veya yeni kayıt olduysa

![image](https://user-images.githubusercontent.com/81421228/155904477-9b45ee7e-47d6-4107-8a26-c82a9eab811a.png)

- Öğrenci Ekleme, Silme, Güncelleme işlemleri yapılmaktadır. Örneğin
![image](https://user-images.githubusercontent.com/81421228/155904531-9b647ef0-82af-41a0-b908-307cadfa91be.png)

- Kitap Ekleme, Silme, Güncelleme, Listeleme, Kitap Adına veya Barkod numarasına göre arama ve Bir kitabı bu tarihe kadar teslim alanların ve iade edenlerin listesi
![image](https://user-images.githubusercontent.com/81421228/155904649-10ece858-be20-420f-91ef-cc22b0eee3d5.png)

- Öğrenciye kitap verme işlemi. Kitap adeti varsa ve o öğrenci o kitabı daha önce almadıysa alabilir. Bir öğrenci bir kitabı bir kere alabilir. İade işlemi gerçekleştirdikten sonra tekrar alabilir.
![image](https://user-images.githubusercontent.com/81421228/155904736-06cf2486-4896-4f12-b876-3e63a7eaa200.png)

- Öğrenci eğer kitabı teslim aldıysa o kitabı iade edebilir.
![image](https://user-images.githubusercontent.com/81421228/155904774-3fcc5cbc-095a-4d1d-8534-74bd7a0094b7.png)

- Öğrencinin Aldığı veya İade ettiği kitapların listesi. Öğrenci kitabın gününü geçirdiyse kırmzı ile teslim süresine 2 gün kaldıysa sarı teslim etmiş ise yeşi ile gösterilir.
![image](https://user-images.githubusercontent.com/81421228/155904987-56e454e2-ee9a-483d-a5b2-1797712abffe.png)

- Dinamik grafik çizelgesi (zedgraph) 
![image](https://user-images.githubusercontent.com/81421228/155905049-a01cbc7f-e391-4d01-9bfd-2da697647e19.png)

- Eğer Öğrenci aldığı kitabın gününü geçirdiyse geçirdiği her gün için 1 tl para cezası uygulanır.
![image](https://user-images.githubusercontent.com/81421228/155905151-0d34f7f2-ede0-4a82-a08d-c1e603432312.png)
