using MediatR;
using TestApp.Practico.Application.DTOs;

namespace TestApp.Practico.Infrastructure.commands
{
    public record LoginCommand(string Username, string Password)
        : IRequest<LoginResponseDto>;

}
