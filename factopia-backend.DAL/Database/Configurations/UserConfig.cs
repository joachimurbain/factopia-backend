using factopia_backend.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace factopia_backend.DAL.Database.Configurations;

public class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(u => u.Id);

        builder.Property(u => u.Email).IsRequired();
        builder.Property(u => u.Pseudo).IsRequired();
        builder.Property(u => u.Password).IsRequired();
        builder.Property(u => u.BirthYear).IsRequired();
        builder.Property(u => u.Gender).IsRequired();

        builder.Property(u => u.Role).HasDefaultValueSql("1");
    }
}
