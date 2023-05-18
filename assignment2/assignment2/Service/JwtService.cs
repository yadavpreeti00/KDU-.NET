using assignment2.DTOs;
using assignment2.Exceptions;
using assignment2.Interface;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace assignment2.Service
{
    public class JwtService : IJwtService
    {
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;
        public JwtService(IConfiguration configuration, IUserService userService)
        {
            _configuration = configuration;
            _userService = userService;
        }
        public string GenerateJwtToken(LoginDTO loginDTO)
        {
            
            bool isUserValid=_userService.CheckUserCredentials(loginDTO);

            if(isUserValid)
            {
                var claims = new List<Claim>
                {
                    new Claim("username",loginDTO.UserName)
                };

                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Key"]));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var jwtSecurityToken = new JwtSecurityToken(
                    issuer: _configuration["JwtSettings:Issuer"],
                    audience: _configuration["JwtSettings:Audience"],
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(10),
                    signingCredentials: signinCredentials
                );
                return new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            }
            throw new Exception();
        }
    }
}
