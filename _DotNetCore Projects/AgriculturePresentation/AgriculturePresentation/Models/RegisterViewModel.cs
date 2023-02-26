using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
	public class RegisterViewModel
	{
		[Required(ErrorMessage = "Lütfen Kullanıcı Adını Giriniz")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Lütfen Email Adresini Giriniz")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Lütfen Şifre Giriniz")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz")]
		[Compare("Password", ErrorMessage = "Şifreler Uyumlu Değil, kontrol Ediniz")]
		public string PasswordConfirm { get; set; }
	}
}
