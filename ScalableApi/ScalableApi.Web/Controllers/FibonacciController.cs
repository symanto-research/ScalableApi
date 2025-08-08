using Microsoft.AspNetCore.Mvc;
using Services;

namespace ScalableApi.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class FibonacciController(
    [FromKeyedServices(nameof(RecursiveFibonacciService))]
    IFibonacciService recursiveService,
    [FromKeyedServices(nameof(LinearFibonacciService))]
    IFibonacciService linearService,
    ILogger<FibonacciController> logger) : ControllerBase
{
    [HttpGet("recursive/{n:int}")]
    public IActionResult GetRecursive(int n)
    {
        var result = recursiveService.Calculate(n);
        return Ok(result);
    }

    [HttpGet("linear/{n:int}")]
    public IActionResult GetLinear(int n)
    {
        var result = linearService.Calculate(n);
        return Ok(result);
    }
}