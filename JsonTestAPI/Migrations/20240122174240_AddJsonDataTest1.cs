using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JsonTestAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddJsonDataTest1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JsonDataTest1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StringFillerProperty1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntFillerProperty = table.Column<int>(type: "int", nullable: false),
                    DateTimeOffsetFillerProperty1 = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateTimeFillerProperty1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FillerEnum1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataProperty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FillerDataProperty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataEnumProperty = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsonDataTest1", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "JsonDataTest1",
                columns: new[] { "Id", "DataEnumProperty", "DataProperty", "DateTimeFillerProperty1", "DateTimeOffsetFillerProperty1", "FillerDataProperty", "FillerEnum1", "IntFillerProperty", "StringFillerProperty1" },
                values: new object[,]
                {
                    { 1, "[\"FillerEnum1\",\"FillerEnum2\",\"FillerEnum3\"]", "[\"Data1_1\",\"Data2_1\",\"Data3_1\",\"Data4_1\",\"Data5_1\",\"Data6_1\",\"Data7_1\",\"Data8_1\",\"Data9_1\",\"Data10_1\"]", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -3, 0, 0, 0)), "[\"FillerData1_1\",\"FillerData2_1\",\"FillerData3_1\",\"FillerData4_1\",\"FillerData5_1\",\"FillerData6_1\",\"FillerData7_1\",\"FillerData8_1\",\"FillerData9_1\",\"FillerData10_1\"]", "FillerEnum1", 10, "Filler1" },
                    { 2, "[\"FillerEnum1\",\"FillerEnum2\",\"FillerEnum3\"]", "[\"Data1_2\",\"Data2_2\",\"Data3_2\",\"Data4_2\",\"Data5_2\",\"Data6_2\",\"Data7_2\",\"Data8_2\",\"Data9_2\",\"Data10_2\"]", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -3, 0, 0, 0)), "[\"FillerData1_2\",\"FillerData2_2\",\"FillerData3_2\",\"FillerData4_2\",\"FillerData5_2\",\"FillerData6_2\",\"FillerData7_2\",\"FillerData8_2\",\"FillerData9_2\",\"FillerData10_2\"]", "FillerEnum2", 20, "Filler2" },
                    { 3, "[\"FillerEnum1\",\"FillerEnum2\",\"FillerEnum3\"]", "[\"Data1_3\",\"Data2_3\",\"Data3_3\",\"Data4_3\",\"Data5_3\",\"Data6_3\",\"Data7_3\",\"Data8_3\",\"Data9_3\",\"Data10_3\"]", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -3, 0, 0, 0)), "[\"FillerData1_3\",\"FillerData2_3\",\"FillerData3_3\",\"FillerData4_3\",\"FillerData5_3\",\"FillerData6_3\",\"FillerData7_3\",\"FillerData8_3\",\"FillerData9_3\",\"FillerData10_3\"]", "FillerEnum3", 30, "Filler3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JsonDataTest1");
        }
    }
}
