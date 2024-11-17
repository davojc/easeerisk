using System.Text.Json.Serialization;

namespace EaseeRisk.Model;

public class CreateRiskIndicatorGroup
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}