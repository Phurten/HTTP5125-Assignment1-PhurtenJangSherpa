using Microsoft.AspNetCore.Mvc;

namespace CSharpAssignment1.Controllers
{
    [ApiController]
    [Route("api/q8")]
    public class Q8Controller : ControllerBase
    {
        /// <summary>
        /// This calculates the total cost of an order.
        /// </summary>
        /// <param name="Small">Number of small plushies</param>
        /// <param name="Large">Number of large plushies</param>
        /// <returns>A checkout summary with subtotal, tax, and total</returns>
        /// <example>POST /api/q8/squashfellows with Small=1&Large=1</example>
        /// <example>POST /api/q8/squashfellows with Small=2&Large=1</example>
        /// <example>POST /api/q8/squashfellows with Small=100&Large=100</example>
        [HttpPost("squashfellows")]
        public string PostOrder([FromForm] int Small, [FromForm] int Large)
        {
            double smallTotal = Small * 25.50;
            double largeTotal = Large * 40.50;
            double subtotal = smallTotal + largeTotal;
            double tax = Math.Round(subtotal * 0.13, 2);
            double total = subtotal + tax;

            return $"{Small} Small @ ${Small:0.00} = ${smallTotal:0.00}; " + $"{Large} Large @ ${Large:0.00} = ${largeTotal:0.00}; " + $"Subtotal = ${subtotal:0.00}; Tax = ${tax:0.00} HST; Total = ${total:0.00}";
        }
    }
}
