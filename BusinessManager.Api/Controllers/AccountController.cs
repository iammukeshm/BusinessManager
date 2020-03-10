using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessManager.Application.Features.Account.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusinessManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ApiController
    {
        [HttpPost("register")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<ActionResult> RegisterAsync(RegisterUserCommand command)
        {
            await Mediator.Send(command);
            return Ok();
        }
        /// <summary>
        /// Generates a Bearer Token for the User.
        /// </summary>
        /// <remarks>
        /// Note that the key is a GUID and not an integer.
        /// </remarks>
        /// <param name="command">Request</param>
        /// <returns>New Created Todo Item</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>
        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync(LoginUserCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}