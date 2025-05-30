using Microsoft.AspNetCore.Mvc;

namespace CSharpAssignment1.Controllers;

[ApiController]
[Route("api/q5")]

public class Q5Controller : ControllerBase
{
    /// <summary>
    /// This method tells the secret
    /// </summary>
    /// <param name="secret"></param>
    /// <returns></returns>
    [HttpPost(template: "secret")]
    public string PostSecret(int secret)
    {
        string secretMessage = "Shh.. secret is " + secret;
        return secretMessage;
    }
}