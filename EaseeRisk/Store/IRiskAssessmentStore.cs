using EaseeRisk.Model;

namespace EaseeRisk.Store;

public interface IRiskAssessmentStore
{
    Task<RiskAssessmentTemplate> AddRiskAssessmentTemplate(CreateRiskAssessmentTemplate createRiskAssessmentTemplate, CancellationToken cancellationToken);

    Task<IEnumerable<RiskAssessmentTemplate>> GetAssessmentTemplates(CancellationToken cancellationToken);

    //RiskAssessmentTemplateDto GetAssessmentTemplateById(string id);

    /*
    IEnumerable<RiskIndicatorGroup> GetIndicatorGroups(string templateId);

    RiskIndicatorGroup GetIndicatorGroupById(string templateId, string id);

    IEnumerable<RiskIndicator> GetIndicators(string templateId, string indicatorGroupId);

    RiskIndicator GetIndicatorById(string templateId, string indicatorGroupId, string id);

    IEnumerable<RiskLevelSet> GetRiskLevelSets();

    RiskLevelSet GetRiskLevelSetById(string id);
    */
}