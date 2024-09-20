using Microsoft.AspNetCore.Mvc;

namespace WebAppCalculate.Controllers
{

    [Route("[controller]")]
    [ApiController]

    public class CalculateController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Message = "TestA";
            return View();
        }

        //GET: Calculate/power2/
        [HttpGet("power2/{value1}")]
        public IActionResult Power2(int value)
        {

            return Ok(value * value);
        }


        //POST: Calculate/sum2/
        [HttpPost("sum2/{value2}")]
        public IActionResult sum2(int value)
        {
            int result = value + 2;

            ViewBag.Sumresult = result;


            return Ok(new { sum = value + 2 });
        }


    }
}

