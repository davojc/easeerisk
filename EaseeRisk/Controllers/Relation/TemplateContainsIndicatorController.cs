using EaseeRisk.Model.Relations;
using EaseeRisk.Model.Templates;
using EaseeRisk.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EaseeRisk.Controllers.Relation;

[ApiController]
[Route("/api/risk/templates/{parentId}/indicator-groups")]
public class TemplateContainsIndicatorController(IRelationshipRepository relationshipRepository, IRelationshipBuilder relationshipBuilder) : RelationshipControllerBase<Template,
    IndicatorGroup, Contains>(relationshipRepository, relationshipBuilder)
{
}

[ApiController]
[Route("/api/risk/indicator-groups/{parentId}/riskindicators")]
public class IndicatorGroupsContainsRiskIndicatorController(IRelationshipRepository relationshipRepository, IRelationshipBuilder relationshipBuilder) : RelationshipControllerBase<IndicatorGroup,
    Indicator, Contains>(relationshipRepository, relationshipBuilder)
{
}