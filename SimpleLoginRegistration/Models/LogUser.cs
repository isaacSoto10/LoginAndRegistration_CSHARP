using System.ComponentModel.DataAnnotations; 
namespace SimpleLoginRegistration.Models
{
    public class LogUser
    {
        [Required(ErrorMessage = "Email field is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string LogEmail {get; set;}

        [Required(ErrorMessage = "Password field is required")]
        public string LogPassword {get; set;}

    }
    
}