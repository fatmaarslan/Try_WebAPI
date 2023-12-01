# Try_WebAPI

**PROJE GENEL BAKIŞ**

Projede belirtilen Project ve User için Model klasörü oluşturup içerisine istenilen özelliklerine göre property ler oluşturdum.

 
Projenin esnekliği ve sürdürebilirliği açısından Projects ve Users servisleri sınıfı oluşturup , Bu sınıfların içerisine List< "" >_"" nesnesini oluşturdum 

servisler içerisinde kayıt,detay ve silme işlemleri ile ilgili 
metod yaratıp , Controller sınıfında belirtilen isteklere göre Get , Post ve Delete Metodlarını oluşturdum. Ve  istenilen işleme uygun , servis sınıfları içerisinde yarattığım  metodun çağrımını yaptım.

Startup.cs kısmında Bu servislerin Dependency Injection uygulamasını yaptım. 
Uyguladıgım Injectionu kullanabilmek açısından Controller sayfamda Servislerin işlevselliğine erişim sağladım 

Bu Projede Veri tabanı uygulaması yapmadan Controller kısmında en alt kısımda user ve project için 1 er hazır data bilgisi girdim.




