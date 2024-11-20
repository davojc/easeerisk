using System.Text.Json.Serialization;

namespace EaseeRisk.Requests;

public class CreateRiskIndicatorGroupRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}