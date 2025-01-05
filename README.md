# JWT Projesi

Bu proje, **JSON Web Token (JWT)** kullanarak güvenli bir kimlik doğrulama sistemi oluşturmayı amaçlayan bir örnek uygulamadır. JWT, modern web uygulamalarında kullanıcı kimlik doğrulama ve oturum yönetimi için yaygın olarak kullanılan bir standarttır.

## Proje Özellikleri

- Kullanıcı kimlik doğrulaması
- JWT ile token oluşturma ve doğrulama
- Güvenli API uç noktaları
- Refresh token desteği

## Kullanılan Teknolojiler

- **.NET Core**: Backend geliştirme için kullanılan framework
- **Entity Framework Core**: Veritabanı işlemleri
- **JWT**: Kimlik doğrulama için token yapısı
- **SQL Server**: Veritabanı yönetimi

## Kurulum

1. **Proje Deposu**nu Klonlayın:
   ```bash
   git clone https://github.com/iremrakicii/JWT--.git
   ```

2. **Proje Dizini**ne Geçiş Yapın:
   ```bash
   cd JWT--
   ```

3. **Bağımlılıkları Yükleyin**:
   Visual Studio veya .NET CLI kullanarak projeyi build edin:
   ```bash
   dotnet build
   ```

4. **Veritabanı Migrasyonlarını Uygulayın**:
   ```bash
   dotnet ef database update
   ```

5. **Uygulamayı Çalıştırın**:
   ```bash
   dotnet run
   ```

## API Uç Noktaları

### Kimlik Doğrulama

- **POST /api/auth/login**
  - Giriş yapan kullanıcı için JWT token oluşturur.

- **POST /api/auth/refresh-token**
  - Refresh token kullanarak yeni bir JWT token oluşturur.

### Kullanıcı İşlemleri

- **GET /api/users**
  - Tüm kullanıcıları listeler. (Sadece yetkili kullanıcılar erişebilir.)

- **POST /api/users**
  - Yeni bir kullanıcı oluşturur.

## Çevresel Değişkenler

Proje için aşağıdaki çevresel değişkenleri ayarlamanız gereklidir:

- **JWT_SECRET**: JWT oluşturmak için kullanılan gizli anahtar.
- **DB_CONNECTION_STRING**: Veritabanı bağlantı dizesi.

## Katkıda Bulunma

1. Bu repoyu forklayın.
2. Yeni bir özellik dalı oluşturun: `git checkout -b yeni-ozellik`
3. Değişikliklerinizi yapın ve commitleyin: `git commit -m 'Yeni bir özellik eklendi'`
4. Dalınızı bu repoya gönderin: `git push origin yeni-ozellik`
5. Bir **Pull Request** oluşturun.

## Lisans

Bu proje [MIT Lisansı](LICENSE) ile lisanslanmıştır.

---

Herhangi bir sorunuz veya öneriniz varsa, lütfen iletişime geçmekten çekinmeyin!
