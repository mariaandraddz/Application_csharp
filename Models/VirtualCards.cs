using System.Text.Json.Serialization;
namespace Application_csharp.Models;

public class VirtualCards
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("cardholder_name")]
    public string CardholderName { get; set; } = string.Empty;

    [JsonPropertyName("balance")]
    public decimal Balance { get; set; }

    [JsonPropertyName("active")]
    public bool Active { get; set; }
}
