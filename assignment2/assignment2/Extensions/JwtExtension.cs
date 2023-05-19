using Microsoft.IdentityModel.Tokens;

namespace assignment2.Extensions
{
    public static class JwtExtension
    {
        public static void ConfigureJwtAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication("Bearer")
                    .AddJwtBearer("Bearer", options =>
                    {
                        options.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidateIssuer = true, 
                            ValidIssuer = configuration["JwtSettings:Issuer"], 

                            ValidateAudience = true, 
                            ValidAudience = configuration["JwtSettings:Audience"], 

                            ValidateLifetime = true, 

                            ValidateIssuerSigningKey = true, 
                            IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(configuration["JwtSettings:Key"])) 
                        };
                    });
        }
    }
}
