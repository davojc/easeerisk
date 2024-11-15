using System.Text.Json.Serialization;

namespace EaseeRisk.Store;

public class RiskAssessmentTemplate
{
    public string Name { get; set; }

    public required string Category { get; set; }

    public required string Description { get; set; }
}