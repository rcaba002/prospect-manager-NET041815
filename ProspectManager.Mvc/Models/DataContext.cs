using System.ComponentModel;
using System.Data.Entity;
using ProspectManager.Mvc.Models.Contacts;
using ProspectManager.Mvc.Models.Meetings;
using ProspectManager.Mvc.Models.TodoItems;

namespace ProspectManager.Mvc.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
            Database.SetInitializer<DataContext>(new SeededDatabaseInitializer());
        }

        [DisplayName("To Do Items")]
        public DbSet<TodoItem> TodoItems { get; set; }

        public DbSet<Contact> Contacts { get; set; }
            
        public DbSet<Meeting> Meetings { get; set; }

        public DbSet<Location> Locations { get; set; }
    }
}