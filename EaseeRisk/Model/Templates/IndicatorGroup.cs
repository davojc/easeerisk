using SurrealDb.Net.Models;
using System.Text.Json.Serialization;

namespace EaseeRisk.Model.Templates;

public class IndicatorGroup : Record
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}