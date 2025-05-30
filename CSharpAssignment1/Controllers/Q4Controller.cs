using Microsoft.AspNetCore.Mvc;

namespace CSharpAssignment1.Controllers;

[ApiController]
[Route("api/q4")]

public class Q4Controller : ControllerBase
{
    [HttpPost(template: "knockknock")]
    public string KnockKnock()
    {
        return "Who's there?";  
    }

}