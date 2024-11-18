using SurrealDb.Net.Models;
using System.Text.Json.Serialization;

namespace EaseeRisk.Requests;

public class CreateRiskIndicatorRequest
{
    [JsonPropertyName("text")]
    public required string Text { get; set; }

    [JsonPropertyName("guidance")]
    public required string Guidance { get; set; }
}