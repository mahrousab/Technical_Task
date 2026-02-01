using System.ComponentModel.DataAnnotations;

namespace Technical_Task.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "please enter your Name")]
        public string Username { get; set; }
        [Required(ErrorMessage = "please enter your Password")]
        public string Password { get; set; }
    }
}
