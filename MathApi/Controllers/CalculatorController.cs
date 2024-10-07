using MathApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MathApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        // Injecting the ICalculatorService into the controller
        private readonly ICalculatorService _calculatorService;

        // Constructor injection of the ICalculatorService
        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        // Action to add two numbers
        [HttpGet("add")]
        public IActionResult Add(double a, double b)
        {
            var result = _calculatorService.Add(a, b); 
            return Ok(result); 
        }

        // Action to subtract two numbers
        [HttpGet("subtract")]
        public IActionResult Subtract(double a, double b)
        {
            var result = _calculatorService.Subtract(a, b); 
            return Ok(result);
        }

        // Action to multiply two numbers
        [HttpGet("multiply")]
        public IActionResult Multiply(double a, double b)
        {
            var result = _calculatorService.Multiply(a, b); 
            return Ok(result);
        }

        // Action to divide two numbers
        [HttpGet("divide")]
        public IActionResult Divide(double a, double b)
        {
            try
            {
                var result = _calculatorService.Divide(a, b); 
                return Ok(result);
            }
            catch (DivideByZeroException ex)
            {
                return BadRequest(ex.Message); 
            }
        }
    }
}
