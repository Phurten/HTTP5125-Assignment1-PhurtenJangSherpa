using Microsoft.AspNetCore.Mvc;

namespace CSharpAssignment1.Controllers;

[ApiController]
[Route("api/q2")]
public class Q2Controller : ControllerBase
{
    /// <summary>
    /// This method returns a personalized greeting for a given name
    /// </summary>
    /// <param name="name">The name we use to greet</param>
    /// <returns>A greeting string</returns>
    /// <example> GET: api/q2/greeting?name=Gary</example>
    [HttpGet(template: "greeting")]
    public string GetGreeting(string name)
    {
        string Message = "Hi " + name + "!";
        return Message; 
    }
}