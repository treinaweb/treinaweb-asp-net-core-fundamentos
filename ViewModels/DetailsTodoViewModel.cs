using TWTodoList.Models;

namespace TWTodoList.ViewModels;

public class DetailsTodoViewModel
{
    public Todo Todo { get; set; } = null!;
    public string PageTitle { get; set; } = string.Empty;
}