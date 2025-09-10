using apiRest.Models;
using apiRest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiRest.Controllers;
[Route("api/")]
[ApiController]
public class OrderController : ControllerBase
{
    OrderService orderService = new OrderService();

    [HttpGet("order")]
    public IActionResult getOrder()
    {
        Console.WriteLine("getOrder");

        return Ok(new OrderModelDTO());
    }

    [HttpPost("order")]
    public IActionResult postOrder([FromBody] OrderModelDTO orderDTO)
    {
        Console.WriteLine("postOrder");



        return Ok(orderDTO);
    }
}
