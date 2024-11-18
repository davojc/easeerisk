using System.Text.Json.Serialization;

namespace EaseeRisk.Model;

public class RiskAssessmentMitigation
{
    [JsonPropertyName("description")]
    public required string Text { get; set; }

    [JsonPropertyName("state")]
    public required MitigationState State { get; set; }
}