using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Paiting
{
    public class Review
    {
        public int ReviewId {get;set;}
        [Required]
        [MinLength(2,ErrorMessage="Your First Name, needs to be more than 2 characters")]
        public string FirstName {get;set;}
        [Required]
        [MinLength(2,ErrorMessage="Your Last Name, needs to be more than 2 characters")]
        public string LastName {get;set;}
        [Required]
        [MinLength(2,ErrorMessage="Comment needs to be more than 2 characters")]
        public string Text {get;set;}
        [Required]
        [Range(0,5,ErrorMessage="Please, choose Rating")]
        public int Rating {get;set;}
        [Required]
        public string Area {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}