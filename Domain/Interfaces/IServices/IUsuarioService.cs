using Domain.DTOs;

namespace Domain.Interfaces.IServices
{
    public interface IUsuarioService
    {
        Task<UsuarioDTO?> GetById(long userId);
        Task<long> Signup(SignupUserDTO signupUserDTO);
        Task<string> Signin(SigninUserDTO signinUserDTO);
    }
}
