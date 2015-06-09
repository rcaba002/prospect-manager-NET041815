using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProspectManager.Mvc.Models.Contacts
{
    public class Contact
    {
        public int Id { get; set; }

        [MaxLength(150)]
        [Required]
        public string Name { get; set; }

        [MaxLength(250)]
        [EmailAddress]
        public string Email { get; set; }

        [DisplayName("Birthdate")]
        public DateTime BirthDate { get; set; }
    }
}
