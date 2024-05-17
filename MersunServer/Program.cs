using MersunServer.Database;

namespace MersunServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddDbContext<AppDatabase>();

            var app = builder.Build();

            app.MapControllers();

            app.Run();
        }
    }
}
