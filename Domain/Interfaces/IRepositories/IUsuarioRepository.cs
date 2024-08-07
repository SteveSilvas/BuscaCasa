using Domain.DTOs;
using Domain.Entities;

namespace Domain.Interfaces.IRepositories
{
    public interface IUsuarioRepository
    {
        Task<Usuario?> GetAsync(long userId);
        Task<long> Signup(SignupUserDTO signupUserDTO);

        Task<Usuario> GetSignin(string email);

        Task<string> Signout(SignoutUserDTO signoutUserDTO);
    }
}
