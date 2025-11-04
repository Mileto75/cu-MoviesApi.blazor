using System.Text.Json.Serialization;

namespace MyFirstBlazor.Services.Models
{
    public class ResultModel<T> : BaseResultModel
    {
        [JsonPropertyName("description")]
        public T Data  { get; set; }
    }
}
