using System.Text.Json.Serialization;

namespace App1.Models;

public sealed class Reactions
{
    [JsonPropertyName("dislikes")]
    public long Dislikes { get; set; }

    [JsonPropertyName("likes")]
    public long Likes { get; set; }
}