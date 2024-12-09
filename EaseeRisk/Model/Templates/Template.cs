using EaseeRisk.Repository;
using SurrealDb.Net.Models;
using System.Text.Json.Serialization;

namespace EaseeRisk.Model.Templates;

public class Template : Record
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("category")]
    public required string Category { get; set; }

    [JsonPropertyName("description")]
    public required string Description { get; set; }
}