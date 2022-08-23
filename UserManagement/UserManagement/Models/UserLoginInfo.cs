using System.ComponentModel.DataAnnotations;

namespace UserManagement.Models
{
    public class UserLoginInfo
    {
        [Required(ErrorMessage = "Please enter your user name")]
        [MinLength(3, ErrorMessage = "MinLength of the username should be greater than 2 characters")]
        [MaxLength(25, ErrorMessage = "MaxLength of the username less be greater than 26 characters")]

        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [MinLength(3, ErrorMessage = "MinLength of the password should be greater than 2 characters")]
        [MaxLength(25, ErrorMessage = "MaxLength of the password less be greater than 26 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
