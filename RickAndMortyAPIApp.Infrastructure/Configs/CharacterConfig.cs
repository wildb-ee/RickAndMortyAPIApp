using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RickAndMortyAPIApp.Domain.Entities;
using RickAndMortyAPIApp.Infrastructure.Common;

namespace RickAndMortyAPIApp.Infrastructure.Configs;

public class CharacterConfig : BaseConfig<CharacterEntity>
{
    protected override void Config(EntityTypeBuilder<CharacterEntity> builder)
    {
        builder.ToTable("Characters", schema: "public");
        builder.OwnsOne(a => a.Location, location =>
        {
            location.Property(p => p.Name);
            location.Property(p => p.Url);
        });
        builder.OwnsOne(a => a.Origin, origin =>
        {
            origin.Property(p => p.Name);
            origin.Property(p => p.Url);
        });

        builder.Property(x => x.Episode)
            .HasConversion(
                v => string.Join(',', v), // Convert List<string> to string
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList() // Convert string back to List<string>
            );

    }
    
}