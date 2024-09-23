using Microsoft.AspNetCore.Mvc;


[Route("Calculate")]
[ApiController]
public class CalculateController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        ViewBag.Message = "TestA";
        return View();
    }

    [HttpGet("Power2")]
    public IActionResult Power2([FromQuery] int value1)
    {
        int result = value1 * value1;
        return Ok(new { result = result });
    }

    [HttpPost("Sum2")]
    public IActionResult Sum2([FromBody] SumRequest request)
    {
        int result = request.Value2 + 2;
        return Ok(new { sum = result });
    }

    [HttpGet("Power2/{value1}")]
    public IActionResult Power2(int value1)
    {
        return Ok(value1 * value1);
    }

    [HttpPost("Sum2WithRoute/{value2}")]
    public IActionResult Sum2WithRoute(int value2)
    {
        int result = value2 + 2;
        return Ok(new { sum = result });
    }
}

public class SumRequest
{
    public int Value2 { get; set; }
}
