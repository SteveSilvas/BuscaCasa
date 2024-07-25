using Domain.DTOs;
using Domain.Entities;
using Domain.Helpers;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;

namespace Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User?> GetById(int userId)
        {
            try
            {
                return await _userRepository.GetAsync(userId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro inesperado: {ex.Message}");
            }
        }

        public async Task<int> Signup(SignupUserDTO signupUserDTO)
        {
            try
            {
                if (!EmailHandler.IsValid(signupUserDTO.Email))
                    throw new ArgumentException("Email inválido.");

                if (signupUserDTO.Password.Length < 8)
                    throw new ArgumentException("Senha muito curta, digite ao menos 8 dígitos.");

                if (!PasswordHandler.IsStrong(signupUserDTO.Email))
                    throw new ArgumentException("Senha muito fraca, \n" +
                        "a senha deve conter ao menos uma letra minúscula, \n" +
                        " letra maiúscula, número e caracter especial.");

                return await _userRepository.Signup(signupUserDTO);
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro inesperado: {ex.Message}");
            }
        }

        public async Task<string> Signin(SigninUserDTO signinUserDTO)
        {
            try
            {
                User user = await _userRepository.GetSignin(signinUserDTO.Email);

                if (user == null)
                    throw new FileNotFoundException("User not found.");

                return "token";
            }
            catch (ArgumentException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro inesperado: {ex.Message}");
            }
        }
    }
}
