using System.Text.Json.Serialization;

namespace EaseeRisk.Model;

public interface ITemplate : IRecord
{
    string Name { get; set; }

    string Category { get; set; }

    string Description { get; set; }
}

public class Template : ITemplate
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("category")]
    public required string Category { get; set; }

    [JsonPropertyName("description")]
    public required string Description { get; set; }
}