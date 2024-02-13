using JsonTestAPI.Core.Enum;

namespace JsonTestAPI.Core.Entities
{
    public class ComplexSerializedData2
    {
        public string StringFillerProperty1 { get; set; }
        public int IntFillerProperty { get; set; }
        public ComplexSerializedData1 ComplexSerializedData { get; set; } = new();
        public List<ComplexSerializedData1> MultipleComplexSerializedData { get; set; } = new();
    }
}
