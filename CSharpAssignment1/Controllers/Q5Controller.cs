using Microsoft.AspNetCore.Mvc;

namespace CSharpAssignment1.Controllers
{
    [ApiController]
    [Route("api/q5")]
    public class Q5Controller : ControllerBase
    {
        /// <summary>
        /// This method accepts a secret number and repeats it back.
        /// </summary>
        /// <param name="secret">The secret number sent in the request body</param>
        /// <returns>A message saying "Shh.. the secret is {secret}"</returns>
        /// <example>POST /api/q5/secret with body 5 -> "Shh.. the secret is 5"</example>
        /// <example>POST /api/q5/secret with body -200 -> "Shh.. the secret is -200"</example>
        [HttpPost("secret")]
        public string PostSecret([FromBody] int secret)
        {
            return $"Shh.. the secret is {secret}";
        }
    }
}
