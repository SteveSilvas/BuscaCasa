using Authenticator.Context;
using Domain.DTOs;
using Domain.Entities;
using Domain.Enuns;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly PostgresDbContext _dbContext;
        public UsuarioRepository(PostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<UsuarioDTO?> GetAsync(long userId)
        {
            try
            {
                return await _dbContext.Usuarios
                    .Select(u => new UsuarioDTO
                    {
                        ID = userId,
                        Nome = u.Nome,
                        Email = u.Email,
                        PasswordHash = u.PasswordHash,
                        PasswordSalt = u.PasswordSalt,
                        CreatedAt = DateTime.UtcNow,
                        TipoUsuarioID = u.TipoUsuarioID,
                        StatusId = u.StatusId,
                    })
             .Where(u => u.ID == userId)
             .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar à base de dados. {0}", ex);
            }
        }

        public async Task<long> Signup(SignupUserDTO signupUserDTO)
        {
            try
            {
                Usuario user = new Usuario
                {
                    Nome = signupUserDTO.Nome,
                    Email = signupUserDTO.Email,
                    PasswordHash = new byte[0],
                    PasswordSalt = new byte[0],
                    CreatedAt = DateTime.Now,
                    StatusId = (int)StatusUsuarioEnum.Ativo
                };

                _dbContext.Usuarios.Add(user);

                await _dbContext.SaveChangesAsync();

                return user.ID;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar à base de dados. {0}", ex);
            }
        }

        public async Task<UsuarioDTO> GetSignin(string email)
        {
            var userInDb = new UsuarioDTO();
            try
            {
                userInDb = await _dbContext.Usuarios
                    .Select(u => new UsuarioDTO
                    {
                        ID = u.ID,
                        Nome = u.Nome,
                        Email = u.Email,
                        PasswordHash = u.PasswordHash,
                        PasswordSalt = u.PasswordSalt,
                        CreatedAt = DateTime.UtcNow,
                        TipoUsuarioID = u.TipoUsuarioID,
                        StatusId = u.StatusId,
                    })
                .Where(u => u.Email.ToLower() == email.ToLower())
                .FirstOrDefaultAsync();

                if (userInDb == null)
                    throw new Exception("Não existe usuário com estas credenciais.");
            }
            catch (Exception ex)
            {

            }
            return userInDb;
        }

        public async Task<string> Signout(SignoutUserDTO signoutUserDTO)
        {
            return "";
        }
    }
}
