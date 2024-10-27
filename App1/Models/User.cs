using System.Text.Json.Serialization;

namespace App1.Models;

public partial class User
{
    [JsonPropertyName("address")]
    public Address Address { get; set; } = default!;

    [JsonPropertyName("age")]
    public long Age { get; set; }

    [JsonPropertyName("bank")]
    public Bank Bank { get; set; } = default!;

    [JsonPropertyName("birthDate")]
    public string BirthDate { get; set; } = default!;

    [JsonPropertyName("bloodGroup")]
    public string BloodGroup { get; set; } = default!;

    [JsonPropertyName("company")]
    public Company Company { get; set; } = default!;

    [JsonPropertyName("crypto")]
    public Crypto Crypto { get; set; } = default!;

    [JsonPropertyName("ein")]
    public string Ein { get; set; } = default!;

    [JsonPropertyName("email")]
    public string Email { get; set; } = default!;

    [JsonPropertyName("eyeColor")]
    public string EyeColor { get; set; } = default!;

    [JsonPropertyName("firstName")]
    public string FirstName { get; set; } = default!;

    [JsonPropertyName("gender")]
    public string Gender { get; set; } = default!;

    [JsonPropertyName("hair")]
    public Hair Hair { get; set; } = default!;

    [JsonPropertyName("height")]
    public double Height { get; set; }

    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("image")]
    public string Image { get; set; } = default!;

    [JsonPropertyName("ip")]
    public string Ip { get; set; } = default!;

    [JsonPropertyName("lastName")]
    public string LastName { get; set; } = default!;

    [JsonPropertyName("macAddress")]
    public string MacAddress { get; set; } = default!;

    [JsonPropertyName("maidenName")]
    public string MaidenName { get; set; } = default!;

    [JsonPropertyName("password")]
    public string Password { get; set; } = default!;

    [JsonPropertyName("phone")]
    public string Phone { get; set; } = default!;

    [JsonPropertyName("role")]
    public string Role { get; set; } = default!;

    [JsonPropertyName("ssn")]
    public string Ssn { get; set; } = default!;

    [JsonPropertyName("university")]
    public string University { get; set; } = default!;

    [JsonPropertyName("userAgent")]
    public string UserAgent { get; set; } = default!;

    [JsonPropertyName("username")]
    public string Username { get; set; } = default!;

    [JsonPropertyName("weight")]
    public double Weight { get; set; }
}
