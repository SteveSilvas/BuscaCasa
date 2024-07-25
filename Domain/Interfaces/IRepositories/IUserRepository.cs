using Domain.DTOs;
using Domain.Entities;

namespace Domain.Interfaces.IRepositories
{
    public interface IUserRepository
    {
        Task<User?> GetAsync(int userId);
        Task<int> Signup(SignupUserDTO signupUserDTO);

        Task<User> GetSignin(string email);

        Task<string> Signout(SignoutUserDTO signoutUserDTO);
    }
}
