using ClassLibrary1.IRepositories;
using Microsoft.Extensions.Configuration;
using RickAndMortyAPIApp.Auth.Handlers;
using RickAndMortyAPIApp.Domain.Entities;
using RickAndMortyAPIApp.Domain.SeedWork;
using RickAndMortyAPIApp.Infrastructure.DTOs;
using RickAndMortyAPIApp.Infrastructure.Mappings;
using RickAndMortyAPIApp.Infrastructure.Repositories;
using RickAndMortyAPIApp.Infrastructure.Services;
using RickAndMortyAPIApp.Parser;
using RickAndMortyAPIApp.Parser.Handlers;

namespace RickAndMortyAPIApp.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Refit;

public static class DIExtension
{
    public static IServiceCollection AddCommonServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddAutoMapper(typeof(NamedAPIResourceMapping).Assembly);
        services.AddAutoMapper(typeof(CharacterMapping).Assembly);
        services.AddAutoMapper(typeof(EpisodeMapping).Assembly);
        services.AddAutoMapper(typeof(LocationMapping).Assembly);
        services.AddAutoMapper(typeof(UserMapping).Assembly);
        
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        
        services.AddScoped<IRepository<CharacterEntity>,CharacterRepository>();
        services.AddScoped<IRepository<EpisodeEntity>,EpisodeRepository>();
        services.AddScoped<IRepository<LocationEntity>,LocationRepository>();
        services.AddScoped<IRepository<MessageEntity>,MessageRepository>();
        services.AddScoped<IRepository<UserEntity>,UserRepository>();

        
        services.AddRefitClient<IReferencesAPI>().ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler(){
                AllowAutoRedirect = false,
                ServerCertificateCustomValidationCallback = (message, cert, chain, sslErrors) => true
            })
            .ConfigureHttpClient(c =>{
                c.BaseAddress = new Uri(config["ReferencesApi:ApiEndpoint"] ?? string.Empty);
                c.Timeout = TimeSpan.FromMinutes(30);
            });

        
        services.AddTransient<ExtractLocationHandler>();
        services.AddTransient<ExtractEpisodeHandler>();
        services.AddTransient<ExtractCharacterHandler>();
        
        services.AddTransient<RegistrationHandler>();
        services.AddTransient<LoginHandler>();
        
        services.AddScoped<ReferencesManagerService>();
        services.AddScoped<AuthService>();

        return services;
    }

}