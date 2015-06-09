using System;
using System.ComponentModel.DataAnnotations;

namespace ProspectManager.Mvc.Models.TodoItems
{
    public class TodoItem
    {
        public int Id { get; set; }

        [MaxLength(200)]
        [Required]
        public string Description { get; set; }

        public DateTime? DueDate { get; set; }

        public bool Completed { get; set; }
    }
}