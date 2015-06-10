using ProspectManager.Mvc.Models.Meetings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProspectManager.Mvc.Models.Contacts
{
    public class Contact
    {
        public int Id { get; set; }

        [MaxLength(150)]
        [Required]
        public string Name { get; set; }

        [Index(IsUnique = true)]
        [MaxLength(250)]
        [EmailAddress]
        public string Email { get; set; }

        [DisplayName("Birthdate")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", 
            ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        public virtual ICollection<Meeting> Meetings { get; set; }
    }
}
