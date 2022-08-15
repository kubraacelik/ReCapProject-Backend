using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarNameInvalid = "Araba ismi geçersiz.";
        public static string MaintenanceTime = "Araba bakımda.";
        public static string CarPriceInvalid = "Araba ücreti geçersiz.";
        public static string CarRentalFail = "Araba kiralama başarısız.";
        public static string CarAdded = "Araba eklendi.";
        public static string CarDeleted = "Araba silindi.";
        public static string CarUpdated = "Araba güncellendi.";
        public static string CarsListed = "Arabalar listelendi.";
        public static string BrandAdded = "Marka eklendi.";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandListed = "Markalar listelendi.";
        public static string ColorAdded = "Renk eklendi.";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorListed = "Renkler listelendi.";
        public static string CustAdded = "Müşteri eklendi";
        public static string CustNotAdded = "Müşteri eklenemedi.";
        public static string CustDeleted = "Müşteri silindi";
        public static string CustUpdated = "Müşteri güncellendi";
        public static string CustListed = "Müşteriler listelendi.";
        public static string RentalAdded = "Kiralama oluşturuldu.";
        public static string RentalDeleted = "Kiralama silindi.";
        public static string RentalUpdated = "Kiralama güncellendi.";
        public static string RentalError = "Kiralama başarısız.";
        public static string RentalListed = "Kiralamalar listelendi.";
        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserNotAdded = "Kullanıcı eklenemedi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        public static string UserListed = "Kullanıcılar listelendi.";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Bu kullanıcı zaten mevcut";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}
