using System.ComponentModel.DataAnnotations;

namespace eticaret.Models.ViewModel.LoginDTO
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "*")]
        public string EMail { get; set; } = null!;
        [Required(ErrorMessage = "*")]
        public string Pssword { get; set; } = null!;
        public bool RememberMe { get; set; }
    }
}
