using TWTodoList.Models;

namespace TWTodoList.ViewModels;

public class ListTodoViewModel
{
    public ICollection<Todo> Todos { get; set; } = new List<Todo>();
}