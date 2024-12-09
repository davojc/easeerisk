using System.Text.Json.Serialization;

namespace EaseeRisk.Model.Assessments;

public class RiskIndicator
{
    [JsonPropertyName("text")]
    public required string Text { get; set; }

    [JsonPropertyName("guidance")]
    public required string Guidance { get; set; }

    [JsonPropertyName("risk")]
    public RiskScore? Risk { get; set; }

    [JsonPropertyName("residual")]
    public RiskScore? Residual { get; set; }

    [JsonPropertyName("mitigations")]
    public required IList<RiskMitigation> Mitigations { get; set; } =
        new List<RiskMitigation>();
}