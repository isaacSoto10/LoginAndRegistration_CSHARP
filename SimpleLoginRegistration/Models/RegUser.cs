using System.ComponentModel.DataAnnotations; 
namespace SimpleLoginRegistration.Models
{
    public class RegUser
    {
        [Required(ErrorMessage = "This field is required")]
        [MinLength(2, ErrorMessage = "First Name must contain at least 2 characters")]
        public string FirstName {get; set;}

        [Required(ErrorMessage = "This field is required")]
        [MinLength(2, ErrorMessage = "Last Name must contain at least 2 characters ")]
        public string LastName {get; set;}

        [Required(ErrorMessage = "Email field is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string RegEmail {get; set;}

        [Required(ErrorMessage = "This field is required")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        [DataType(DataType.Password)]
        public string RegPassword {get; set;}

        [Required(ErrorMessage = "This field is required")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        [DataType(DataType.Password)]
        [Compare("RegPassword", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword {get; set;}   
    }
    
}