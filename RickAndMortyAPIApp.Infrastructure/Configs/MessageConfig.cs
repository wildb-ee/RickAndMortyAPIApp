using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RickAndMortyAPIApp.Domain.Entities;
using RickAndMortyAPIApp.Infrastructure.Common;

namespace RickAndMortyAPIApp.Infrastructure.Configs;

public class MessageConfig : BaseConfig<MessageEntity>
{
    protected override void Config(EntityTypeBuilder<MessageEntity> builder)
    {
        builder.ToTable("Messages", schema: "public");
    }
}