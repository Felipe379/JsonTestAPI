using JsonTestAPI.Core.Entities;
using JsonTestAPI.Core.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JsonTestAPI.Infrastructure.Configuration
{
    public class JsonDataTest2Configuration : IEntityTypeConfiguration<JsonDataTest2>
    {
        public void Configure(EntityTypeBuilder<JsonDataTest2> builder)
        {
            builder.HasKey(c => c.Id);

            builder.OwnsOne(c => c.ComplexSerializedData1, ownedType =>
            {
                ownedType.Property(d => d.DateTimeOffsetFillerProperty1)
                .HasColumnType("datetimeoffset");

                ownedType.Property(d => d.FillerEnumString1)
                    .HasConversion(new EnumToStringConverter<FillerEnum>());

                ownedType.ToJson();
            });

            builder.OwnsMany(c => c.MultipleComplexSerializedData1, ownedType =>
            {
                ownedType.Property(d => d.DateTimeOffsetFillerProperty1)
                .HasColumnType("datetimeoffset");

                ownedType.Property(d => d.FillerEnumString1)
                    .HasConversion(new EnumToStringConverter<FillerEnum>());

                ownedType.ToJson();
            });


            builder.OwnsOne(c => c.ComplexSerializedData2, ownedType =>
            {
                ownedType.OwnsOne(d => d.ComplexSerializedData, ownedType2 =>
                {
                    ownedType2.ToJson();
                });

                ownedType.OwnsMany(d => d.MultipleComplexSerializedData, ownedType2 =>
                {
                    ownedType2.ToJson();
                });

                ownedType.ToJson();
            });

            builder.OwnsMany(c => c.MultipleComplexSerializedData2, ownedType =>
            {
                ownedType.OwnsOne(d => d.ComplexSerializedData, ownedType2 =>
                {
                    ownedType2.ToJson();
                });

                ownedType.OwnsMany(d => d.MultipleComplexSerializedData, ownedType2 =>
                {
                    ownedType2.ToJson();
                });

                ownedType.ToJson();
            });
        }
    }
}
