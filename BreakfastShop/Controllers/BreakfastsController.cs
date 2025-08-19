using Microsoft.AspNetCore.Mvc;
using BreakfastShop.Contracts.Breakfast;

namespace BreakfastShop.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BreakfastsController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request)
    {
        return Ok(request);
    }

    [HttpGet("/breakfasts/{id:guid}")]
    public IActionResult GetBreakfast(Guid id)
    {
        return Ok(id);
    }

    [HttpPut("/breakfasts/{id:guid}")]
    public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastRequest request)
    {
        return Ok(request);
    }

    [HttpDelete("/breakfasts/{id:guid}")]
    public IActionResult DeleteBreakfast(Guid id)
    {
        return Ok(id);
    }
}