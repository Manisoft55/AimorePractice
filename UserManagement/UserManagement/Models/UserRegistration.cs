using System.ComponentModel.DataAnnotations;

namespace UserManagement.Models
{
    public class UserRegistration
    {
        [Required(ErrorMessage = "Please enter your first name")]
        [MinLength(2, ErrorMessage = "Please enter atleast two characters")]
        [MaxLength(50, ErrorMessage = "Please enter upto 50 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [MinLength(2, ErrorMessage = "Please enter atleast two characters")]
        [MaxLength(50, ErrorMessage = "Please enter upto 50 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Enter your age")]
        [DataType(DataType.PostalCode)]
        [MaxLength(3, ErrorMessage = "Please enter valid age")]
        [Display(Name = "Age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please provide your email id")]
        [MinLength(10, ErrorMessage = "Please enter atleast two characters")]
        [MaxLength(70, ErrorMessage = "Please enter upto 50 characters")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Please provide your mobile number")]
        [MaxLength(10, ErrorMessage = "Please enter upto 10 digits")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Mobile Number")]
        public long MobileNumber { get; set; }
    }
}
