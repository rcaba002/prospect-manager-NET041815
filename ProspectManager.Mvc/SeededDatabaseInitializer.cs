using System;
using System.Data.Entity;
using ProspectManager.Mvc.Models;
using ProspectManager.Mvc.Models.Contacts;
using ProspectManager.Mvc.Models.Meetings;
using ProspectManager.Mvc.Models.TodoItems;

namespace ProspectManager.Mvc
{

    class SeededDatabaseInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            base.Seed(context);

            context.Contacts.Add(new Contact { Name = "John Doe", Email = "j.doe@example.com", 
                BirthDate = new DateTime(1978, 4, 3)});
            context.Contacts.Add(new Contact { Name = "Jane Doe", Email = "jdoe@example.com", 
                BirthDate = new DateTime(1978, 6, 3)});
            context.Contacts.Add(new Contact { Name = "Superman", Email = "super@example.com", 
                BirthDate = new DateTime(1978, 9, 3)});

            context.TodoItems.Add(new TodoItem { Description = "Do something", DueDate = new DateTime(2015, 1, 1) });
            context.TodoItems.Add(new TodoItem { Description = "Already done", DueDate = new DateTime(2015, 7, 1), Completed = true });
            context.TodoItems.Add(new TodoItem { Description = "Not due ever" });

            context.Locations.Add(new Location { Name = "Main Conference" });
            context.Locations.Add(new Location { Name = "Small Conference" });
        }
    }
}