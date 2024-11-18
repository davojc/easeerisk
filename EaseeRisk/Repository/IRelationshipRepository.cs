using SurrealDb.Net.Models;

namespace EaseeRisk.Repository;

public interface IRelationshipRepository
{
    Task<TRelation> Add<TRelation>(TRelation tRelation, CancellationToken cancellationToken)
        where TRelation : RelationRecord, new();
}