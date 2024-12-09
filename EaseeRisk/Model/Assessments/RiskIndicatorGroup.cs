using System.Text.Json.Serialization;

namespace EaseeRisk.Model.Assessments;

public class RiskIndicatorGroup
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("indicators")]
    public required IList<RiskIndicator> Indicators { get; set; } =
        new List<RiskIndicator>();
}