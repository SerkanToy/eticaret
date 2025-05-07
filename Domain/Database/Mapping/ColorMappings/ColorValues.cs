using eticaret.Domain.Core.Entities;

namespace eticaret.Domain.Database.Mapping.ColorMappings
{
    public static class ColorValues
    {
        public static List<Colors> GetColorValues()
        {
            //https://learn.microsoft.com/tr-tr/power-platform/power-fx/reference/function-colors

            var ColorList = new List<Colors> {
                new Colors { Id = 1, Name = "Alice Blue", Colorvalue = "#f0f8ff", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = 2, Name = "Antik Beyaz", Colorvalue = "#faebd7", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = 3, Name = "Aqua", Colorvalue = "#00ffff", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = 4, Name = "Akuamarin", Colorvalue = "#7fffd4", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = 5, Name = "Masmavi", Colorvalue = "#f0ffff", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = 6, Name = "Bej", Colorvalue = "#f5f5dc", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = 7, Name = "BISQUE", Colorvalue = "#ffe4c4", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = 8, Name = "Siyah", Colorvalue = "#000000", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = 9, Name = "Blanchedalmond", Colorvalue = "#ffebcd", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = 10, Name = "Mavi", Colorvalue = "#0000ff", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = 11, Name = "Mavi Menekşe", Colorvalue = "#8a2be2", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = 12, Name = "Kahverengi", Colorvalue = "#a52a2a", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = 13, Name = "Burlywood", Colorvalue = "#deb887", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = 14, Name = "CadetBlue", Colorvalue = "#5f9ea0", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
            };
            return ColorList;
        }
    }
}
