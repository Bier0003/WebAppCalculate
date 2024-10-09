using Microsoft.AspNetCore.Mvc;

using static WebAppCalculate.Models.CalculateModel;



[Route("")]
[ApiController]
public class CalculateController : Controller
{
    // Index action to render the index view
    [HttpGet("")]
    public IActionResult Index()
    {
        ViewBag.Message = "Welcome to the Calculate Page";
        return View(); // This will return the Index.cshtml view
    }

    // GET method to display the Sum2 form
    [HttpGet("sum2")]
    public IActionResult Sum2Form()
    {
        return View("Sum2"); // Ensure this view exists
    }
    [HttpGet("power2")]
    public IActionResult Power2Form()
    {
        return View("Power2"); // Ensure this view exists
    }

    // Power2 method to calculate the power of a number
    [HttpPost("power2")]
    public IActionResult Power2([FromForm] PowerRequest body)
    {
        int result = body.Value1 * body.Value1; // Squaring the number
        ViewBag.Result = result; // Store the result in ViewBag
        ViewBag.Message = "Power2 Calculation Result";
        return View("power2"); // Return to Index view after calculation
    }

    // POST method for Sum2 calculation
    [HttpPost("sum2")]
    public IActionResult Sum2([FromForm] SumRequest request)
    {
        int result = request.Value2 + 2; // Adding 2 to the given number
        ViewBag.Result = result; // Store the result in ViewBag to display in the view
        return View("Sum2"); // Return to Sum2 view after calculation
    }

    // Sum2WithRoute method to add 2 to the number passed in the route
    [HttpPost("sum2withroute/{value2}")]
    public IActionResult Sum2WithRoute(int value2)
    {
        int result = value2 + 2;
        return Ok(new { sum = result }); // Return JSON result
    }
}

//public class SumRequest
//{
//    public int Value2 { get; set; }
//}

//public class PowerRequest
//{
//    public int Value1 { get; set; }
//}




