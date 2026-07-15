using TestApp.Practico.Domain;

namespace TestApp.Practico.Application.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken(User user);
    }
}
