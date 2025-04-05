using factopia_backend.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace factopia_backend.DAL.Database.Configurations;

public class GameTypeConfig : IEntityTypeConfiguration<GameType>
{
    public void Configure(EntityTypeBuilder<GameType> builder)
    {
        builder.HasKey(gt => gt.Id);

        builder.Property(gt => gt.Title).IsRequired();
        builder.Property(gt => gt.Description).IsRequired();
    }
}
