using System.ComponentModel.DataAnnotations;

namespace eCinemaTickets.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name =" Email Address")]
        [Required(ErrorMessage ="Email Address is Required")]
        public string EmailAdress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
