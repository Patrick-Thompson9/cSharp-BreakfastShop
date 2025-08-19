using Microsoft.AspNetCore.Mvc;

namespace BreakfastShop.Controllers;

public class ErrorsController : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        return Problem(
            detail: "An unexpected error occurred.",
            statusCode: 500,
            title: "Internal Server Error"
        );
    }
}