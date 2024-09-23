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

        public IActionResult Power2()
        {
            return View();
        }



        //GET: Calculate/power2/
        [HttpGet("power2/{value1}")]
        public IActionResult Power2(int value1)
        {
           
            return Ok(value1 * value1);
          
        }


        //POST: Calculate/sum2/
        [HttpPost("sum2/{value2}")]
        public IActionResult sum2(int value2)
        {
            int result = value2 + 2;

            ViewBag.Sumresult = result;


            return Ok(new { sum = value2 + 2 });
            return View();
        }


    }
}

