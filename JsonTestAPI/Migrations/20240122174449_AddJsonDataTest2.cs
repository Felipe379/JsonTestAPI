using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JsonTestAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddJsonDataTest2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JsonDataTest2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComplexSerializedData1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComplexSerializedData2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MultipleComplexSerializedData1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MultipleComplexSerializedData2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsonDataTest2", x => x.Id);
                });

            migrationBuilder.Sql(@"
INSERT INTO JsonDataTest2 (ComplexSerializedData1, MultipleComplexSerializedData1, ComplexSerializedData2, MultipleComplexSerializedData2)
VALUES (
'{
	""IntFillerProperty"": 42,
	""StringFillerProperty1"": ""Hello"",
	""DateTimeOffsetFillerProperty1"": ""2024-01-22T12:34:56.7890123+00:00"",
	""DateTimeFillerProperty1"": ""2024-01-22T12:34:56.7890123"",
	""FillerEnumString1"": ""FillerEnum1"",
	""FillerEnumInt1"": 1,
	""FillerInt"": [
		1,
		2,
		3
	]
}',
'[
	{
		""IntFillerProperty"": 1,
		""StringFillerProperty1"": ""First"",
		""DateTimeOffsetFillerProperty1"": ""2024-01-22T12:34:56.7890123+00:00"",
		""DateTimeFillerProperty1"": ""2024-01-22T12:34:56.7890123"",
		""FillerEnumString1"": ""FillerEnum1"",
		""FillerEnumInt1"": 1,
		""FillerInt"": [
			1,
			2,
			3
		]
	},
	{
		""IntFillerProperty"": 2,
		""StringFillerProperty1"": ""Second"",
		""FillerInt"": []
	}
]',
'{
	""StringFillerProperty1"": ""World"",
	""IntFillerProperty"": 99,
	""ComplexSerializedData"": {
		""IntFillerProperty"": 123,
		""StringFillerProperty1"": ""Nested"",
		""FillerInt"": []
	},
	""MultipleComplexSerializedData"": [
		{
			""IntFillerProperty"": 3,
			""StringFillerProperty1"": ""Third""
		},
		{
			""IntFillerProperty"": 4,
			""StringFillerProperty1"": ""Fourth"",
			""DateTimeOffsetFillerProperty1"": ""2024-01-22T12:34:56.7890123+00:00"",
			""DateTimeFillerProperty1"": ""2024-01-22T12:34:56.7890123"",
			""FillerEnumString1"": ""FillerEnum1"",
			""FillerEnumInt1"": 1,
			""FillerInt"": [
				1,
				2,
				3
			]
		}
	]
}',
'[
	{
		""StringFillerProperty1"": ""Nested1"",
		""IntFillerProperty"": 11,
		""ComplexSerializedData"": null,
		""MultipleComplexSerializedData"": []
	},
	{
		""StringFillerProperty1"": ""Nested2"",
		""IntFillerProperty"": 22,
		""ComplexSerializedData"": {
			""StringFillerProperty1"": ""Hello"",
			""DateTimeOffsetFillerProperty1"": ""2024-01-22T12:34:56.7890123+00:00"",
			""DateTimeFillerProperty1"": ""2024-01-22T12:34:56.7890123"",
			""FillerEnumString1"": ""FillerEnum1"",
			""FillerEnumInt1"": 1,
			""FillerInt"": [
				1,
				2,
				3
			]
		},
		""MultipleComplexSerializedData"": [
			{
				""IntFillerProperty"": 3,
				""StringFillerProperty1"": ""Third""
			},
			{
				""IntFillerProperty"": 4,
				""StringFillerProperty1"": ""Fourth"",
				""DateTimeOffsetFillerProperty1"": ""2024-01-22T12:34:56.7890123+00:00"",
				""DateTimeFillerProperty1"": ""2024-01-22T12:34:56.7890123"",
				""FillerEnumString1"": ""FillerEnum1"",
				""FillerEnumInt1"": 1,
				""FillerInt"": [
					1,
					2,
					3
				]
			}
		]
	}
]'
),

