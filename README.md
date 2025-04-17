Bu proje, ASP.NET Core MVC kullanılarak geliştirilmiş ve katmanlı mimari (Layered Architecture) prensiplerine dayalı bir uygulamadır. Proje, Business Layer, Data Access Layer ve Presentation Layer gibi farklı katmanlarda yapılandırılmıştır. Her katman, uygulamanın farklı işlevselliklerini bağımsız ve modüler şekilde yönetmektedir.

Katmanlar ve İçerikleri
Business Layer
Business Layer, iş mantığını ve uygulama için gerekli iş kurallarını içerir. Bu katman aşağıdaki bileşenleri içerir:

Abstract: İş mantığı için kullanılan servis arayüzleri.

IGenericService.cs: Genel servis arayüzü.

ITeknokentService.cs: Teknokent işlemleri için servis arayüzü.

Concrete: İş mantığını gerçekleştiren sınıflar.

TeknokentManager.cs: Teknokent işlemlerini yöneten sınıf.

Data Access Layer
Data Access Layer, veritabanı işlemleri ve veri erişim katmanını yönetir. Bu katman aşağıdaki bileşenleri içerir:

Abstract: Veri erişim katmanı arayüzleri.

IGenericDal.cs: Genel veri erişim arayüzü.

ITeknokentDal.cs: Teknokent verisi için veri erişim arayüzü.

Context: Veritabanı bağlamı ve bağlantı yönetimi.

ProjeContext.cs: Veritabanı bağlamı ve modelleri yöneten sınıf.

Entities: Uygulama veritabanı modelleri.

Teknokent.cs: Teknokent verisi için Entity sınıfı.

Repositories: Veri erişim işlemlerini gerçekleştiren sınıflar.

GenericRepository.cs: Genel repository sınıfı.

TeknokentDal.cs: Teknokent verileri için repository sınıfı.

Presentation Layer
Presentation Layer, kullanıcı arayüzü (UI) ve kullanıcı ile etkileşimli bileşenleri içerir. Bu katman aşağıdaki bileşenleri içerir:

Controllers: Kullanıcıdan gelen istekleri yöneten denetleyiciler.

HomeController.cs: Ana sayfa işlemleri için denetleyici.

TeknokentController.cs: Teknokent işlemleri için denetleyici.

Models: Kullanıcıdan alınan verilerin ve hata mesajlarının modelleri.

ErrorViewModel.cs: Hata mesajlarını taşıyan model.

Views: Kullanıcı arayüzü dosyaları.

Teknokent klasöründe, Teknokent ile ilgili sayfalar yer alır: Create.cshtml, Delete.cshtml, Edit.cshtml, Index.cshtml.

Home klasöründe, ana sayfa ile ilgili sayfalar yer alır.

Shared klasörü, uygulama genelinde kullanılan ortak görseller ve dosyaları içerir: _Layout.cshtml, _ValidationScriptsPartial.cshtml.

Configuration and Settings
appsettings.json: Uygulama ayarlarını ve bağlantı dizesini içerir.

Program.cs: Uygulama başlangıç ayarlarını ve servis yapılandırmalarını içerir.

Teknolojiler
ASP.NET Core MVC: MVC (Model-View-Controller) mimarisini kullanarak web uygulamaları geliştirmek için kullanılan bir platform.

Entity Framework Core: ORM (Object-Relational Mapping) framework'ü ile veritabanı işlemleri.

Microsoft SQL Server: Veritabanı yönetim sistemi.

HTML, CSS, JavaScript: Kullanıcı arayüzü geliştirme teknolojileri.
