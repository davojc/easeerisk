using EaseeRisk.Model.Assessments;
using EaseeRisk.Model.Templates;

namespace EaseeRisk.Model;

public class RiskCalculator
{
    public RiskLevel GetRiskLevel(RiskScore riskScore, RiskLevelSet riskLevelSet)
    {
        var score = (byte)riskScore.Likelihood * (byte)riskScore.Consequences;

        var riskLevels = riskLevelSet.Levels.OrderBy(rl => rl.Boundary).ToArray();

        foreach (var riskLevel in riskLevels.Take(riskLevels.Length - 1))
        {
            if (score <= (byte)riskLevel.Boundary)
                return riskLevel;
        }

        return riskLevels[^1];
    }
}