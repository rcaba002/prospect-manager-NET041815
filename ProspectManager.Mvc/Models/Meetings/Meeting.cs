using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProspectManager.Mvc.Models.Meetings
{
    public class Meeting
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [DisplayName("Meeting Date")]
        public DateTime MeetingDate { get; set; }

        [DisplayName("Location ID")]
        public int LocationId { get; set; }

        public virtual Location Location { get; set; }
    }
}