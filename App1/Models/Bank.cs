using System.Text.Json.Serialization;

namespace App1.Models;

public partial class Bank
{
    [JsonPropertyName("cardExpire")]
    public string CardExpire { get; set; } = default!;

    [JsonPropertyName("cardNumber")]
    public string CardNumber { get; set; } = default!;

    [JsonPropertyName("cardType")]
    public string CardType { get; set; } = default!;

    [JsonPropertyName("currency")]
    public string Currency { get; set; } = default!;

    [JsonPropertyName("iban")]
    public string Iban { get; set; } = default!;
}
