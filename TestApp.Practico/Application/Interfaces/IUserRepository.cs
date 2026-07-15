using TestApp.Practico.Domain;

namespace TestApp.Practico.Application.Interfaces
{
    public interface IUserRepository
    {

         Task<User?> ValidateUserAsyc(string username, string password, CancellationToken cancellationToken);

    }
}
