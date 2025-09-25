using apiRest.Models;
using apiRest.Repository;

namespace apiRest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddCors(
                options =>
                    options.AddDefaultPolicy(
                        policy =>
                        {
                            policy.WithOrigins("http://localhost:4200"
                                ).AllowAnyHeader().AllowAnyMethod();
                        }
                    )
            );

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseCors();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
