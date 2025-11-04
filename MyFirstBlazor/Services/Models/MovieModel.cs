using System.Text.Json.Serialization;

namespace MyFirstBlazor.Services.Models
{
    public class MovieModel
    {

        [JsonPropertyName("#TITLE")]
        public string Title { get; set; }

        [JsonPropertyName("#YEAR")]
        public int Year { get; set; }

        [JsonPropertyName("#IMDB_ID")]
        public string ImdbId { get; set; }

        [JsonPropertyName("#RANK")]
        public int Rank { get; set; }

        [JsonPropertyName("#ACTORS")]
        public string Actors { get; set; }

        [JsonPropertyName("#AKA")]
        public string Aka { get; set; }

        [JsonPropertyName("#IMDB_URL")]
        public string ImdbUrl { get; set; }

        [JsonPropertyName("#IMDB_IV")]
        public string ImdbIv { get; set; }

        [JsonPropertyName("#IMG_POSTER")]
        public string ImgPoster { get; set; }
        [JsonPropertyName("photo_width")]
        public int PhotoWidth { get; set; }
        [JsonPropertyName("photo_height")]
        public int PhotoHeight { get; set; }
    }
}
