using System.Text.Json.Serialization;

namespace App1.Models;

public partial class Crypto
{
    [JsonPropertyName("coin")]
    public string Coin { get; set; } = default!;

    [JsonPropertyName("network")]
    public string Network { get; set; } = default!;

    [JsonPropertyName("wallet")]
    public string Wallet { get; set; } = default!;
}
