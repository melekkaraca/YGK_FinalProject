using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductUpdated = "Ürün güncellendi.";
        public static string ProductDeleted = "Ürün silindi.";
        public static string ProductNameInValid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler listelendi.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";

        public static string ProductNameAlreadyExists = "Aynı isimde ürün var.";

        public static string CategoryLimitExceded = "Kategori sayısı 15'i geçtiği için ürün eklenemez.";

        public static string AuthorizationDenied ="İşlem yetkiniz bulunmamaktadır";

        public static string UserRegistered = "Kullanıcı kaydedildi";

        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatalı";
        public static string SuccessFullLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten kayıtlı";
        public static string AccessTokenCreated = "Erişim anahtarı oluşturuldu";
    }
}
