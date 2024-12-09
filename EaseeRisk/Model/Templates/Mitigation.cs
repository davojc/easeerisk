using System.Text.Json.Serialization;
using EaseeRisk.Model.Assessments;
using SurrealDb.Net.Models;

namespace EaseeRisk.Model.Templates;

public class Mitigation : Record
{
    [JsonPropertyName("description")]
    public required string Text { get; set; }
}