using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvaild = "Ürün İsmi Geçersiz";
        public static string MaintenaceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir Kategoride En Fazla 15 Tane Ürün Olabilir.";
        public static string ProductNameAlreadyExist = "Aynı ada sahip bir başka ürün mevcut.";
        public static string CategoryLimitExceeded = "Kategori Limiti Aşıldığı İçin Yeni Ürün Eklenemiyor.";
        public static string AuthorizationDenied = "Yetnkiniz Yok";
        public static string UserRegistered = "Kullanıcı Kayıt Oldu";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre Yanlış";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Giriş Başarılı";
        public static string ProductNameEmptyError = "Ürün Adı Boş Olamaz";
        public static string ProductPriceEmptyError = "Ürün Fiyatı Boş Olamaz";
        public static string ProductPriceZeroError = "Ürün Fiyatı 0 Dan Fazla Olmalı";
        public static string ProductPriceLowError = "Ürün Fiyatı 10 dan büyük Olmalı";
        public static string ProductNameLetterError = "Ürünler A Harfi İle Başlamalıdır";
        public static string ProductNameSyllableError = "Ürün Adı 2 Harften Daha Uzun Olmalı";

    }
}
