using Microsoft.AspNetCore.Mvc;

namespace CSharpAssignment1.Controllers
{
    [ApiController]
    [Route("api/q6")]
    public class Q6Controller : ControllerBase
    {
        /// <summary>
        /// This method calculates the area of a regular hexagon with a side length of 2× the input.
        /// </summary>
        /// <param name="side">The original side length (must be greater than 0)</param>
        /// <returns>The area of the hexagon</returns>
        /// <example>GET /api/q6/hexagon?side=1 -> 2.59...</example>
        /// <example>GET /api/q6/hexagon?side=1.5 -> 5.84...</example>
        /// <example>GET /api/q6/hexagon?side=20 -> 1039.23...</example>
        [HttpGet("hexagon")]
        public double GetHexagonArea([FromQuery] double side)
        {
            return 3 * Math.Sqrt(3) / 2 * Math.Pow(side, 2);
        }
    }
}
