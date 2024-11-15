using EaseeRisk.Model;
using EaseeRisk.Store;
using Microsoft.AspNetCore.Mvc;

namespace EaseeRisk.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class RiskController(IRiskAssessmentStore riskAssessmentStore, ILogger<RiskController> logger) : ControllerBase
{
    [HttpGet("templates")]
    public Task<IEnumerable<RiskAssessmentTemplate>> GetTemplates(CancellationToken cancellationToken)
    {
        return riskAssessmentStore.GetAssessmentTemplates(cancellationToken);
    }

    [HttpPost("templates")]
    public Task<RiskAssessmentTemplate> Post([FromBody] CreateRiskAssessmentTemplate riskAssessmentTemplate, CancellationToken cancellationToken)
    {
        return riskAssessmentStore.AddRiskAssessmentTemplate(riskAssessmentTemplate, cancellationToken);
    }

    /*
    [HttpGet("templates/{templateId}")]
    public RiskAssessmentTemplateDto GetTemplate(string templateId)
    {
        return riskAssessmentStore.GetAssessmentTemplateById(templateId);
    }

    [HttpGet("templates/{templateId}/indicator-group")]
    public IEnumerable<RiskIndicatorGroup> GetIndicatorGroups(string templateId)
    {
        return riskAssessmentStore.GetIndicatorGroups(templateId);
    }

    [HttpGet("templates/{templateId}/indicator-group/{indicatorGroupId}")]
    public RiskIndicatorGroup GetIndicatorGroup(string templateId, string indicatorGroupId)
    {
        return riskAssessmentStore.GetIndicatorGroupById(templateId, indicatorGroupId);
    }

    [HttpGet("templates/{templateId}/indicator-group/{indicatorGroupId}/indicators")]
    public IEnumerable<RiskIndicator> GetIndicators(string templateId, string indicatorGroupId)
    {
        return riskAssessmentStore.GetIndicators(templateId, indicatorGroupId);
    }

    [HttpGet("templates/{templateId}/indicator-group/{indicatorGroupId}/indicators/{indicatorId}")]
    public RiskIndicator GetIndicator(string templateId, string indicatorGroupId, string indicatorId)
    {
        return riskAssessmentStore.GetIndicatorById(templateId, indicatorGroupId, indicatorId);
    }

    [HttpGet("risklevelsets")]
    public IEnumerable<RiskLevelSet> GetRiskLevelSets()
    {
        return riskAssessmentStore.GetRiskLevelSets();
    }

    [HttpGet("risklevelsets/{riskLevelSetId}")]
    public RiskLevelSet GetRiskLevelSet(string riskLevelSetId)
    {
        return riskAssessmentStore.GetRiskLevelSetById(riskLevelSetId);
    }*/

}