using System.Text.Json.Serialization;

namespace App1.Models;

public partial class Address
{
    [JsonPropertyName("address")]
    public string AddressAddress { get; set; } = default!;

    [JsonPropertyName("city")]
    public string City { get; set; } = default!;

    [JsonPropertyName("coordinates")]
    public Coordinates Coordinates { get; set; } = default!;

    [JsonPropertyName("country")]
    public string Country { get; set; } = default!;

    //[JsonPropertyName("postalCode")]
    //[JsonConverter(typeof(ParseStringConverter))]
    //public long PostalCode { get; set; }

    [JsonPropertyName("state")]
    public string State { get; set; } = default!;

    [JsonPropertyName("stateCode")]
    public string StateCode { get; set; } = default!;
}
