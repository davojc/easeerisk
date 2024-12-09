using System.Text.Json.Serialization;

namespace EaseeRisk.Model.Assessments;

public class RiskMitigation
{
    [JsonPropertyName("description")]
    public required string Text { get; set; }

    [JsonPropertyName("state")]
    public required MitigationState State { get; set; }
}