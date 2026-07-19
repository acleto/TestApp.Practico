using MediatR;
using TestApp.Practico.Application.DTOs;
using TestApp.Practico.Application.Interfaces;
using TestApp.Practico.Infrastructure.commands;

namespace TestApp.Practico.Application.Handlers
{
    public class LoginHandler : IRequestHandler<LoginCommand, LoginResponseDto>
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtService _jwtService;

        public LoginHandler(IUserRepository userRepository, IJwtService jwtService)
        {
            this._userRepository = userRepository;
            this._jwtService = jwtService;

        }

        public async Task<LoginResponseDto> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var user = await _userRepository.ValidateUserAsyc(request.Username, request.Password, cancellationToken);

                if (user == null)
                {
                    throw new("Usuario o contraseña incorrectos.");
                }

                var token = _jwtService.GenerateToken(user.UserName);

                return new LoginResponseDto
                {
                    Token = token,
                    Username = request.Username,
                };
            }
            catch (Exception ex)
            {

                throw new(ex.Message);
            }

        }

    }
}
