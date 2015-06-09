using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProspectManager.Mvc.Models.Meetings
{
    public class Location
    {
        public int Id { get; set; }

        [MaxLength(150)]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Meeting> Meetings { get; set; }
    }
}
