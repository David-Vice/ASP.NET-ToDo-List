using System.Collections.Generic;

namespace ASP.NET_HW1.Models
{
    public class TaskViewModel
    {
        public TaskViewModel()
        {
            Task = new TaskToDo();
            Tasks = new List<TaskToDo>();
        }
        public TaskToDo Task { get; set; }
        public List<TaskToDo> Tasks { get; set; }

    }
}
