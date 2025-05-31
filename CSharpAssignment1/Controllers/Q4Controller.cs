using Microsoft.AspNetCore.Mvc;

namespace CSharpAssignment1.Controllers
{
    [ApiController]
    [Route("api/q4")]
    public class Q4Controller : ControllerBase
    {
        /// <summary>
        /// This method starts a knock-knock joke.
        /// </summary>
        /// <returns>A string that says "Who's there?"</returns>
        /// <example>POST /api/q4/knockknock -> "Who's there?"</example>
        [HttpPost("knockknock")]
        public string KnockKnock()
        {
            return "Who's there?";
        }
    }
}
