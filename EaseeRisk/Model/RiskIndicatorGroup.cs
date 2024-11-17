using EaseeRisk.Repository;
using SurrealDb.Net.Models;
using System.Text.Json.Serialization;

namespace EaseeRisk.Model;

public class RiskIndicatorGroup : Record
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}