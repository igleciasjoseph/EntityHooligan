using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaharaC
{
    public class Loginuser
    {
        [Key]
        public int UserId {get;set;}

        [Required]
        public string Email {get;set;}

        [Required]
        public string Password {get;set;}

        public DateTime CreatedAt {get;set;}
        public DateTime UpdatedAt {get;set;}
    }
}