using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;
using TestApp.Practico.Application.DTOs;
using TestApp.Practico.Infrastructure.commands;

namespace TestApp.Practico.Controllers
{
    public class AuthController : ControllerBase
    {

        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;

        }

        [HttpPost("login")]
        public async Task<ActionResult<LoginResponseDto>> Login([FromBody] LoginCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _mediator.Send(command, cancellationToken);

                return Ok(result);
            }
            catch (Exception exception)
            {
                return BadRequest(new
                {
                    Message = exception.Message
                });

            }
        }
    }
}
