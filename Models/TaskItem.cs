

using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public enum TaskStatus
    {
        Completed,
        Pending,
        Overdue
    }
    public class TaskItem
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Description { get; set; }

        public TaskStatus Status { get; set; } = TaskStatus.Pending;

        [DataType(DataType.Date)]
        public DateTime? DueDate { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? CompletedAt { get; set; }
    }
}
