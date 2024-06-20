*******************************************************
*                                                     *
*                  Film Arşivim Uygulaması            *
*                                                     *
*******************************************************

Bu proje, C# programlama dili kullanılarak geliştirilmiş bir film arşiv uygulamasıdır. Uygulama, kullanıcıların film bilgilerini kaydetmelerini ve bu bilgileri görüntülemelerini sağlar.

## Özellikler

- Film adı, kategori ve link bilgilerini veritabanında saklar.
- Veritabanından kayıtlı filmleri listeleyebilir ve düzenleyebilirsiniz.
- İlgili bir filme çift tıklayarak, içerisinde bulunduğu linki Webview2 kontrolünde görüntüleyebilirsiniz.
- Film ekleme işlemi için gerekli alanların kontrolü yapılarak gerçekleştirilir.
- Tam ekran modunda Webview2 içindeki videoları tam ekran yapabilme özelliği.

## Nasıl Çalıştırılır

1. **Gereksinimler:**
   - Visual Studio veya benzeri bir C# IDE (Integrated Development Environment) gereklidir.
   - .NET Framework veya .NET Core ortamı.
   - Veritabanı sunucusu olarak Microsoft SQL Server veya SQL Server Express kullanılabilir.

2. **Projeyi İndirme:**
   - Bu repository'i klonlayın veya ZIP olarak indirin.

3. **Visual Studio ile Açma:**
   - Visual Studio'yu açın.
   - Proje dosyasını (`Film_Arsivim.sln`) açın.

4. **Veritabanı Ayarları:**
   - Projenin bağlanacağı veritabanınızı SQL Server Management Studio veya benzeri bir araçla oluşturun.
   - `Form1.cs` dosyasındaki `SqlConnection` nesnesinde veritabanı bağlantı bilgilerini güncelleyin.

5. **Proje Derleme ve Çalıştırma:**
   - Projeyi derleyin (`Ctrl + Shift + B`).
   - Projeyi başlatmak için `Start` düğmesine basın (`F5`).

6. **Uygulamayı Kullanma:**
   - Uygulama açıldığında, kayıtlı filmler `dataGridView1` üzerinde listelenecektir.
   - Yeni bir film eklemek için `Film Adı`, `Kategori` ve `Link` alanlarını doldurun ve `Kaydet` butonuna tıklayın.
   - Bir film kaydına çift tıklayarak, içerisindeki linki `btnTamEkran` butonu ile tam ekran modunda Webview2 kontrolünde görüntüleyin.
   - Uygulamayı `Çıkış` butonu ile kapatabilirsiniz.

## Kod Açıklamaları

- **Form1_Load:** Form yüklendiğinde mevcut film verileri `dataGridView1` üzerinde gösterilir.
- **btnKaydet_Click:** Yeni bir film kaydı eklemek için gerekli alanların doldurulup kontrol edilmesi sağlanır ve veritabanına eklenir.
- **dataGridView1_CellDoubleClick:** `dataGridView1` üzerinde bir film kaydına çift tıklanması durumunda, ilgili film linki `webView21` üzerinde gösterilir.
- **btnTamEkran_Click:** Webview2 içerisindeki videoyu tam ekran yapma işlemi için JavaScript kullanarak gerekli komutlar çalıştırılır.
- **btnRenkDegistir_Click:** Formun arka plan rengini rastgele seçilen renklerden biriyle değiştirir.

## Uygulama Ekran Görüntüleri

Aşağıda uygulamanın ekran görüntüleri bulunmaktadır:

![Ana Ekran](https://github.com/mihrapgozcu/Film_Arsivim/blob/master/Ana%20Ekran.png)
*Uygulamanın ana ekranı*

![Film Ekleme](https://github.com/mihrapgozcu/Film_Arsivim/blob/master/Film%20Ekleme.png)
*Yeni bir film eklenirken*

![Hakkımızda](https://github.com/mihrapgozcu/Film_Arsivim/blob/master/Hakk%C4%B1m%C4%B1zda.png)

![Renk Değiştirme](https://github.com/mihrapgozcu/Film_Arsivim/blob/master/Renk%20De%C4%9Fi%C5%9Ftirme.png)

![Filmin Gözükmesi](https://github.com/mihrapgozcu/Film_Arsivim/blob/master/ekranda%20filmin%20g%C3%B6z%C3%BCkmesi.png)

![](https://github.com/mihrapgozcu/Film_Arsivim/blob/master/Tam%20ekran.png)
*Webview2 kontrolünde tam ekran modunda video oynatma*

