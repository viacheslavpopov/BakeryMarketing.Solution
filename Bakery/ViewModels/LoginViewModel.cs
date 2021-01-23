using System.ComponentModel.DataAnnotations;

namespace Bakery.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string Password { get; set; }
    }
}