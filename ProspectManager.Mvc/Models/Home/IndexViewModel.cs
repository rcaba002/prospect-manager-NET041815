using System.Collections.Generic;
using System.ComponentModel;
using ProspectManager.Mvc.Models.Meetings;
using ProspectManager.Mvc.Models.TodoItems;

namespace ProspectManager.Mvc.Models.Home
{
    public class IndexViewModel
    {
        [DisplayName("Upcoming To-Do Items")]
        public List<TodoItem> UpcomingTodos { get; set; }

        [DisplayName("Upcoming Meetings")]
        public List<Meeting> UpcomingMeetings { get; set; }

        public List<char> Alphabet { get; set; }
    }
}