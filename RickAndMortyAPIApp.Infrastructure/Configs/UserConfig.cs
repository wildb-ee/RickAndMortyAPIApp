using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RickAndMortyAPIApp.Domain.Entities;
using RickAndMortyAPIApp.Infrastructure.Common;

namespace RickAndMortyAPIApp.Infrastructure.Configs;

public class UserConfig : BaseConfig<UserEntity>
{
    protected override void Config(EntityTypeBuilder<UserEntity> builder)
    {
        builder.ToTable("Users", schema: "public");
    }
}