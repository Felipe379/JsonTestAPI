using JsonTestAPI.Core.Entities;
using JsonTestAPI.Core.Enum;

namespace JsonTestAPI.Infrastructure.SeedData
{
    public static partial class Seed
    {
        public static List<JsonDataTest1> JsonDataTest1 { get; } = new List<JsonDataTest1>
        {
            new JsonDataTest1
            {
                Id = 1,
                StringFillerProperty1 = "Filler1",
                IntFillerProperty = 1 * 10,
                DateTimeFillerProperty1 = new DateTime(2024,01,01),
                DateTimeOffsetFillerProperty1 = new DateTimeOffset(2024,01,22, 0, 0, 0, TimeSpan.FromHours(-3)),
                FillerEnum1 = FillerEnum.FillerEnum1,
                DataProperty = new List<string> { "Data1_1", "Data2_1", "Data3_1", "Data4_1", "Data5_1", "Data6_1", "Data7_1", "Data8_1", "Data9_1", "Data10_1", },
                FillerDataProperty = new List<string> { "FillerData1_1", "FillerData2_1", "FillerData3_1", "FillerData4_1", "FillerData5_1", "FillerData6_1", "FillerData7_1", "FillerData8_1", "FillerData9_1", "FillerData10_1", },
                DataEnumProperty = new List<FillerEnum> { FillerEnum.FillerEnum1, FillerEnum.FillerEnum2, FillerEnum.FillerEnum3, },
            },
            new JsonDataTest1
            {
                Id = 2,
                StringFillerProperty1 = "Filler2",
                IntFillerProperty = 1 * 20,
                DateTimeFillerProperty1 = new DateTime(2024,01,02),
                DateTimeOffsetFillerProperty1 = new DateTimeOffset(2024,01,02, 0, 0, 0, TimeSpan.FromHours(-3)),
                FillerEnum1 = FillerEnum.FillerEnum2,
                DataProperty = new List<string> { "Data1_2", "Data2_2", "Data3_2", "Data4_2", "Data5_2", "Data6_2", "Data7_2", "Data8_2", "Data9_2", "Data10_2", },
                FillerDataProperty = new List<string> { "FillerData1_2", "FillerData2_2", "FillerData3_2", "FillerData4_2", "FillerData5_2", "FillerData6_2", "FillerData7_2", "FillerData8_2", "FillerData9_2", "FillerData10_2", },
                DataEnumProperty = new List<FillerEnum> { FillerEnum.FillerEnum1, FillerEnum.FillerEnum2, FillerEnum.FillerEnum3, },
            },
            new JsonDataTest1
            {
                Id = 3,
                StringFillerProperty1 = "Filler3",
                IntFillerProperty = 1 * 30,
                DateTimeFillerProperty1 = new DateTime(2024,01,03),
                DateTimeOffsetFillerProperty1 = new DateTimeOffset(2024,01,03, 0, 0, 0, TimeSpan.FromHours(-3)),
                FillerEnum1 = FillerEnum.FillerEnum3,
                DataProperty = new List<string> { "Data1_3", "Data2_3", "Data3_3", "Data4_3", "Data5_3", "Data6_3", "Data7_3", "Data8_3", "Data9_3", "Data10_3", },
                FillerDataProperty = new List<string> { "FillerData1_3", "FillerData2_3", "FillerData3_3", "FillerData4_3", "FillerData5_3", "FillerData6_3", "FillerData7_3", "FillerData8_3", "FillerData9_3", "FillerData10_3", },
                DataEnumProperty = new List<FillerEnum> { FillerEnum.FillerEnum1, FillerEnum.FillerEnum2, FillerEnum.FillerEnum3, },
            },
        };
    }
}
