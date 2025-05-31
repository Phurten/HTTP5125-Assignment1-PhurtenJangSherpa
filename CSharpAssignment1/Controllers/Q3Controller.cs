using Microsoft.AspNetCore.Mvc;

namespace CSharpAssignment1.Controllers
{
    [ApiController]
    [Route("api/q3")]
    public class Q3Controller : ControllerBase
    {
        /// <summary>
        /// This method calculates the cube of the number in the URL.
        /// </summary>
        /// <param name="baseValue">The number to cube</param>
        /// <returns>The cube of the number</returns>
        /// <example>GET /api/q3/cube/4 -> 64</example>
        /// <example>GET /api/q3/cube/-4 -> -64</example>
        /// <example>GET /api/q3/cube/10 -> 100</example>
        [HttpGet("cube/{baseValue}")]
        public int GetCube(int baseValue)
        {
            return baseValue * baseValue * baseValue;
        }
    }
}
