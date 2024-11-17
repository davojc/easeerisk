using System.Text.Json.Serialization;

namespace EaseeRisk.Requests;

public class CreateRiskIndicatorGroup
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}