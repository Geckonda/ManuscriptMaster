using ManuscriptMaster.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Configuration;
using System.Text;

namespace ManuscriptMaster
{
	public static class StartUpInit
	{
		public static void InitialiseRepositories(this IServiceCollection services)
		{

		}
		public static void InitialiseServices(this IServiceCollection services)
		{

		}
		public static void ConfigureServices(this IServiceCollection services)
		{
			// JWT Authentication
			services.AddAuthentication(options =>
			{
				options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
			})
			.AddJwtBearer(options =>
			{
				options.TokenValidationParameters = new TokenValidationParameters
				{
					ValidateIssuer = true,
					ValidateAudience = true,
					ValidateLifetime = true,
					ValidateIssuerSigningKey = true,
					ValidIssuer = Configuration["JwtSettings:Issuer"],
					ValidAudience = Configuration["JwtSettings:Audience"],
					IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtSettings:SecretKey"]))
				};
			});

			// Register JwtService
			services.AddSingleton<JwtService>();
		}
	}
}
