using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jenkins_Calculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("add")]
        public IActionResult Add(double num1, double num2)
        {
            double result = num1 + num2;
            return Ok(result);
        }

        [HttpGet("subtract")]
        public IActionResult Subtract(double num1, double num2)
        {
            double result = num1 - num2;
            return Ok(result);
        }

        [HttpGet("multiply")]
        public IActionResult Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            return Ok(result);
        }

        [HttpGet("divide")]
        public IActionResult Divide(double num1, double num2)
        {
            if(num2 == 0)
            {
                return BadRequest("Cannot divide by Zero");
            }

            double result = num1 / num2;
            return Ok(result);
        }
    }
}
