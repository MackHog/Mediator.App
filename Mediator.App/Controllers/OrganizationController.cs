using System.Threading.Tasks;
using Mediator.App.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Mediator.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrganizationController(
            IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _mediator.Send(new GetQuery<Organization>(1));
            return Ok(result.Name);
        }
    }
}
