using Microsoft.AspNetCore.Mvc;
namespace TWTodoList.Controllers;

public class TestController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}