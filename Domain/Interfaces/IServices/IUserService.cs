using Domain.DTOs;
using Domain.Entities;

namespace Domain.Interfaces.IServices
{
    public interface IUserService
    {
        Task<User?> GetById(int userId);
        Task<int> Signup(SignupUserDTO signupUserDTO);
        Task<string> Signin(SigninUserDTO signinUserDTO);
    }
}
