using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class TasksController : Controller
    {
        private readonly AppDbContext _context;

        public TasksController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var tasks = await _context.TaskItems.ToListAsync();
            return View(tasks);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TaskItem task) //try/catch
        {
            if(ModelState.IsValid)
            {
                task.CreatedAt = DateTime.Now;
                task.Status = Models.TaskStatus.Pending;

                _context.TaskItems.Add(task);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(task);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var task = await _context.TaskItems.FindAsync(id);
            if(task == null)
                return NotFound();

            return View(task);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TaskItem task)
        {
            if (id != task.Id)
                return BadRequest();

            if(ModelState.IsValid)
            {
                try
                {
                    _context.Update(task);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if(!_context.TaskItems.Any(t => t.Id == task.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return View(task);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var task = await _context.TaskItems.FirstOrDefaultAsync(t => t.Id == id);
            if (task == null)
                return NotFound();

            return View(task);
        }

        [HttpPost, ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var task = await _context.TaskItems.FindAsync(id);
            if (task == null)
                return NotFound();

            _context.TaskItems.Remove(task);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}
