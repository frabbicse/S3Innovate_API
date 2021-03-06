using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using S3Inovate.Core.Models;

namespace S3Inovate.Core.Configurations
{
    public class DataFieldConfiguration : IEntityTypeConfiguration<DataField>
    {
        public void Configure(EntityTypeBuilder<DataField> builder)
        {
            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("VARCHAR(50)");

            builder.HasAlternateKey(x => x.Name);
        }
    }
}
