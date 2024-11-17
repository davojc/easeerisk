namespace EaseeRisk.Store;

public interface IRepository<T, in TDto>
{
    Task<T> Create(TDto dto, CancellationToken cancellationToken);

    Task<IEnumerable<T>> Get(CancellationToken cancellationToken);

    Task<T?> Get(string id, CancellationToken cancellationToken);
}