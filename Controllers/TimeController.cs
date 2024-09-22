using lr3.Services;
using Microsoft.AspNetCore.Mvc;

namespace lr3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        private readonly TimeService _timeService;
        private readonly CalcService _calcService;

        public TimeController(TimeService timeService, CalcService calcService)
        {
            _timeService = timeService;
            _calcService = calcService;
        }

        // Метод, який повертає поточний час доби
        [HttpGet("current-time")]
        public IActionResult GetCurrentTimeMessage()
        {
            return Ok(_timeService.GetTimeOfDayMessage());
        }


    }
}