using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba guncellendi";
        public static string CarNameInvalid = "Araba ismi gecersiz";
        
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk guncellendi";
        public static string ColorNameInvalid = "Renk ismi gecersiz";
        
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka guncellendi";
        public static string BrandNameInvalid = "Marka ismi gecersiz";
       
        public static string MaintenanceTime = "Sistem bakimda";
        public static string CarsListed = "Arabalar listelendi";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanici silindi";
        public static string UserUpdated = "Kullanici guncellendi";
        public static string UserNameInvalid = "Kullanıcı ismi geçersiz";
        public static string UsersListed = "Kullanıcılar listelendi";

        public static string CustomerAdded = "Musteri eklendi";
        public static string CustomerDeleted = "Musteri silindi";
        public static string CustomerUpdated = "Musteri guncellendi";
        public static string CustomerNameInvalid = "Musteri ismi geçersiz";
        public static string CustomersListed = "Musteriler listelendi";

        public static string RentalCouldNotAdded = "Bu araba henüz teslim edilmediği için kiralayamazsınız";
        public static string RentalAdded = "Araba Kiralama İşlemi başarıyla gerçekleşti";
        public static string RentalUpdated = "Araba Kiralama İşlemi Güncellendi";
        public static string RentalDeleted = "Araba Kiralama İşlemi Silindi";
        public static string RentalDetailsListed = "Araba Kiralama Bilgileri Listelendi";
    }
}
