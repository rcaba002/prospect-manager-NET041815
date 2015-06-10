using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProspectManager.Mvc.Models.Contacts
{
    public class Contact : Attribute
    {
        public int Id { get; set; }

        [MaxLength(150)]
        [Required]
        public string Name { get; set; }
        [Index("IX_Email",IsUnique = true)]
        [MaxLength(250)]
        [EmailAddress]
        public string Email { get; set; }

        [DisplayName("Birthdate")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", 
            ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        public static void Dupes(string dupe)
        {
            
        }
    }
}
