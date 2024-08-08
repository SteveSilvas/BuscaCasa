using Domain.DTOs;
using Domain.Entities;
using Domain.Helpers;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;

namespace Domain.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<UsuarioDTO?> GetById(long userId)
        {
            try
            {
                return await _repository.GetAsync(userId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro inesperado: {ex.Message}");
            }
        }

        public async Task<long> Signup(SignupUserDTO signupUserDTO)
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

                return await _repository.Signup(signupUserDTO);
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
                UsuarioDTO user = await _repository.GetSignin(signinUserDTO.Email);

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
