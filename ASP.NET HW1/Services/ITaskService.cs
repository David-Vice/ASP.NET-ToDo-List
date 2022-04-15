using ASP.NET_HW1.Models;
using System.Collections.Generic;

namespace ASP.NET_HW1.Services
{
    public interface ITaskService
    {
        public List<TaskToDo> Tasks { get; set; }
    }
}
