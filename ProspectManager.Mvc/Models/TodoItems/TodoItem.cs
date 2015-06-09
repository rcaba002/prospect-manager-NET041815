using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProspectManager.Mvc.Models.TodoItems
{
    public class TodoItem
    {
        public int Id { get; set; }

        [MaxLength(200)]
        [Required]
        public string Description { get; set; }

        [DisplayName("Due Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
            ApplyFormatInEditMode = true)]
        public DateTime? DueDate { get; set; }

        public bool Completed { get; set; }
    }
}