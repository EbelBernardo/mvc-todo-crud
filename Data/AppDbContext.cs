using Microsoft.EntityFrameworkCore;
using ToDoList_MVC.Models;

namespace ToDoList_MVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<TaskItem> TaskItems { get; set; }
    }
}
