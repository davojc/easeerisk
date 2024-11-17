namespace EaseeRisk.Repository;

public interface IRelationshipRepository
{
    Task<TRelation> Add<TFrom, TTo, TRelation>(string fromId, string toId, TRelation tRelation,
        CancellationToken cancellationToken)
        where TRelation : class;
}