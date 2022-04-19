namespace TodoApi.Models
{
    //Data Transfer Object: prevent over-posting
    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
