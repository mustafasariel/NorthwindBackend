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

        public static string UserAdd { get; internal set; }
    }
}
