namespace ASP.NET_HW1.Models
{
    public class TaskToDo
    {
        public TaskToDo()
        {
        }
        public TaskToDo(string info)
        {
            Info = info;
        }
        public string Info { get; set; }
    }
}
