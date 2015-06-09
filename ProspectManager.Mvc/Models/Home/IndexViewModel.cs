using System.Collections.Generic;
using ProspectManager.Mvc.Models.Meetings;
using ProspectManager.Mvc.Models.TodoItems;

namespace ProspectManager.Mvc.Models.Home
{
    public class IndexViewModel
    {
        public List<TodoItem> UpcomingTodos { get; set; }

        public List<Meeting> UpcomingMeetings { get; set; }

        public List<char> Alphabet { get; set; }
    }
}