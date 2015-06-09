using System;
using System.ComponentModel.DataAnnotations;

namespace ProspectManager.Mvc.Models.Meetings
{
    public class Meeting
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        public DateTime MeetingDate { get; set; }

        public int LocationId { get; set; }

        public virtual Location Location { get; set; }
    }
}