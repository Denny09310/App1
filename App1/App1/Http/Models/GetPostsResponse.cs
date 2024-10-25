using App1.Models;
using System.Text.Json.Serialization;

namespace App1.Http.Models;

internal sealed class GetPostsResponse
{
    [JsonPropertyName("limit")]
    public long Limit { get; set; }

    [JsonPropertyName("posts")]
    public ICollection<Post> Posts { get; set; } = [];

    [JsonPropertyName("skip")]
    public long Skip { get; set; }

    [JsonPropertyName("total")]
    public long Total { get; set; }
}
