using factopia_backend.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace factopia_backend.DAL.Database.Configurations;

public class AnswerConfig : IEntityTypeConfiguration<Answer>
{
    public void Configure(EntityTypeBuilder<Answer> builder)
    {
        builder.ToTable("Answers");

        builder.HasKey(a => a.Id);

        builder.HasOne(c => c.Question)
            .WithMany(q => q.Answers)
            .HasForeignKey(c => c.QuestionId);
    }
}
