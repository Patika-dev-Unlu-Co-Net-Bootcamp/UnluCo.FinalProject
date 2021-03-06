## ??????NL?? & Co .Net Bootcamp Bitirme Projesi
<hr>

Bitirme projesi iki ana projeyi ve bir background wroker servisini i癟ermektedir. ??癟 projenin 癟al覺??t覺r覺labilmesi i癟in 癟oklu ba??lang覺癟 se癟ene??inden 羹癟 projenin se癟ilmi?? olmas覺 gerekmektedir. Generic Repository ve UnitOfWork  patternleri kullan覺lm覺??t覺r.
Yap覺lan i??lemler s覺ras覺yla a??a??覺da a癟覺klanm覺??t覺r. En son k覺s覺mda ise t羹m g繹revler bir liste halinde bulunmaktad覺r.


#### Yetkilendirme 
??ye olma ve kay覺t olabilme fonksiyonu eklendi. 襤ki farkl覺 ??ekilde kay覺t i??lemi ger癟ekle??tirilmektedir. BlazorUI projesinden sadece normal kullan覺c覺 kay覺t i??lemi ger癟ekle??tirilmektedir. ??yelik kay覺r i??lemleri i癟in kullan覺c覺 ad覺, e-posta ve bir parola gerekmektedir. Bir kullan覺c覺 e-posta adresini 羹癟 defadan fazla girdi??i takdirde hesab覺 kilitlenir ve kay覺tl覺  e-posta adresine bilgilendirme  e-postas覺 g繹nderilir. Bu i??lem i癟in **Rabittmq**'den yararlan覺ld覺. E-postalar bir kuyruk tablosunda toplanarak daha sonra arkaplan i??癟isi tarf覺ndan dinlenildikten sonra ilgili hesaplara mail g繹nderme i??lemi ger癟ekle??tirilir. **Background Worker** ve di??er servisleri kullanabilmek i癟in a??a??覺daki bilgilerin  **"appsettings.json"** dosyas覺na eklenmesi gerekmektedir. Kullan覺c覺 bilgilerini do??ru girdi??i takdirde cevap olarak **token** g繹nderilmektedir ve bu token **localstorage** ta tutulmaktad覺r. 


###### Rabbitmq Ba??lant覺 Adresi
```json
  "RabbitMqSettings": {
    "URL": "Rabbitmq'den ald覺??覺n覺z url adresinin girilmesi gereken alan"
  }
```


###### E-posta Ayarlar覺
```json
  "MailSettings": {
    "Mail": "E-posta adresiniz",
    "DisplayName": "G繹r羹nt羹lenmesini istedi??iniz ad",
    "Password": "??ok g羹venli parola",
    "Host": "smtp.gmail.com",
    "Port": 587
  }
```
Son olarak ise **Worker.cs** dosyas覺nda belirtilen k覺s覺mlar覺 doldurulmas覺 gerekmektedir.


###### Veri Taban覺 Baglant覺 Ayarlar覺
```json
"AllowedHosts": "*",
  "ConnectionStrings": {
    "ConnStr": "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FinalProject;Integrated Security=True;Trusted_Connection=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
  }
```
###### JWT Ayarlar覺
```json
"JWT": {
    "ValidAudience": "http://localhost:5000/",
    "ValidIssuer": "http://localhost:5000/",
    "Secret": "ByYM000OLlMQG6VVVp1OH7Xzyr7gHuw1qvUC5dcGt3SNM"
  }
```

#### Kategori
??r羹nler kategorilere g繹re filtrelenerek BlazorUI projesindeki Categories sayfas覺na eklendi. API kullan覺larak kategori ekleme silme g羹ncelleme i??lemleri eklendi. Blazor aray羹ze ise sadece kategorileri g繹r羹nt羹leme se癟ene??i eklendi.


#### ??r羹n Detaylar覺
Y羹zde de??er olarak ve tam say覺 de??eri olarak teklif sunma se癟ene??i sunulmu??tur. Servis k覺sm覺nda d繹n羹?? i??lemi ger癟ekle??tirilerek veri taban覺na kay覺t edilmektedir. Bir 羹r羹ne teklif verildikten sonra teklifi iptel edebilme olana??覺 sunulmu??tur. Verilen tekliflerden biri kullan覺c覺 taraf覺ndan kabul edilirse di??er teklifler otomatikmen iptal edilip silinmektedir. ??r羹n sat覺ld覺ktan sonra yeniden sat覺??a kapal覺 durumu gelmektedir.


#### Hesab覺m Detaylar覺
User sayfas覺ndan t羹m kullan覺c覺lara ait offerlar 羹r羹nler listelenmektedir. Al覺nan tekliflere onayla ve reddet ile cevap verilebilmektedir.


#### ??r羹n Ekleme Detaylar覺
??r羹n eklenirken istenilen bilgiler ??unlard覺r: 羹r羹n ad覺, a癟覺klama, kategori, renk, marka, kullan覺m durumu, 羹r羹n g繹rseli, fiyat ve teklif opsiyonu.



#### Kullan覺lar Teknolojiler
* Automapper
* Entity Framework
* Rabittmq
* Fluent Validation
* Identity
* JWT Bearer
* Blazor
* Background Worker


<hr>
<image src="https://github.com/Patika-dev-Unlu-Co-Net-Bootcamp/UnluCo.FinalProject/blob/master/Screenshots/ProductsPageScreenshot.png?raw=true" alt="Products" style="height:100%;width:100%">

<image src="https://github.com/Patika-dev-Unlu-Co-Net-Bootcamp/UnluCo.FinalProject/blob/master/Screenshots/CategoriesPageScreenshot.png?raw=true" alt="Categories" style="height:100%;width:100%">

<image src="https://github.com/Patika-dev-Unlu-Co-Net-Bootcamp/UnluCo.FinalProject/blob/master/Screenshots/UsersPageScreenshot.png?raw=true" alt="UsersPage" style="height:100%;width:100%">

<image src="https://github.com/Patika-dev-Unlu-Co-Net-Bootcamp/UnluCo.FinalProject/blob/master/Screenshots/LoginPageScreenshot.png?raw=true" alt="LoginPage" style="height:100%;width:100%">
<image src="https://github.com/Patika-dev-Unlu-Co-Net-Bootcamp/UnluCo.FinalProject/blob/master/Screenshots/SignUpPageScreenshot.png?raw=true" alt="SignUp" style="height:100%;width:100%">
