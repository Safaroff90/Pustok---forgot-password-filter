using System.ComponentModel.DataAnnotations;

namespace _Pustok.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [MaxLength(100)]
        public string Email { get; set; }
    }
}
