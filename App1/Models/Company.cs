using System.Text.Json.Serialization;

namespace App1.Models;

public partial class Company
{
    [JsonPropertyName("address")]
    public Address Address { get; set; } = default!;

    [JsonPropertyName("department")]
    public string Department { get; set; } = default!;

    [JsonPropertyName("name")]
    public string Name { get; set; } = default!;

    [JsonPropertyName("title")]
    public string Title { get; set; } = default!;
}
