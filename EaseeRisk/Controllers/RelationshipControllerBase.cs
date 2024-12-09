using EaseeRisk.Model.Templates;
using EaseeRisk.Repository;
using Microsoft.AspNetCore.Mvc;
using SurrealDb.Net.Models;

namespace EaseeRisk.Controllers;

public abstract class RelationshipControllerBase<TParent, TChild, TRelation>(IRelationshipRepository relationshipRepository, IRelationshipBuilder relationshipBuilder)
    where TParent : Record
    where TChild : Record
    where TRelation : RelationRecord, new()
{
    [HttpGet]
    public Task<IndicatorGroup> Get([FromBody] string[] riskIndicators, string templateId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    [HttpPut("{id}")]
    public Task<TRelation> Put(string parentId, string id, CancellationToken cancellationToken)
    {
        var relation = relationshipBuilder.Build<TRelation, TParent, TChild>(parentId, id);
        return relationshipRepository.Add(relation, cancellationToken);
    }
}