using System.ComponentModel.DataAnnotations;

namespace eticaret.Models.Login
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "*")]
        [RegularExpression(@"^((?!\.)[\w-_.]*[^.])(@\w+)(\.\w+(\.\w+)?[^.\W])$", ErrorMessage = "E-Posta adresi girin.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "*")]
        public string Password { get; set; }
        public bool RememberMe { get; set; } = false;
    }
}
