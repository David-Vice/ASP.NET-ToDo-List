using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ASP.NET_HW1.Services;
using ASP.NET_HW1.Models;
using System.Linq;

namespace ASP.NET_HW1.Controllers
{
    public class TaskController : Controller
    {
        private ITaskService task;

        public TaskController(ITaskService _task)
        {
            this.task = _task;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new TaskViewModel() { Tasks=task.Tasks});
        }

        [HttpPost]
        public IActionResult Index(TaskViewModel taskNew)
        {
            task.Tasks.Add(taskNew.Task);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            task.Tasks.RemoveAt(id);
            return RedirectToAction("Index");
        }
    }
}
