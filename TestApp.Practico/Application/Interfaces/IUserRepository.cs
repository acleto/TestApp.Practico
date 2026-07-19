using TestApp.Practico.Application.DTOs;
using TestApp.Practico.Domain;

namespace TestApp.Practico.Application.Interfaces
{
    public interface IUserRepository
    {

         Task<LoginResult?> ValidateUserAsyc(string username, string password, CancellationToken cancellationToken);

    }
}
