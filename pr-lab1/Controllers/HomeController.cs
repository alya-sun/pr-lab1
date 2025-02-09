using Microsoft.AspNetCore.Mvc;

namespace pr_lab1.Controllers;

[ApiController]
[Route("api/home")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello World!\n");
    }
}