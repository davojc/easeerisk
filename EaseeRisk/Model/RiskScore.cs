namespace EaseeRisk.Model;

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