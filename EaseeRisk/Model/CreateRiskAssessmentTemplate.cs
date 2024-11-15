using System.Text.Json.Serialization;

namespace EaseeRisk.Model;

public class CreateRiskAssessmentTemplate
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("category")]
    public required string Category { get; set; }

    [JsonPropertyName("description")]
    public required string Description { get; set; }
}