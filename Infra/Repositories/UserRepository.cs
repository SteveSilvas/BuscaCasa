using Authenticator.Context;
using Domain.DTOs;
using Domain.Entities;
using Domain.Enuns;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PostgresDbContext _dbContext;
        public UserRepository(PostgresDbContext mongoDbContext)
        {
            _dbContext = mongoDbContext;
        }
        public async Task<User?> GetAsync(int userId)
        {
            try
            {
                return await _dbContext.Users
             .Where(u => u.Id == userId)
             .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar à base de dados. {0}", ex);
            }

        }

        public async Task<int> Signup(SignupUserDTO signupUserDTO)
        {
            try
            {

                User user = new User
                {
                    Name = signupUserDTO.Name,
                    Email = signupUserDTO.Email,
                    PasswordHash = new byte[0],
                    PasswordSalt = new byte[0],
                    CreatedAt = DateTime.Now,
                    StatusId = (int)StatusEnum.Active
                };

                _dbContext.Users.Add(user);

                await _dbContext.SaveChangesAsync();

                return user.Id;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar à base de dados. {0}", ex);
            }
        }

        public async Task<User> GetSignin(string email)
        {
            var userInDb = await _dbContext.Users
                .Where(u => u.Email.ToLower() == email.ToLower())
                .FirstOrDefaultAsync();

            if (userInDb == null)
                throw new Exception("Não existe usuário com estas credenciais.");

            return userInDb;
        }

        public async Task<string> Signout(SignoutUserDTO signoutUserDTO)
        {






            return "";
        }
    }
}
