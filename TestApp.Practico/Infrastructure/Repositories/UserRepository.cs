using Microsoft.EntityFrameworkCore;
using System.Linq;
using TestApp.Practico.Application.DTOs;
using TestApp.Practico.Application.Interfaces;
using TestApp.Practico.Domain;
using TestApp.Practico.Infrastructure.Data;

namespace TestApp.Practico.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;

        }

        public async Task<LoginResult?> ValidateUserAsyc(string username, string password, CancellationToken cancellationToken)
        {

            try
            {
                var resultado = await _context.Database
                    .SqlQuery<LoginResult>(
                        $"EXEC sp_ValidarUsuario {username}, {password}")
                    .ToListAsync(cancellationToken);

                return resultado.FirstOrDefault(); ;
            }
            catch (Exception ex)
            {

                throw (new Exception(ex.Message));
            }



        }
    }
}
