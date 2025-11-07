using eticaret.Domain.Core.Entities;

namespace eticaret.Domain.Database.Mapping.ColorMappings
{
    public static class ColorValues
    {
        public static List<Colors> GetColorValues()
        {
            //https://learn.microsoft.com/tr-tr/power-platform/power-fx/reference/function-colors

            var ColorList = new List<Colors> {
                new Colors { Id = "1BA90E67-7F3C-44AA-AC7A-54F9E9225E04", Name = "Alice Blue", Colorvalue = "#f0f8ff", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = "DCB6324E-7154-4E44-91C7-FFABA3B28B5E", Name = "Antik Beyaz", Colorvalue = "#faebd7", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = "70305E3C-CE16-4154-AF57-B9C4C458E5EA", Name = "Aqua", Colorvalue = "#00ffff", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = "5F6C3716-C9A0-4BE0-9FAF-8C7A1AB5EC42", Name = "Akuamarin", Colorvalue = "#7fffd4", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = "E9212F8E-B877-4178-8539-20FB7AB5E00C", Name = "Masmavi", Colorvalue = "#f0ffff", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = "9C381C16-3198-47F8-A47F-D218DEFDA64F", Name = "Bej", Colorvalue = "#f5f5dc", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = "390E0394-7160-49FF-917D-FD44971610FF", Name = "BISQUE", Colorvalue = "#ffe4c4", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = "68751A54-0433-41DE-8527-5F17B341195A", Name = "Siyah", Colorvalue = "#000000", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = "6A8FAC7A-590A-47CA-B018-EBDB824822B6", Name = "Blanchedalmond", Colorvalue = "#ffebcd", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = "294A4FD6-7614-4205-B6F0-4162F33EAEB4", Name = "Mavi", Colorvalue = "#0000ff", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = "F8A97944-AE75-4093-866D-C286A355BD23", Name = "Mavi Menekşe", Colorvalue = "#8a2be2", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = "E51833F7-A3A5-4EC7-B8C2-9A22F87F1D39", Name = "Kahverengi", Colorvalue = "#a52a2a", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = "AEF3C637-1CA0-4CC2-81E8-0639E55F9B97", Name = "Burlywood", Colorvalue = "#deb887", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Colors { Id = "7DD698F2-37A7-44B6-BB3B-60673B13E226", Name = "CadetBlue", Colorvalue = "#5f9ea0", CreateBy = "System", CreateDate = DateTime.Now.ToString(), IsDeleted = false },
            };
            return ColorList;
        }
    }
}
