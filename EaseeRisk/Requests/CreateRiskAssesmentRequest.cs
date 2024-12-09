using System.Text.Json.Serialization;
using EaseeRisk.Model.Assessments;

namespace EaseeRisk.Requests;

public class CreateRiskAssesmentRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("category")]
    public required string Category { get; set; }

    [JsonPropertyName("description")]
    public required string Description { get; set; }

    [JsonPropertyName("indicatorGroups")]
    public required IList<RiskIndicatorGroup> IndicatorGroups { get; set; } =
        new List<RiskIndicatorGroup>();
}