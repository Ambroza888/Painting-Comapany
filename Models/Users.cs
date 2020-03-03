using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Paiting.Models
{
    class User
    {
       public int UserId {get;set;}
       [Required]
       public string FirstName {get;set;}
       [Required]
       public string LastName {get;set;}
       [Required]
       [EmailAddress]
       public string Email {get;set;}
       [Required]
       [DataType(DataType.Password)]
       public string Password {get;set;}

       // Date
       public DateTime CreatedAt {get;set;} = DateTime.Now;
       public DateTime UpdatedAt {get;set;} = DateTime.Now;

       [NotMapped]
       public string Confirm {get;set;}

       // adding connection
    }
}