using Microsoft.AspNetCore.Mvc;
using TWTodoList.Models;

namespace TWTodoList.Controllers;

public class TestController : Controller
{
    public IActionResult Index()
    {
        var todo = new Todo
        {
            Title = "Estudar ASP .NET Core",
            Description = "Concluir o curso de ASP .NET Core da TreinaWeb"
        };
        ViewBag.Todo = todo;

        TempData["message"] = "Mesagem vinda da action Index";

        return View();
    }

    public IActionResult Message()
    {
        return View();
    }
}