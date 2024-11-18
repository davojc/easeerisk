using System.Text.Json.Serialization;

namespace EaseeRisk.Model;

public class RiskAssessmentIndicatorGroup
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("indicators")]
    public required IList<RiskAssessmentRiskIndicator> Indicators { get; set; } =
        new List<RiskAssessmentRiskIndicator>();
}