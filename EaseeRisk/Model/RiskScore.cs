using System.Text.Json.Serialization;

namespace EaseeRisk.Model;

public class RiskScore
{
    [JsonPropertyName("likelihood")]
    public Likelihood Likelihood { get; set; }

    [JsonPropertyName("consequences")]
    public Consequences Consequences { get; set;  }
}