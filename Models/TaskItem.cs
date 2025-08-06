using System.ComponentModel.DataAnnotations;

namespace ToDoList_MVC.Models
{

    public class TaskItem
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [MaxLength(100, ErrorMessage = "Title cannot be longer than 100 characters.")]
        public string Title { get; set; } = string.Empty;

        [MaxLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]

        public bool IsCompleted { get; set; }
    }
}
