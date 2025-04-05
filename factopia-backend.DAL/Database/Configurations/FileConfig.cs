
using System.Diagnostics;
using factopia_backend.Domain.CustomEnums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models = factopia_backend.Domain.Models;


namespace factopia_backend.DAL.Database.Configurations
{
    class FileConfig : IEntityTypeConfiguration<Models.File>
    {

        public void Configure(EntityTypeBuilder<Models.File> builder)
        {
            builder.ToTable("Files");

            #region Properties
            builder.Property(c => c.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

            builder.Property(c => c.IsCorrect)
                .IsRequired();
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);
            builder.Property(c => c.Path)
                .IsRequired()
                .HasMaxLength(512);
            builder.Property(c => c.FileType)
                .IsRequired()
                .HasConversion(
                    ft => ft.ToString(),
                    ft => (FileType)Enum.Parse(typeof(FileType), ft)
                );

            #endregion

            #region Keys
            builder.HasKey(c => c.Id);
            #endregion

            #region Relations

            builder.HasOne(c => c.question)
                .WithMany(q => q.Files)
                .HasForeignKey(c => c.QuestionId);

            #endregion
        }
    }
}
