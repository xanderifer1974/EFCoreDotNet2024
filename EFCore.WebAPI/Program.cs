using EFCore.Data;
using Microsoft.EntityFrameworkCore;

namespace EFCore.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Conexão com o banco de dados
            string connectionString = builder.Configuration.GetConnectionString("SqlConnection");

            var SqlConnectionConfiguration = new SqlConfiguration(connectionString);

            builder.Services.AddSingleton(SqlConnectionConfiguration);

            builder.Services.AddDbContext<HeroiContext>(options =>
                options.UseSqlServer(SqlConnectionConfiguration.ConnectionString));

            // Add services to the container.

            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
