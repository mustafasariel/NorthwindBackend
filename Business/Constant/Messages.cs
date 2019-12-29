using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constant
{
    public static class Messages
    {
        public static string ProductAdd = "Ürün başarıyla eklendi";
        public static string ProductUpdated = "Ürün başarıyla güncellendi";
        public static string ProductDeleted = "Ürün başarıyla silindi";

        public static string CategoryAdd = "Kategori başarıyla eklendi";
        public static string CategoryUpdated = "Kategori başarıyla güncellendi";
        public static string CategoryDeleted = "Kategori başarıyla silindi";

        public static string RegionAdd = "Region başarıyla eklendi";
        public static string RegionUpdated = "Region başarıyla güncellendi";
        public static string RegionDeleted = "Region başarıyla silindi";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Kullanıcı başarılı giriş yaptı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";


        public static string UserCreateInfo = "Kullanıcı kayıt edilelir";

        public static string UserRegistered = "Kullanıcı başarı ile kayıt edildi";
    }
}
