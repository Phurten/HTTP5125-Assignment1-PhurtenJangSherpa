using Microsoft.AspNetCore.Mvc;

namespace CSharpAssignment1.Controllers;

[ApiController]
[Route("api/q1")]
public class Q1Controller : ControllerBase
{
    /// <summary>
    /// This method returns a welcome message.
    /// </summary>
    /// <returns>A welcome string</returns>
    /// <example>GET /api/q1/welcome</example>
    [HttpGet(template: "welcome")]
    public string GetWelcome()
    {
        return "Welcome to 5125!";
    }
}
