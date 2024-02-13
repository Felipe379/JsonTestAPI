using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Linq.Expressions;

namespace JsonTestAPI.Infrastructure.Conversions
{
    internal class JsonPropertyConversionWithEnumAsString<T> : ValueConverter<T, string>
    {
        public JsonPropertyConversionWithEnumAsString(ConverterMappingHints mappingHints = null)
            : base(EncryptExpr, DecryptExpr, mappingHints)
        {

        }

        private static readonly Expression<Func<string, T>> DecryptExpr = x => DeserializeObject(x);
        private static readonly Expression<Func<T, string>> EncryptExpr = x => Serialize(x);

        private static T DeserializeObject(string x)
        {
            if (string.IsNullOrEmpty(x))
            {
                return default(T);
            }

            var serializer = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            serializer.Converters.Add(new StringEnumConverter());

            return JsonConvert.DeserializeObject<T>(x, serializer);
        }

        private static string Serialize(T x)
        {
            var serializer = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            serializer.Converters.Add(new StringEnumConverter());

            return JsonConvert.SerializeObject(x, serializer);
        }
    }
}