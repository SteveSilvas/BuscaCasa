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
            services.AddScoped<ICorretorRepository, CorretorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IEstadoRepository, EstadoRepository>();
            services.AddScoped<IFavoritoRepository, FavoritoRepository>();
            services.AddScoped<IImobiliariaRepository, ImobiliariaRepository>();
            services.AddScoped<IImovelRepository, ImovelRepository>();
            services.AddScoped<IMunicipioRepository, MunicipioRepository>();
            services.AddScoped<IPropriedadeRepository, PropriedadeRepository>();
            services.AddScoped<IProprietarioRepository, ProprietarioRepository>();
            services.AddScoped<IRegiaoRepository, RegiaoRepository>();
            services.AddScoped<IStatusImovelRepository, StatusImovelRepository>();
            services.AddScoped<IStatusUsuarioRepository, StatusUsuarioRepository>();
            services.AddScoped<IStatusVisitaRepository, StatusVisitaRepository>();
            services.AddScoped<ITipoComercializacaoRepository, TipoComercializacaoRepository>();
            services.AddScoped<ITipoComercializacaoImovelRepository, TipoComercializacaoImovelRepository>();
            services.AddScoped<ITipoConstrucaoImovelRepository, TipoConstrucaoImovelRepository>();
            services.AddScoped<ITipoUsoImovelRepository, TipoUsoImovelRepository>();
            services.AddScoped<ITipoUsuarioRepository, TipoUsuarioRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IVisitaRepository, VisitaRepository>();
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
            services.AddScoped<ICorretorService, CorretorService>();
            services.AddScoped<IEnderecoService, EnderecoService>();
            services.AddScoped<IEstadoService, EstadoService>();
            services.AddScoped<IFavoritoService, FavoritoService>();
            services.AddScoped<IImobiliariaService, ImobiliariaService>();
            services.AddScoped<IImovelService, ImovelService>();
            services.AddScoped<IMunicipioService, MunicipioService>();
            services.AddScoped<IPropriedadeService, PropriedadeService>();
            services.AddScoped<IProprietarioService, ProprietarioService>();
            services.AddScoped<IRegiaoService, RegiaoService>();
            services.AddScoped<IStatusImovelService, StatusImovelService>();
            services.AddScoped<IStatusUsuarioService, StatusUsuarioService>();
            services.AddScoped<IStatusVisitaService, StatusVisitaService>();
            services.AddScoped<ITipoComercializacaoService, TipoComercializacaoService>();
            services.AddScoped<ITipoComercializacaoImovelService, TipoComercializacaoImovelService>();
            services.AddScoped<ITipoConstrucaoImovelService, TipoConstrucaoImovelService>();
            services.AddScoped<ITipoUsoImovelService, TipoUsoImovelService>();
            services.AddScoped<ITipoUsuarioService, TipoUsuarioService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IVisitaService, VisitaService>();
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
                    Title = "Busca Casa",
                    Description = "API para divulgação de imóveis e agendamento de visitas.",
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
