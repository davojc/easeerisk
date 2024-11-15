using System.Text.Json.Serialization;

namespace EaseeRisk.Model;

[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
public class DefinitionAttribute(string definition) : Attribute
{
    public string Definition { get; } = definition;
}

public enum Likelihood : byte
{
    [Definition("Very unlikely to happen (e.g. less than once every 10 years).")]
    Rare = 1,
    [Definition("Could happen, but not expected (e.g. once in 5-10 years).")]
    Unlikely = 2,
    [Definition("Might happen occasionally (e.g. once in 1-5 years).")]
    Possible = 3,
    [Definition("Expected to happen in most circumstances (e.g. once a year or more).")]
    Likely = 4,
    [Definition("Will occur frequently (e.g. multiple times a year).")]
    AlmostCertain = 5
}

public enum Consequences : byte
{
    [Definition("No injury or minor first aid needed; no disruption to operations.")]
    Insignificant = 1,
    [Definition("Minor injury requiring first aid; minimal impact on operations.")]
    Minor = 2,
    [Definition("Significant injury requiring medical treatment; moderate operational impact.")]
    Moderate = 3,
    [Definition("Severe injury or illness; significant operational disruption or regulatory action.")]
    Major = 4,
    [Definition("Death or multiple severe injuries; major operational shutdown, legal repercussions.")]
    Catastrophic = 5
}

public class RiskScore(Likelihood likelihood, Consequences consequences, RiskLevelSet riskLevelSet)
{
    public Likelihood Likelihood { get; set; } = likelihood;
    public Consequences Consequences { get; set;  } = consequences;

    public RiskLevel GetRiskLevel()
    {
        var score = (byte)Likelihood * (byte)Consequences;

        var riskLevels = riskLevelSet.Levels.OrderBy(rl => rl.Boundary).ToArray();

        foreach (var riskLevel in riskLevels.Take(riskLevels.Length - 1))
        {
            if (score <= (byte)riskLevel.Boundary)
                return riskLevel;
        }

        return riskLevels[^1];
    }
}

public class RiskLevelSet
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("levels")] 
    public required IList<RiskLevel> Levels { get; set; } = new List<RiskLevel>();
}

public enum RiskLevelBoundary : byte
{
    One = 1, 
    Two = 2, 
    Three = 3,
    Fourth = 4,
    Five = 5,
    Six = 6,
    Eight = 8,
    Nine = 9,
    Ten = 10,
    Twelve = 12,
    Fifteen = 15,
    Sixteen = 16,
    Twenty = 20,
    TwentyFive = 25
}

public class RiskLevel
{
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    [JsonPropertyName("color")]
    public required string Color { get; set; }

    [JsonPropertyName("boundary")]
    public required RiskLevelBoundary Boundary { get; set; }
}

public class RiskIndicatorGroup
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

public class RiskIndicator
{
    [JsonPropertyName("text")]
    public required string Text { get; set; }

    [JsonPropertyName("guidance")]
    public required string Guidance { get; set; }
}



public abstract class Record
{

}


