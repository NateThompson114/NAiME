using System.ComponentModel.DataAnnotations;

namespace NAiME.ViewModel.Account
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required, Display(Name = "Email")]
        public string Email { get; set; }
    }
}