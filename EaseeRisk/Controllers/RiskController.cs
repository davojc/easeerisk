using EaseeRisk.Model;
using EaseeRisk.Model.Relations;
using EaseeRisk.Repository;
using EaseeRisk.Requests;
using Microsoft.AspNetCore.Mvc;

namespace EaseeRisk.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class RiskController(IRelationshipRepository relationshipRepository,
                            IRepository<RiskAssessmentTemplate, CreateRiskAssessmentTemplate> templateRepository,
                            IRepository<RiskIndicatorGroup, CreateRiskIndicatorGroup> indicatorRepository,
                            ILogger<RiskController> logger) : ControllerBase
{
    [HttpGet("templates")]
    public Task<IEnumerable<RiskAssessmentTemplate>> GetTemplates(CancellationToken cancellationToken)
    {
        return templateRepository.Get(cancellationToken);
    }

    [HttpPost("templates")]
    public Task<RiskAssessmentTemplate> Post([FromBody] CreateRiskAssessmentTemplate riskAssessmentTemplate, CancellationToken cancellationToken)
    {
        return templateRepository.Create(riskAssessmentTemplate, cancellationToken);
    }

    [HttpGet("templates/{templateId}")]
    public Task<RiskAssessmentTemplate?> Get(string templateId, CancellationToken cancellationToken)
    {
        return templateRepository.Get(templateId, cancellationToken);
    }

    [HttpPost("indicator-groups")]
    public Task<RiskIndicatorGroup> Post([FromBody] CreateRiskIndicatorGroup riskIndicatorGroup, CancellationToken cancellationToken)
    {
        return indicatorRepository.Create(riskIndicatorGroup, cancellationToken);
    }

    [HttpPost("templates/{templateId}/indicator-groups")]
    public Task<RiskIndicatorGroup> Post([FromBody] string[] riskIndicators, string templateId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    [HttpPut("templates/{templateId}/indicator-groups/{indicatorId}")]
    public Task<TemplateIndicatorRelation> Put(string templateId, string indicatorId, CancellationToken cancellationToken)
    {
        return relationshipRepository.Add<RiskAssessmentTemplate, RiskIndicatorGroup, TemplateIndicatorRelation>(indicatorId,
            templateId, new TemplateIndicatorRelation(), cancellationToken);
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