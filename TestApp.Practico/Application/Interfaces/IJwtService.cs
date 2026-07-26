using TestApp.Practico.Application.DTOs;
using TestApp.Practico.Domain;

namespace TestApp.Practico.Application.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken(string user);
    }
}
