using System.Text.Json.Serialization;

namespace PaymentSimulator.Models;

public class AuthorizationRequest
{
    [JsonPropertyName("card_id")]
    public string CardId { get; set; } = string.Empty;

    [JsonPropertyName("amount")]
    public decimal Amount { get; set; }
}