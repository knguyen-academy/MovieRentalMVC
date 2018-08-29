using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//need for data notation
using System.ComponentModel.DataAnnotations;

namespace MovieRentalMVC.Models
{
    public class Customer
    {
        public int Id { get; set; }
        //Add notation of Name to not null and 255 max char
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        //Ref to membershipType model to load object from Membership type
        public MembershipType MembershipType { get; set; }
        //FK to membershiptype (convention -> treat it as FK)
        public byte MembershipTypeId { get; set; }
        public DateTime? Birthday { get; set; } // ? = NULLable
    }
}