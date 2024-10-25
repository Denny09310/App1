using System.Text.Json.Serialization;

namespace App1.Models;

public sealed class Post
{
    [JsonPropertyName("body")]
    public string Body { get; set; } = default!;

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("reactions")]
    public Reactions Reactions { get; set; } = new();

    [JsonPropertyName("tags")]
    public string[] Tags { get; set; } = [];

    [JsonPropertyName("title")]
    public string Title { get; set; } = default!;

    [JsonPropertyName("userId")]
    public int UserId { get; set; }

    [JsonPropertyName("views")]
    public long Views { get; set; }
}
