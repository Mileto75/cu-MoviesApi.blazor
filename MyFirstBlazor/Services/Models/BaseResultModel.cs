using System.Text.Json.Serialization;

namespace MyFirstBlazor.Services.Models
{
    public class BaseResultModel
    {
        [JsonPropertyName("ok")]
        public bool Ok { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
