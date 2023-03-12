using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifre Giriniz")]
        public string Password { get; set; }

    }
}
