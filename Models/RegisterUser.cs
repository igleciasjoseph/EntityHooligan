using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaharaC.Models
{
    public class RegisterUser
    {
        [Key]
        public int UserId {get;set;}

        [Required]
        [MinLength(3, ErrorMessage = "Your First Name Must Be At Least 3 Characters Long")]
        public string FirstName {get;set;}

        [Required]
        [MinLength(3, ErrorMessage = "Your Last Name Must Be At Least 3 Characters Long")]
        public string LastName {get;set;}

        [Required]
        [EmailAddress(ErrorMessage = "Please Enter A Valid Email Address")]
        public string Email {get;set;}

        [Required]
        [DataType(DataType.Password)]
        public string Password {get;set;}

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [MinLength(3, ErrorMessage = "Password Must Be At Least 3 Characters Long")]
        public string ConfirmPassword {get;set;}
        
        public DateTime CreatedAt {get;set;}
        public DateTime UpdatedAt {get;set;}
    }
}