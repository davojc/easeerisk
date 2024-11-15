using EaseeRisk.Model;
using SurrealDb.Net;

namespace EaseeRisk.Store;

public class SurrealDbStore(ISurrealDbClient client) : IRiskAssessmentStore
{
    private const string Table_RiskAssessmentTemplates = "RiskAssessmentTemplate";

    public Task<RiskAssessmentTemplate> AddRiskAssessmentTemplate(CreateRiskAssessmentTemplate createRiskAssessmentTemplate, CancellationToken cancellationToken)
    {
        var riskAssTemp = new RiskAssessmentTemplate
        {
            Description = createRiskAssessmentTemplate.Description,
            Category = createRiskAssessmentTemplate.Category,
            Name = createRiskAssessmentTemplate.Name
        };

        return client.Create(Table_RiskAssessmentTemplates, riskAssTemp, cancellationToken);
    }

    public Task<IEnumerable<RiskAssessmentTemplate>> GetAssessmentTemplates(CancellationToken cancellationToken)
    {
        return client.Select<RiskAssessmentTemplate>(Table_RiskAssessmentTemplates, cancellationToken);
    }
}