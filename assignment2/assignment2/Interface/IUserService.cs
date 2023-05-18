using assignment2.DTOs;

namespace assignment2.Interface
{
    public interface IUserService
    {
        public void RegisterUser(RegisterDTO registerDTO);
        public bool CheckUserCredentials(LoginDTO loginDTO);
        public UserDetailsResponseDTO GetUserDetails();

    }
}
