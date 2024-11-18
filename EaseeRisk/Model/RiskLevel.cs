using System.Text.Json.Serialization;
namespace EaseeRisk.Model;

public class RiskLevel
{
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    [JsonPropertyName("color")]
    public required string Color { get; set; }

    [JsonPropertyName("boundary")]
    public required RiskLevelBoundary Boundary { get; set; }
}