using factopia_backend.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace factopia_backend.DAL.Database.Configurations;

public class QuestionConfig : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.ToTable("Questions");

        builder.HasKey(q => q.Id);
        builder.Property(q => q.Content).IsRequired();

        builder
        .HasOne(q => q.GameType)
        .WithMany(gt => gt.Questions)
        .HasForeignKey(q => q.GameTypeId)
        .OnDelete(DeleteBehavior.Cascade);
    }
}
