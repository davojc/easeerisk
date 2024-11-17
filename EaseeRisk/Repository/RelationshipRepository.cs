using SurrealDb.Net;
using SurrealDb.Net.Models;

namespace EaseeRisk.Repository;

public class RelationshipRepository(ISurrealDbClient client) : IRelationshipRepository
{
    public async Task<TRelation> Add<TFrom, TTo, TRelation>(string fromId, string toId, TRelation tRelation, CancellationToken cancellationToken) 
        where TRelation : class
    {
        var toName = typeof(TTo).Name.ToLowerInvariant();
        var fromName = typeof(TFrom).Name.ToLowerInvariant();
        var relationTable = typeof(TRelation).Name.ToLowerInvariant();

        var toRecordId = RecordId.From(toName, toId);
        var fromRecordId = RecordId.From(fromName, fromId);

        return await client.Relate<TRelation>(relationTable, toRecordId, fromRecordId, cancellationToken);
    }
}