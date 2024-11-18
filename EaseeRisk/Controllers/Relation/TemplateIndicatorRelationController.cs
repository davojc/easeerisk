using EaseeRisk.Model;
using EaseeRisk.Model.Relations;
using EaseeRisk.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EaseeRisk.Controllers.Relation;

[ApiController]
[Route("/api/templates/{parentId}/indicator-groups")]
public class TemplateIndicatorRelationController(IRelationshipRepository relationshipRepository, IRelationshipBuilder relationshipBuilder) : ParentChildRelationshipControllerBase<RiskAssessmentTemplate,
    RiskIndicatorGroup, TemplateIndicatorRelation>(relationshipRepository, relationshipBuilder)
{
}

/*
[ApiController]
[Route("/api/[controller]")]
public class RiskController(IRelationshipRepository relationshipRepository,
                            IRelationshipBuilder relationshipBuilder,
                            ILogger<RiskController> logger) : ControllerBase
{
    [HttpGet("templates/{templateId}/indicator-groups")]
    public Task<RiskIndicatorGroup> Post([FromBody] string[] riskIndicators, string templateId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    [HttpPut("templates/{templateId}/indicator-groups/{indicatorId}")]
    public Task<TemplateIndicatorRelation> Put(string templateId, string indicatorId, CancellationToken cancellationToken)
    {
        var relation = relationshipBuilder.Build<TemplateIndicatorRelation, RiskIndicatorGroup, RiskAssessmentTemplate>(indicatorId, templateId);

        return relationshipRepository.Add(relation, cancellationToken);
    }
}*/