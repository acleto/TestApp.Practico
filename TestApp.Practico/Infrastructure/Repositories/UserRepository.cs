using Microsoft.EntityFrameworkCore;
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

        public async Task<User?> ValidateUserAsyc(string username, string password, CancellationToken cancellationToken)
        {

            //return await _context.Users
            //                .AsNoTracking()
            //                .FirstOrDefaultAsync(
            //                    user =>
            //                        user.UserName == username &&
            //                        user.Password == password,
            //                    cancellationToken);

            return await Task.FromResult(new User
            {
                UserName = username,
            });
        }
    }
}
