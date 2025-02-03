using System.ComponentModel.DataAnnotations;

namespace eticaret.Models.ViewModel.RegisterDTO
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "*")]
        //[RegularExpression("[a-zA-Z]*", ErrorMessage = "Alfanümerik karakterlerden oluşmalıdır.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "*")]
        //[RegularExpression("[a-zA-Z]*", ErrorMessage = "Alfanümerik karakterlerden oluşmalıdır.")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "*")]
        [RegularExpression(@"^((?!\.)[\w-_.]*[^.])(@\w+)(\.\w+(\.\w+)?[^.\W])$", ErrorMessage = "E-Posta adresi girin.")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "*")]
        public string Psswrd { get; set; }
        public Message? Messages { get; set; }
    }
}
