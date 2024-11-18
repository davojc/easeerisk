using System.Text.Json.Serialization;
using SurrealDb.Net.Models;

namespace EaseeRisk.Model;

public class RiskAssesment : Record
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("category")]
    public required string Category { get; set; }

    [JsonPropertyName("description")]
    public required string Description { get; set; }

    [JsonPropertyName("indicatorGroups")]
    public required IList<RiskAssessmentIndicatorGroup> IndicatorGroups { get; set; } =
        new List<RiskAssessmentIndicatorGroup>();
}