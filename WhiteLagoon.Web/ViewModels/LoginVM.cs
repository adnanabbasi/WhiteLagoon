using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;

namespace WhiteLagoon.Web.ViewModels
{
    public class LoginVM
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

        public string? RedirectUrl { get; set; }
    }
}
