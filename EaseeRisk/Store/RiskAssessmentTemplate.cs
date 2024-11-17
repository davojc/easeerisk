using System.Text.Json.Serialization;
using SurrealDb.Net.Models;

namespace EaseeRisk.Store;

[Table("riskassessmenttemplate")]
public class RiskAssessmentTemplate : Record
{
    public required string Name { get; set; }

    public required string Category { get; set; }

    public required string Description { get; set; }
}