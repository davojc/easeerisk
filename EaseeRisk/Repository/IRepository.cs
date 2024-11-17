using SurrealDb.Net.Models;

namespace EaseeRisk.Repository;

public interface IRepository<T, in TRequest> where T : Record
{
    Task<T> Create(TRequest dto, CancellationToken cancellationToken);

    Task<IEnumerable<T>> Get(CancellationToken cancellationToken);

    Task<T?> Get(string id, CancellationToken cancellationToken);
}