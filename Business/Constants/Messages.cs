using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants 
{
    public static class Messages 
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInValid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoriye maksimum 10 ürün eklenebilir";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string ProductNameAlreadyExists = "Bu isimde ürün zaten mevcut";
        public static string CategoriesListed = "Kategoriy Listelendi!";
        public static string CategoryLimitExceeded = "Kategori Limiti aşıldı";
        public static string AuthorizationDenied = "yetkiniz yok ";
        public static string UserAdded = "Kullanıcı Eklendi";

        public static string UserRegistered = "Kayıt oldu";

        public static string UserNotFound = "Kullanıcı bulunamadı";

        public static string PasswordError = "Parola hatası";

        public static string SuccessfulLogin = "Başarılı giriş yapıldı";

        public static string UserAlreadyExists = "Kullanıcı mevcut";

        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}

