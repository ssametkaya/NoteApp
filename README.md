# İç İçe Not Uygulaması

Bu uygulamada frontend için ASP.NET Core MVC, backend için ASP.NET Core Web API frameworkleri kullanıldı.
ORM olarak Entity Framework Core, veritabanı olarak MSSQL kullanıldı.

## Hakkında
Bu uygulamada ana notu başlık ve içerik girerek oluşturuyoruz. Ardından ana notların içerisine farklı notlar ekleyebiliyoruz. Notlar için CRUD işlemleri gerçekleştirildi.
Silenecek verilerin sadece ön yüzde gözükmeyip, veritabanında durması için Tablolara eklenen "IsDeleted" sütunu ile "false" olanlar ön yüzde gözüküyor. Eğer notu silmek istersek sil butonuna basılır. 
Silme işleminde sadece "IsDeleted" "true" haline gelir.

## Kullanım
Projeyi cloneladıktan sonra MVC tarafında HomeController içerisindeki methodlarda Api için kullanılan Url'yi kendi localhostunuza göre düzenleyin.

```
 public IActionResult Index()
        {
            HttpClient httpClient = new HttpClient();
            var responseMessage = httpClient.GetAsync("LOCALHOST ADI GİRİNİZ/api/Note/GetNoteList/").Result;
            List<NoteViewModel> notes = new List<NoteViewModel>();
            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                notes = JsonConvert.DeserializeObject<List<NoteViewModel>>(responseMessage.Content.ReadAsStringAsync().Result);
            }
            return View(notes);
        }
```

Appsetting.json içerisinde yer alan veritabanı bağlantısını kendi bilgisayarınıza göre, MSSQL'e uygun connection string yazınız.

```
"ConnectionStrings": {
    "DefaultConnection": "Data Source=Kendi Bilgisayarınızdaki Server Name;Initial Catalog=NoteAppDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
  }
```
## Ekran Görüntüleri

![NoteApp1](https://i.hizliresim.com/pwz61yr.png)
![NoteApp2](https://i.hizliresim.com/j58yblk.png)