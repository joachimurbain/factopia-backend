using factopia_backend.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace factopia_backend.DAL.Database.Configurations;

public class UserQuestionConfig : IEntityTypeConfiguration<UserQuestion>
{
    public void Configure(EntityTypeBuilder<UserQuestion> builder)
    {
        builder.HasKey(uq => new { uq.UserId, uq.QuestionId });

        builder
        .HasOne(uq => uq.User)
        .WithMany(u => u.UserQuestion)
        .HasForeignKey(uq => uq.UserId);

        builder
         .HasOne(uq => uq.Question)
         .WithMany(q => q.UserQuestion)
         .HasForeignKey(uq => uq.QuestionId);
    }
}
