using SurrealDb.Net.Models;

namespace EaseeRisk.Repository;

public interface IRelationshipBuilder
{
    TRelation Build<TRelation, TFrom, TTo>(string fromId, string toId) where TRelation : RelationRecord, new();
}