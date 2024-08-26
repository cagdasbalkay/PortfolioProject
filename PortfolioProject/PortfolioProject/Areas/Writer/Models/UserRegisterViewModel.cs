using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı girin")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyadınızı girin")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen resim yükleyin")]
        public IFormFile Image { get; set; }
        [Required(ErrorMessage ="Lütfen kullanıcı adınızı girin")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi girin")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi tekrar girin")]
        [Compare("Password",ErrorMessage ="Şifreler uyumlu değildir")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen mail bilginizi girin")]

        public string Mail { get; set; }
    }
}
