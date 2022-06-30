namespace ToDo_WebAPI.Models
{
    public class TodoItemDTO
    {
        public long ID { get; set; }
        public string? Name { get; set; }
        public bool completed { get; set; }
    }
}
