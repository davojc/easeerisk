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
        var result =  repository.Get(id, cancellationToken);

        return result;
    }

    [HttpPost]
    public Task<T> Post([FromBody] TCreate createBody, CancellationToken cancellationToken)
    {
        return repository.Create(createBody, cancellationToken);
    }

    [HttpPut("{id}")]
    public Task<T> Update(string id, [FromBody] T data, CancellationToken cancellationToken)
    {
        return repository.Update(id, data, cancellationToken);
    }

    [HttpDelete("{id}")]
    public Task<bool> Delete(string id, CancellationToken cancellationToken)
    {
        return repository.Delete(id, cancellationToken);
    }
}