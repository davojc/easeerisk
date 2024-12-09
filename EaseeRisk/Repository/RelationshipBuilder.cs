using SurrealDb.Net.Models;

namespace EaseeRisk.Repository;

public class RelationshipBuilder : IRelationshipBuilder
{
    public TRelation Build<TRelation, TFrom, TTo>(string fromId, string toId) where TRelation : RelationRecord, new()
    {
        var relation = new TRelation
        {
            Out = RecordId.From(typeof(TFrom).Name.ToLowerInvariant(), fromId),
            In = RecordId.From(typeof(TTo).Name.ToLowerInvariant(), toId)
        };

        return relation;
    }
}