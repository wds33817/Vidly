﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        [Display(Name="Membership Type")]
        public byte MembershipTypeId { get; set; }


        [ForeignKey(nameof(MembershipTypeId))]
        public MembershipType MembershipType { get; set; }
        [Display(Name="Date of Birth")]
        
        public DateTime? Birthdate { get; set; }
        
    }
}
