using Microsoft.AspNetCore.Mvc;
using TWTodoList.Contexts;
using TWTodoList.ViewModels;

namespace TWTodoList.Controllers;

public class TodoController : Controller
{
    private readonly AppDbContex _context;

    public TodoController(AppDbContex context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var todos = _context.Todos.ToList();
        var viewModel = new ListTodoViewModel { Todos = todos };
        ViewData["Title"] = "Lista de Tarefas";
        return View(viewModel);
    }
}