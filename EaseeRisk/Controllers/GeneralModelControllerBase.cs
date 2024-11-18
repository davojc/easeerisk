using EaseeRisk.Repository;
using Microsoft.AspNetCore.Mvc;
using SurrealDb.Net.Models;

namespace EaseeRisk.Controllers;

public abstract class GeneralModelControllerBase<T, TCreate>(IRepository<T, TCreate> repository) : ControllerBase where T : Record
{
    [HttpGet]
    public Task<IEnumerable<T>> Get(CancellationToken cancellationToken)
    {
        return repository.Get(cancellationToken);
    }

    [HttpGet("{id}")]
    public Task<T?> Get(string id, CancellationToken cancellationToken)
    {
        return repository.Get(id, cancellationToken);
    }

    [HttpPost]
    public Task<T> Post([FromBody] TCreate createBody, CancellationToken cancellationToken)
    {
        return repository.Create(createBody, cancellationToken);
    }

    [HttpPut]
    public Task<IEnumerable<T>> Update([FromBody] T data, CancellationToken cancellationToken)
    {
        return repository.Update(data, cancellationToken);
    }

    [HttpDelete("{id}")]
    public Task<bool> Delete(string id, CancellationToken cancellationToken)
    {
        return repository.Delete(id, cancellationToken);
    }
}