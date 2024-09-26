using lr3.Services;
using Microsoft.AspNetCore.Mvc;

namespace lr3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        private readonly CalcService _calcService;
        private readonly TimeService _timeService;

        public CalcController(CalcService calcService, TimeService timeService)
        {
            _calcService = calcService;
            _timeService = timeService;
        }

        [HttpGet("add")]
        public IActionResult Add(int a, int b)
        {
            return Ok(_calcService.Add(a, b));
        }

        [HttpGet("subtract")]
        public IActionResult Subtract(int a, int b)
        {
            return Ok(_calcService.Subtract(a, b));
        }

        [HttpGet("multiply")]
        public IActionResult Multiply(int a, int b)
        {
            return Ok(_calcService.Multiply(a, b));
        }

        [HttpGet("divide")]
        public IActionResult Divide(int a, int b)
        {
            try
            {
                return Ok(_calcService.Divide(a, b));
            }
            catch (DivideByZeroException ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
