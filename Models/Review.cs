using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Paiting
{
    public class Review
    {
        public int ReviewId {get;set;}
        [Required]
        [MinLength(2,ErrorMessage="Your name needs to be more than 2 characters")]
        public string FirstName {get;set;}
        [Required]
        public string LastName {get;set;}
        [Required]
        [MinLength(2,ErrorMessage="Comment needs to be more than 2 characters")]
        public string Text {get;set;}
        [Required]
        [Range(1,5)]
        public int Rating {get;set;}
        [Required]
        public string Area {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}