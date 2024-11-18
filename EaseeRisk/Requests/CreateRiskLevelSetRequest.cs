using System.Text.Json.Serialization;
using EaseeRisk.Model;

namespace EaseeRisk.Requests;

public class CreateRiskLevelSetRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("levels")]
    public required IList<RiskLevel> Levels { get; set; } = new List<RiskLevel>();
}