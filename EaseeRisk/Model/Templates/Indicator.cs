using System.Text.Json.Serialization;
using SurrealDb.Net.Models;

namespace EaseeRisk.Model.Templates;

public class Indicator : Record
{
    [JsonPropertyName("text")]
    public required string Text { get; set; }

    [JsonPropertyName("guidance")]
    public required string Guidance { get; set; }
}