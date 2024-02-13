using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;
using System.Linq.Expressions;

namespace JsonTestAPI.Infrastructure.Conversions
{
    internal class JsonPropertyConversion<T> : ValueConverter<T, string>
    {
        public JsonPropertyConversion(ConverterMappingHints mappingHints = null)
            : base(EncryptExpr, DecryptExpr, mappingHints)
        { }

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

            return JsonConvert.DeserializeObject<T>(x, serializer);
        }

        private static string Serialize(T x)
        {
            return JsonConvert.SerializeObject(x, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
        }
    }
}