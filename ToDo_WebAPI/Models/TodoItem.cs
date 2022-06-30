namespace ToDo_WebAPI.Models
{
    public class TodoItem
    {
        public long ID { get; set; }
        public string? Name { get; set; }
        public int urgency { get; set; }
        public bool completed { get; set; }
        public string? secret { get; set; }
    }
}
