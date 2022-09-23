using System.Text.Json;
using System.Text.Json.Serialization;

namespace Curtains.Infrastructure.Shared.Converters
{
    public class SerializerOptions
    {
        public static JsonSerializerOptions Default
        {
            get
            {
                JsonSerializerOptions serializerOptions = new JsonSerializerOptions();
                serializerOptions.PropertyNameCaseInsensitive = true;
                serializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                serializerOptions.ReadCommentHandling = JsonCommentHandling.Skip;
                serializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
                serializerOptions.WriteIndented = true;
                serializerOptions.Converters.Add((JsonConverter) new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
                return serializerOptions;
            }
        }
    }    
}
