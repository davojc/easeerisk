using EaseeRisk.Model.Relations;
using SurrealDb.Net.Models;

namespace EaseeRisk.Repository;

public interface IRepository<T, in TRequest> where T : Record
{
    Task<T> Create(TRequest dto, CancellationToken cancellationToken);

    Task<IEnumerable<T>> Get(CancellationToken cancellationToken);

    Task<T?> Get(string id, CancellationToken cancellationToken);

    Task<IEnumerable<T>> Update(T data, CancellationToken cancellationToken);

    Task<bool> Delete(string id, CancellationToken cancellationToken);
}

public interface IRelationshipBuilder
{
    TRelation Build<TRelation, TFrom, TTo>(string fromId, string toId) where TRelation : RelationRecord, new();
}


public class RelationshipBuilder : IRelationshipBuilder
{
    public TRelation Build<TRelation, TFrom, TTo>(string fromId, string toId) where TRelation : RelationRecord, new()
    {
        var relation = new TRelation
        {
            Out = RecordId.From(typeof(TFrom).Name, fromId),
            In = RecordId.From(typeof(TTo).Name, toId)
        };

        return relation;
    }
}
