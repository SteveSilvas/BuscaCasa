using Authenticator.Context;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;
using Domain.Services;
using Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace Authenticator.Configurations.Injections
{
    public static class ConfigureInjections
    {
        public static void Execute(WebApplicationBuilder builder)
        {
            ConfigureDatabase(builder);
            ConfigureRepositories(builder.Services);
            ConfigureServices(builder.Services);
        }

        private static void ConfigureDatabase(WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<PostgresDbContext>(options =>
            {
                options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly("Infra"));
            });
        }


        private static void ConfigureRepositories(IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            ConfigureAutoMapper(services);
            ConfigureScopedServices(services);
            ConfigureControllers(services);
            ConfigureSwagger(services);
        }

        private static void ConfigureAutoMapper(IServiceCollection services)
        {
            //services.AddAutoMapper(typeof(MappingProfile));
        }

        private static void ConfigureScopedServices(IServiceCollection services)
        {
            services.AddScoped<PostgresDbContext>();
            services.AddScoped<IUserService, UserService>();
        }

        private static void ConfigureControllers(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
        }

        private static void ConfigureSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Authenticator",
                    Description = "Application for managing authenticated users",
                    Contact = new OpenApiContact
                    {
                        Name = "Steve Silva",
                        Url = new Uri("https://github.com/SteveSilvas")
                    },
                });
            });
        }

    }
}
