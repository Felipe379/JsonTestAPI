using JsonTestAPI.Core.Entities;
using JsonTestAPI.Core.Enum;
using JsonTestAPI.Infrastructure.Conversions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Collections.Immutable;

namespace JsonTestAPI.Infrastructure.Configuration
{
    public class JsonDataTest2QueryConfiguration : IEntityTypeConfiguration<JsonDataTest2Query>
    {
        public void Configure(EntityTypeBuilder<JsonDataTest2Query> builder)
        {
            builder.ToView("vWJsonDataTest2").HasNoKey();

            builder.Property(c => c.ComplexSerializedData1)
                .HasConversion(new JsonPropertyConversion<ComplexSerializedData1>());

            builder.Property(c => c.MultipleComplexSerializedData1)
                .HasConversion(new JsonPropertyConversion<List<ComplexSerializedData1>>());


            //builder.OwnsOne(c => c.ComplexSerializedData1, ownedType =>
            //{
            //    ownedType.Property(d => d.DateTimeOffsetFillerProperty1)
            //    .HasColumnType("datetimeoffset");

            //    ownedType.Property(d => d.FillerEnumString1)
            //        .HasConversion(new EnumToStringConverter<FillerEnum>());

            //    ownedType.ToJson();
            //});

            //builder.OwnsMany(c => c.MultipleComplexSerializedData1, ownedType =>
            //{
            //    ownedType.Property(d => d.DateTimeOffsetFillerProperty1)
            //    .HasColumnType("datetimeoffset");

            //    ownedType.Property(d => d.FillerEnumString1)
            //        .HasConversion(new EnumToStringConverter<FillerEnum>());

            //    ownedType.ToJson();
            //});
        }
    }
}
