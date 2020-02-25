using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Paiting
{
    public class Review
    {
        public int ReviewId {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string Text {get;set;}
        public int Rating {get;set;}
        public int Area {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}