('{
	""IntFillerProperty"": 32,
	""StringFillerProperty1"": ""Hello_test"",
	""DateTimeOffsetFillerProperty1"": ""2024-01-22T12:34:56.7890123+00:00"",
	""DateTimeFillerProperty1"": ""2024-01-22T12:34:56.7890123"",
	""FillerEnumString1"": ""FillerEnum2"",
	""FillerEnumInt1"": 2,
	""FillerInt"": [
		1,
		2,
		3
	]
}','[
	{
		""IntFillerProperty"": 10,
		""StringFillerProperty1"": ""First_test"",
		""DateTimeOffsetFillerProperty1"": ""2024-01-22T12:34:56.7890123+00:00"",
		""DateTimeFillerProperty1"": ""2024-01-22T12:34:56.7890123"",
		""FillerEnumString1"": ""FillerEnum2"",
		""FillerEnumInt1"": 2,
		""FillerInt"": [
			1,
			2,
			3
		]
	},
	{
		""IntFillerProperty"": 2,
		""StringFillerProperty1"": ""Second"",
		""FillerInt"": []
	}
]','{
	""StringFillerProperty1"": ""World_test"",
	""IntFillerProperty"": 199,
	""ComplexSerializedData"": {
		""IntFillerProperty"": 1123,
		""StringFillerProperty1"": ""Nested_test"",
		""FillerInt"": []
	},
	""MultipleComplexSerializedData"": [
		{
			""IntFillerProperty"": 13,
			""StringFillerProperty1"": ""Third_test""
		},
		{
			""IntFillerProperty"": 14,
			""StringFillerProperty1"": ""Fourth"",
			""DateTimeOffsetFillerProperty1"": ""2024-01-22T12:34:56.7890123+00:00"",
			""DateTimeFillerProperty1"": ""2024-01-22T12:34:56.7890123"",
			""FillerEnumString1"": ""FillerEnum1"",
			""FillerEnumInt1"": 1,
			""FillerInt"": [
				1,
				2,
				3
			]
		}
	]
}',
'[
	{
		""StringFillerProperty1"": ""Nested1_test"",
		""IntFillerProperty"": 111,
		""ComplexSerializedData"": null,
		""MultipleComplexSerializedData"": []
	},
	{
		""StringFillerProperty1"": ""Nested2_test"",
		""IntFillerProperty"": 122,
		""ComplexSerializedData"": {
			""StringFillerProperty1"": ""Hello_test"",
			""DateTimeOffsetFillerProperty1"": ""2024-01-22T12:34:56.7890123+00:00"",
			""DateTimeFillerProperty1"": ""2024-01-22T12:34:56.7890123"",
			""FillerEnumString1"": ""FillerEnum3"",
			""FillerEnumInt1"": 3,
			""FillerInt"": [
				1,
				2,
				3
			]
		},
		""MultipleComplexSerializedData"": [
			{
				""IntFillerProperty"": 13,
				""StringFillerProperty1"": ""Third""
			},
			{
				""IntFillerProperty"": 14,
				""StringFillerProperty1"": ""Fourth_test"",
				""DateTimeOffsetFillerProperty1"": ""2024-01-22T12:34:56.7890123+00:00"",
				""DateTimeFillerProperty1"": ""2024-01-22T12:34:56.7890123"",
				""FillerEnumString1"": ""FillerEnum1"",
				""FillerEnumInt1"": 1,
				""FillerInt"": [
					1,
					2,
					3
				]
			}
		]
	}
]'),

('{
	""IntFillerProperty"": 32,
	""StringFillerProperty1"": ""Hello_test1"",
	""DateTimeOffsetFillerProperty1"": ""2024-01-22T12:34:56.7890123+00:00"",
	""DateTimeFillerProperty1"": ""2024-01-22T12:34:56.7890123"",
	""FillerEnumString1"": ""FillerEnum2"",
	""FillerEnumInt1"": 2,
	""FillerInt"": [
		1,
		2,
		3
	]
}','[
	{
		""IntFillerProperty"": 10,
		""StringFillerProperty1"": ""First_test1"",
		""DateTimeOffsetFillerProperty1"": ""2024-01-22T12:34:56.7890123+00:00"",
		""DateTimeFillerProperty1"": ""2024-01-22T12:34:56.7890123"",
		""FillerEnumString1"": ""FillerEnum2"",
		""FillerEnumInt1"": 2,
		""FillerInt"": [
			1,
			2,
			3
		]
	},
	{
		""IntFillerProperty"": 2,
		""StringFillerProperty1"": ""Second"",
		""FillerInt"": []
	}
]','{
	""StringFillerProperty1"": ""World_test1"",
	""IntFillerProperty"": 199,
	""ComplexSerializedData"": {
		""IntFillerProperty"": 1123,
		""StringFillerProperty1"": ""Nested_test1"",
		""FillerInt"": []
	},
	""MultipleComplexSerializedData"": [
		{
			""IntFillerProperty"": 13,
			""StringFillerProperty1"": ""Third_test1""
		},
		{
			""IntFillerProperty"": 14,
			""StringFillerProperty1"": ""Fourth"",
			""DateTimeOffsetFillerProperty1"": ""2024-01-22T12:34:56.7890123+00:00"",
			""DateTimeFillerProperty1"": ""2024-01-22T12:34:56.7890123"",
			""FillerEnumString1"": ""FillerEnum1"",
			""FillerEnumInt1"": 1,
			""FillerInt"": [
				1,
				2,
				3
			]
		}
	]
}','[
	{
		""StringFillerProperty1"": ""Nested1_test1"",
		""IntFillerProperty"": 111,
		""ComplexSerializedData"": null,
		""MultipleComplexSerializedData"": []
	},
	{
		""StringFillerProperty1"": ""Nested2_test1"",
		""IntFillerProperty"": 122,
		""ComplexSerializedData"": {
			""StringFillerProperty1"": ""Hello_test1"",
			""DateTimeOffsetFillerProperty1"": ""2024-01-22T12:34:56.7890123+00:00"",
			""DateTimeFillerProperty1"": ""2024-01-22T12:34:56.7890123"",
			""FillerEnumString1"": ""FillerEnum3"",
			""FillerEnumInt1"": 3,
			""FillerInt"": [
				1,
				2,
				3
			]
		},
		""MultipleComplexSerializedData"": [
			{
				""IntFillerProperty"": 13,
				""StringFillerProperty1"": ""Third""
			},
			{
				""IntFillerProperty"": 14,
				""StringFillerProperty1"": ""Fourth_test1"",
				""DateTimeOffsetFillerProperty1"": ""2024-01-22T12:34:56.7890123+00:00"",
				""DateTimeFillerProperty1"": ""2024-01-22T12:34:56.7890123"",
				""FillerEnumString1"": ""FillerEnum1"",
				""FillerEnumInt1"": 1,
				""FillerInt"": [
					1,
					2,
					3
				]
			}
		]
	}
]');
");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JsonDataTest2");
        }
    }
}
