using JsonTestAPI.Core.Entities;
using JsonTestAPI.Core.Enum;
using JsonTestAPI.Infrastructure.Conversions;
using JsonTestAPI.Infrastructure.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JsonTestAPI.Infrastructure.Configuration
{
    public class JsonDataTest1Configuration : IEntityTypeConfiguration<JsonDataTest1>
    {
        public void Configure(EntityTypeBuilder<JsonDataTest1> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.FillerEnum1)
                .HasConversion(new EnumToStringConverter<FillerEnum>())
                .IsRequired();

            builder.Property(c => c.DateTimeOffsetFillerProperty1)
                .HasColumnType("datetimeoffset")
                .IsRequired();

            builder.Property(c => c.DateTimeFillerProperty1)
                .IsRequired();

            builder.Property(c => c.IntFillerProperty)
                .IsRequired();

            builder.Property(c => c.IntFillerProperty)
                .IsRequired();

            builder.Property(c => c.DataEnumProperty)
                .HasConversion(new JsonPropertyConversionWithEnumAsString<List<FillerEnum>>());

            builder
                .HasData(Seed.JsonDataTest1.ToArray());
        }
    }
}
