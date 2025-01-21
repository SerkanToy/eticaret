namespace eticaret.Domain.ErrorTr
{
    public static class ErrorMessage
    {
        public static string DefaultError = "Bilinmeyen bir hata oluştu.";
        public static string ConcurrencyFailure = "Eşzamanlılık hatası oluştu, nesne değiştirildi.";
        public static string PasswordMismatch = "Şifre hatalı.";
        public static string InvalidToken = "Geçersiz token.";
        public static string LoginAlreadyAssociated = "Bir kullanıcı daha önce giriş yapmış durumda.";
        public static string InvalidUserName = $"{0} kullanıcı adı geçersiz, yalnızca harf veya rakam içerebilir.";
        public static string InvalidEmail = $"{0} e-posta geçersiz.";
        public static string DuplicateUserName = $"{0} kullanıcı sistemimizde kayıtlıdır.";
        public static string DuplicateEmail = $"{0} eposta sistemimizde kayıtıldır.";
        public static string InvalidRoleName = $"{0} rol adı geçersiz.";
        public static string DuplicateRoleName = $"{0} rol adı zaten mevcut.";
        public static string UserAlreadyHasPassword = "Kullanıcının zaten belirlenmiş bir şifresi var.";
        public static string UserLockoutNotEnabled = "Bu kullanıcı için kilitleme etkin değil.";
        public static string UserAlreadyInRole = $"Kullanıcı zaten {0} rolünde.";
        public static string UserNotInRole = $"Kullanıcı {0} rolünde değil.";
        public static string PasswordTooShort = $"Şifreler en az {0} karakter olmalıdır.";
        public static string PasswordRequiresNonAlphanumeric = "Şifreler en az bir özel karakter (harf veya sayı olmayan) içermelidir.";
        public static string PasswordRequiresDigit = "Şifreler en az bir rakam ('0'-'9') içermelidir.";
        public static string PasswordRequiresLower = "Şifreler en az bir tane küçük harf içermelidir ('a' - 'z').";
        public static string PasswordRequiresUpper = "Şifreler en az bir büyük harf içermelidir ('A' - 'Z').";

    }
}
