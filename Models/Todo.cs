namespace my_todos_backend.Models
{
    public class Todo
    {
        public int id { get; set; }
        public string title { get; set; }
        public string startDate { get; set; }
        public string dueDate { get; set; }
        public string description { get; set; }
    }
}
