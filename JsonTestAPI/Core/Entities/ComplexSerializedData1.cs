using JsonTestAPI.Core.Enum;

namespace JsonTestAPI.Core.Entities
{
    public class ComplexSerializedData1
    {
        public int IntFillerProperty { get; set; }
        public string StringFillerProperty1 { get; set; }
        public DateTimeOffset? DateTimeOffsetFillerProperty1 { get; set; }
        public DateTime? DateTimeFillerProperty1 { get; set; }
        public FillerEnum? FillerEnumString1 { get; set; }
        public FillerEnum? FillerEnumInt1 { get; set; }
        public List<int> FillerInt { get; set; } = new();
    }
}
