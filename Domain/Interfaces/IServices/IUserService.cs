using Domain.DTOs;
using Domain.Entities;

namespace Domain.Interfaces.IServices
{
    public interface IUserService
    {
        Task<Usuario?> GetById(long userId);
        Task<long> Signup(SignupUserDTO signupUserDTO);
        Task<string> Signin(SigninUserDTO signinUserDTO);
    }
}
