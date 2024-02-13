namespace JsonTestAPI.Core.Entities
{
    public class JsonDataTest2Query
    {
        public int Id { get; set; }
        public ComplexSerializedData1 ComplexSerializedData1 { get; set; }
        public List<ComplexSerializedData1> MultipleComplexSerializedData1 { get; set; }
    }
}
