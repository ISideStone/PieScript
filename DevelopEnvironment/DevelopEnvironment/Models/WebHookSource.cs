using System.Text.Json.Serialization;

namespace DevelopEnvironment;

public record class WebHookSource
{
    public record class Http
    {
        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        [JsonPropertyName("body")]
        public string Body { get; set; }

        public Http(string uri, string body)
        {
            Uri = uri;
            Body = body;
        }
    }

    public record class TelegramBot
    {
        public long UserId { get; set; }
        public string Text { get; set; }

        public TelegramBot(long userId, string text)
        {
            UserId = userId;
            Text = text;
        }
    }
}