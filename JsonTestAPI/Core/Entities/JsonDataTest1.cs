using JsonTestAPI.Core.Enum;

namespace JsonTestAPI.Core.Entities
{
    public class JsonDataTest1
    {
        public int Id { get; set; }
        public string StringFillerProperty1 { get; set; }
        public int IntFillerProperty { get; set; }
        public DateTimeOffset DateTimeOffsetFillerProperty1 { get; set; }
        public DateTime DateTimeFillerProperty1 { get; set; }
        public FillerEnum FillerEnum1 { get; set; }

        public List<string> DataProperty { get; set; } = new();
        public List<string> FillerDataProperty { get; set; } = new();

        public List<FillerEnum> DataEnumProperty { get; set; } = new();
    }
}
