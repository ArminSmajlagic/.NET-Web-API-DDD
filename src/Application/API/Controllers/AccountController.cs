using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Features.Queries.Accounts;


namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IMediator mediator;
        public AccountController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("GetAccountById")]
        public async Task<IActionResult> GetUserById([FromQuery] int request)
        {

            var result = await mediator.Send(request);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet("GetAllAcconts")]
        public async Task<IActionResult> GetAllUsers([FromQuery] GetAccountsQuery query)
        {
            var result = await mediator.Send(query);

            if (result == null || !result.Any())
                return NotFound();

            return Ok(result);
        }
    }
}
