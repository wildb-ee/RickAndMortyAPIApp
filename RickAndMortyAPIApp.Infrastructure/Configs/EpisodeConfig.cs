using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RickAndMortyAPIApp.Domain.Entities;
using RickAndMortyAPIApp.Infrastructure.Common;

namespace RickAndMortyAPIApp.Infrastructure.Configs;

public class EpisodeConfig : BaseConfig<EpisodeEntity>
{
    protected override void Config(EntityTypeBuilder<EpisodeEntity> builder)
    {
        builder.ToTable("Episodes", schema: "public");
        builder.Property(x => x.Characters)
            .HasConversion(
                v => string.Join(',', v), // Convert List<string> to string
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList() // Convert string back to List<string>
            );
    }
}