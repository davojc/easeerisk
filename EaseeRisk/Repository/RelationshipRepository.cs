using SurrealDb.Net;
using SurrealDb.Net.Models;

namespace EaseeRisk.Repository;

public class RelationshipRepository(ISurrealDbClient client) : IRelationshipRepository
{
    public async Task<TRelation> Add<TRelation>(TRelation tRelation, CancellationToken cancellationToken) where TRelation : RelationRecord, new()
    {
        return await client.InsertRelation<TRelation>(typeof(TRelation).Name, tRelation, cancellationToken);
    }
}