using EaseeRisk.Model;
using EaseeRisk.Repository;
using Microsoft.AspNetCore.Mvc;
using SurrealDb.Net.Models;

namespace EaseeRisk.Controllers;

public abstract class ParentChildRelationshipControllerBase<TParent, TChild, TRelation>(IRelationshipRepository relationshipRepository, IRelationshipBuilder relationshipBuilder)
    where TParent : Record
    where TChild : Record
    where TRelation : RelationRecord, new()
{
    [HttpGet]
    public Task<RiskIndicatorGroup> Get([FromBody] string[] riskIndicators, string templateId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    [HttpPut("{id}")]
    public Task<TRelation> Put(string parentId, string id, CancellationToken cancellationToken)
    {
        var relation = relationshipBuilder.Build<TRelation, TChild, TParent>(id, parentId);
        return relationshipRepository.Add(relation, cancellationToken);
    }
}