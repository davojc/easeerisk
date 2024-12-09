using System.Text.Json.Serialization;
using SurrealDb.Net.Models;

namespace EaseeRisk.Model.Templates;

public class RiskLevelSet : Record
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("levels")]
    public required IList<RiskLevel> Levels { get; set; } = new List<RiskLevel>();
}