using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Receitas.Domain.Mapper;
using Receitas.Domain.Services;
using Receitas.Domain.Services.Receita;
using Receitas.Domain.Services.ReceitaFotos;
using Receitas.Infra.Data;
using Receitas.Infra.Repositories.Receita;
using Receitas.Infra.Repositories.ReceitaFotos;
using Receitas.SharedKernel.Notification;

namespace Receitas.Api.Infra
{
    public static class DependencyResolver
    {
        public static void Resolve(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(m =>
            {
                m.AddProfile(new AutoMapperProfile());
            });

            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<INotification, Notification>();
            services.AddDbContext<ApplicationContext>();

            Context(services);
            Repositories(services);
            Services(services);
        }
        public static void Context(IServiceCollection services)
        {
            services.AddScoped<ApplicationContext, ApplicationContext>();

        }

        public static void Repositories(IServiceCollection services)
        {
            services.AddScoped<IReceitaRepository, ReceitaRepository>();
            services.AddScoped<IReceitaFotosRepository, ReceitaFotosRepository>();
        }

        public static void Services(IServiceCollection services)
        {
            services.AddScoped<IReceitaService, ReceitaService>();
            services.AddScoped<IReceitaFotosService, ReceitaFotosService>();
        }
    }
}
