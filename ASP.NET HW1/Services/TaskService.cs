using ASP.NET_HW1.Models;
using System.Collections.Generic;

namespace ASP.NET_HW1.Services
{
    public class TaskService : ITaskService
    {
        public TaskService()
        {
            Tasks = new List<TaskToDo>();
        }
        public List<TaskToDo> Tasks { get; set; }
    }
}
