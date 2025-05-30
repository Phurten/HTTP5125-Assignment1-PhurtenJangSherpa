using Microsoft.AspNetCore.Mvc;

namespace CSharpAssignment1.Controllers;

[Route("api/q3")]
[ApiController]

public class Q3Controller : ControllerBase
{
    /// <summary>
    /// This method returns the cube of given integers
    /// </summary>
    /// <param name="value">The value to cube</param>
    /// <returns>The cube of input</returns>
    /// <example>GET /api/q3/cube/4</exapmple>
    [HttpGet(template: "cube/{value}")]
    public int GetCube(int value)
    {
        int cubeValue = value * value * value;
        return cubeValue;
    }
}
