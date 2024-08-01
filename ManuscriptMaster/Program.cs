using ManuscriptMaster.DAL;
using Microsoft.EntityFrameworkCore;

namespace ManuscriptMaster
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);


			builder.Services.AddControllers();
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen(); 
			builder.Services.AddDbContext<ManuscriptMasterDBContext>(
				options =>
				{
					options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConntection"));
				});

			builder.Services.InitialiseRepositories();
			builder.Services.InitialiseServices();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}
