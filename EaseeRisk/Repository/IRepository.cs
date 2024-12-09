using EaseeRisk.Model.Relations;
using SurrealDb.Net.Models;

namespace EaseeRisk.Repository;

public interface IRepository<T, in TRequest> where T : Record
{
    Task<T> Create(TRequest dto, CancellationToken cancellationToken);

    Task<IEnumerable<T>> Get(CancellationToken cancellationToken);

    Task<T?> Get(string id, CancellationToken cancellationToken);

    Task<T> Update(string id, T data, CancellationToken cancellationToken);

    Task<bool> Delete(string id, CancellationToken cancellationToken);
}