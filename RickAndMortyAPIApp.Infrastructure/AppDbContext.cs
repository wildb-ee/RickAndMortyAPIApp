using Microsoft.EntityFrameworkCore;
using RickAndMortyAPIApp.Domain.Entities;
using RickAndMortyAPIApp.Infrastructure.Configs;

namespace RickAndMortyAPIApp.Infrastructure;

public class AppDbContext : DbContext
{
    public DbSet<CharacterEntity> Characters { get; set; }
    public DbSet<EpisodeEntity> Episodes { get; set; }
    public DbSet<LocationEntity> Locations { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new CharacterConfig());
        modelBuilder.ApplyConfiguration(new EpisodeConfig());
        modelBuilder.ApplyConfiguration(new LocationConfig());
        modelBuilder.ApplyConfiguration(new MessageConfig());
        modelBuilder.ApplyConfiguration(new UserConfig());

    }
}