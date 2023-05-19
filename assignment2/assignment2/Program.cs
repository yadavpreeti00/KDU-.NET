using assignment2.Extensions;
using assignment2.Interface;
using assignment2.Middlewares;
using assignment2.Service;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();

        // Configure authentication
        builder.Services.ConfigureJwtAuthentication(builder.Configuration);

        // Configure authorization
        builder.Services.AddAuthorization();

        //builder.Services.AddSwaggerGen();

        // Add Swagger and configure authorization
        builder.Services.ConfigureSwagger();

        builder.Services.AddSingleton<IJwtService,JwtService>();
        builder.Services.AddSingleton<IUserService,UserService>();
        builder.Services.AddTransient<ExceptionHandlingMiddleware>();

        builder.Services.AddHttpContextAccessor();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseMiddleware<ExceptionHandlingMiddleware>();

        // Enable authentication
        app.UseAuthentication();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}