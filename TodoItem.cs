public class TodoItem
{
  public string? Title { get; set; }
  public bool IsDone { get; set; } = false;
  public DateTime? DueDate { get; set; } = null; 
}