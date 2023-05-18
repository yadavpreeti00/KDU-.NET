using assignment2.DTOs;
using System.IdentityModel.Tokens.Jwt;

namespace assignment2.Interface
{
    public interface IJwtService
    {
        public string GenerateJwtToken(LoginDTO loginDTO);

    }
}
