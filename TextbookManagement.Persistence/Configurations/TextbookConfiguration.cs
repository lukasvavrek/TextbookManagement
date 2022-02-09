using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TextbookManagement.Domain;

namespace TextbookManagement.Persistence.Configurations
{
    public class TextbookConfiguration : IEntityTypeConfiguration<Textbook>
    {
        public void Configure(EntityTypeBuilder<Textbook> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}