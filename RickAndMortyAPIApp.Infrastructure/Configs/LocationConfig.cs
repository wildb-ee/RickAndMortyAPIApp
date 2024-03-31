using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RickAndMortyAPIApp.Domain.Entities;
using RickAndMortyAPIApp.Infrastructure.Common;

namespace RickAndMortyAPIApp.Infrastructure.Configs;

public class LocationConfig : BaseConfig<LocationEntity>
{
    protected override void Config(EntityTypeBuilder<LocationEntity> builder)
    {
        builder.ToTable("Locations", schema: "public");
        builder.Property(x => x.Residents)
            .HasConversion(
                v => string.Join(',', v), // Convert List<string> to string
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList() // Convert string back to List<string>
            );
    }
}