using System.Text.Json.Serialization;

namespace App1.Models;

public partial class Hair
{
    [JsonPropertyName("color")]
    public string Color { get; set; } = default!;

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;
}