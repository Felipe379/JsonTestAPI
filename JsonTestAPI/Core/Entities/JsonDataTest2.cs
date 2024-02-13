namespace JsonTestAPI.Core.Entities
{
    public class JsonDataTest2
    {
        public int Id { get; set; }
        public ComplexSerializedData1 ComplexSerializedData1 { get; set; } = new();
        public List<ComplexSerializedData1> MultipleComplexSerializedData1 { get; set; } = new();

        public ComplexSerializedData2 ComplexSerializedData2 { get; set; } = new();
        public List<ComplexSerializedData2> MultipleComplexSerializedData2 { get; set; } = new();
    }
}
