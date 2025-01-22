using System.ComponentModel.DataAnnotations;

namespace eticaret.Models.Login
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "*")]
        public string Email { get; set; }
        [Required(ErrorMessage = "*")]
        public string Password { get; set; }
        public bool RememberMe { get; set; } = false;
    }
}
