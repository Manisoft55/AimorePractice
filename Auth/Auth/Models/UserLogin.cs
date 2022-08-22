using System.ComponentModel.DataAnnotations;

namespace Auth.Models
{
    public class UserLogin
    {
        [Required(ErrorMessage = "Username is required")]
        [MaxLength(50)]
        [MinLength(5, ErrorMessage = "Please enter atleast 5 characters")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MaxLength(50)]
        [DataType(DataType.Password)]

        public string Password { get; set; }

    }
}
