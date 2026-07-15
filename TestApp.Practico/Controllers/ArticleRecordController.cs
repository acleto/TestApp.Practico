using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApp.Practico.Domain;
using TestApp.Practico.Infrastructure.commands;

namespace TestApp.Practico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleRecordController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ArticleRecordController(IMediator mediator)
        {
            _mediator = mediator;

        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<ArticleRecord>> Create([FromBody] CreateArticleRecordCommand command)
        {
            var itemRecord = await _mediator.Send(command);

            return Ok(itemRecord);
        }

    }
}
