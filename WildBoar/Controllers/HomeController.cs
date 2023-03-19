
using Microsoft.AspNetCore.Mvc;

namespace WildBoar.Controllers;

[ApiController]
public class HomeController : ControllerBase
{
    public IActionResult Index()
    {
        return Ok("Hello World!");
    }
}
