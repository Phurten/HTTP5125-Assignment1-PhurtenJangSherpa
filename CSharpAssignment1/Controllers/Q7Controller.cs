using Microsoft.AspNetCore.Mvc;
using System;

namespace CSharpAssignment1.Controllers
{
    [ApiController]
    [Route("api/q7")]
    public class Q7Controller : ControllerBase
    {
        /// <summary>
        /// This method returns today’s date changed by the number of days given.
        /// </summary>
        /// <param name="days">Number of days to add or subtract</param>
        /// <returns>A date in yyyy-MM-dd format</returns>
        /// <example>GET /api/q7/timemachine?days=1 -> "2025-05-31"</example>
        /// <example>GET /api/q7/timemachine?days=-1 -> "2025-05-29"</example>
        [HttpGet("timemachine")]
        public string GetDate([FromQuery] int days)
        {
            return DateTime.Today.AddDays(days).ToString("yyyy-MM-dd");
        }
    }
}
