using Microsoft.AspNetCore.Mvc;

namespace CSharpAssignment1.Controllers
{
    [ApiController]
    [Route("api/q2")]
    public class Q2Controller : ControllerBase
    {
        /// <summary>
        /// This method returns hello to the person whose name is in the URL.
        /// </summary>
        /// <param name="name">The name to greet</param>
        /// <returns>A greeting message</returns>
        /// <example>GET /api/q2/greeting?name=Gary -> "Hi Gary!"</example>
        /// <example>GET /api/q2/greeting?name=Ren%C3%A9e -> "Hi Renée!"</example>
        [HttpGet("greeting")]
        public string GetGreeting([FromQuery] string name)
        {
            return $"Hi {name}!";
        }
    }
}
