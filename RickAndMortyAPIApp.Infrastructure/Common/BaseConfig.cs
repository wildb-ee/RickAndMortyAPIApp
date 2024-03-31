using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RickAndMortyAPIApp.Domain.SeedWork;

namespace RickAndMortyAPIApp.Infrastructure.Common;

public abstract class BaseConfig<TDomain> : IEntityTypeConfiguration<TDomain> where TDomain : Entity
{
    protected abstract void Config(EntityTypeBuilder<TDomain> builder);

    public virtual void Configure(EntityTypeBuilder<TDomain> builder)
    {
        builder.HasKey(x => x.Id);
        Config(builder);
    }
}
