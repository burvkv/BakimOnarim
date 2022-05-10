using System.ComponentModel.DataAnnotations;

namespace bakimonarim.webui.ViewModels
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage="Lütfen kullanıcı adınızı girin")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi girin")]
        public string Password { get; set; }
    }
}
