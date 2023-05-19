using assignment2.DTOs;
using assignment2.Exceptions;
using assignment2.Interface;
using assignment2.Model;
using assignment2.Repository;
using System.IdentityModel.Tokens.Jwt;
using System.Net;

namespace assignment2.Service
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public bool CheckUserCredentials(LoginDTO loginDTO)
        {
            if (string.IsNullOrEmpty(loginDTO.UserName) ||
                string.IsNullOrEmpty(loginDTO.Password))
            {
                throw new CustomException("Username and/or Password not specified", (int)HttpStatusCode.BadRequest);
            }
            else if (UserRepository.RegisteredUsers.TryGetValue(loginDTO.UserName, out var registeredUser))
            {
                return registeredUser.Password.Equals(loginDTO.Password);
            }
            else throw new CustomException("Unauthorized user", (int)HttpStatusCode.BadRequest);
        }

        public void RegisterUser(RegisterDTO registerDTO)
        {
            User user=new User(registerDTO.UserName,registerDTO.Email,registerDTO.Password,registerDTO.Name,registerDTO.AddressLine1,registerDTO.AddressLine2,registerDTO.PhoneNumber);

          

            if (UserRepository.RegisteredUsers.Values.Any(u => u.Email.Equals(registerDTO.Email, StringComparison.OrdinalIgnoreCase)))
            {
                throw new CustomException("Cannot add user as email ID already exists.", (int)HttpStatusCode.BadRequest);
            }
            if (!UserRepository.RegisteredUsers.TryAdd(user.UserName, user))
            {
                throw new CustomException("Cannot add user as username already added.", (int)HttpStatusCode.BadRequest);
            }

        }

        public UserDetailsResponseDTO GetUserDetails()
        {
            // using authorization header to get the username from the claims of the token
            var authorizationHeader = _httpContextAccessor?.HttpContext?.Request.Headers["Authorization"];

            if (string.IsNullOrEmpty(authorizationHeader))
            {
                throw new CustomException("Authorization header is missing",(int)HttpStatusCode.BadRequest);
            }

            // Getting the Bearer token
            var token = authorizationHeader?.ToString().Replace("Bearer ", string.Empty);

            // Validatig and decoding the token
            var tokenHandler = new JwtSecurityTokenHandler();
            var decodedToken = tokenHandler.ReadJwtToken(token);

            // Getting the claims 
            var claims = decodedToken.Claims;

            // getting the user name from claims
            var nameClaim = claims.FirstOrDefault(c => c.Type == "username");
            string username = nameClaim?.Value == null ? "" : nameClaim.Value;


            // If user doesnot exists
            if (!UserRepository.RegisteredUsers.ContainsKey(username))
            {
                throw new CustomException("User does not exists", (int)HttpStatusCode.BadRequest);

            }
            User user = UserRepository.RegisteredUsers[username];

            UserDetailsResponseDTO userDetailsResponse =new UserDetailsResponseDTO(user.UserName,user.Email,user.Name,user.AddressLine1,user.AddressLine2,user.PhoneNumber);
            // Parsing the data to the DTO
            return userDetailsResponse;
        }
    }
}
