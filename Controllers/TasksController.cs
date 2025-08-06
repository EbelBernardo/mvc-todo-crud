using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoList_MVC.Data;
using ToDoList_MVC.Models;

namespace ToDoList_MVC.Controllers
{
    public class TasksController : Controller
    {
        private readonly AppDbContext _context;

        public TasksController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var tasks = _context.TaskItems.ToList();
            return View(tasks);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                ModelState.AddModelError("Title", "Title is required.");
                return View("Index", await _context.TaskItems.ToListAsync());
            }

            var task = new TaskItem
            {
                Title = title,
                IsCompleted = false,
            };

            await _context.TaskItems.AddAsync(task);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var task = await _context.TaskItems.FindAsync(id);
            if (task == null)
            {
                return NotFound();
            }

            _context.TaskItems.Remove(task);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> ToggleComplete(int id)
        {
            var task = await _context.TaskItems.FindAsync(id);
            if (task == null)
               return NotFound();

            task.IsCompleted = !task.IsCompleted;
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
