using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JsonTestAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddVwJsonDataTest2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE VIEW VwJsonDataTest2 AS
SELECT Id, ComplexSerializedData1, MultipleComplexSerializedData1 FROM JsonDataTest2;");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW VwJsonDataTest2;");
        }
    }
}
