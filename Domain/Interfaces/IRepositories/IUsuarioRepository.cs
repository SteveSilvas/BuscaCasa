using Domain.DTOs;
using Domain.Entities;

namespace Domain.Interfaces.IRepositories
{
    public interface IUsuarioRepository
    {
        Task<UsuarioDTO?> GetAsync(long userId);
        Task<long> Signup(SignupUserDTO signupUserDTO);

        Task<UsuarioDTO> GetSignin(string email);

        Task<string> Signout(SignoutUserDTO signoutUserDTO);
    }
}
