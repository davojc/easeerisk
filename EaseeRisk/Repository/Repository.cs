using AutoMapper;
using SurrealDb.Net;
using SurrealDb.Net.Models;

namespace EaseeRisk.Repository;

public class Repository<T, TRequest> : IRepository<T, TRequest> where T : Record
{
    private readonly ISurrealDbClient _client;
    private readonly IMapper _mapper;
    private readonly string _tableName;

    public Repository(ISurrealDbClient client)
    {
        _tableName = typeof(T).Name;

        _client = client;
        var configuration = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<TRequest, T>();
        });

        _mapper = configuration.CreateMapper();
    }

    public async Task<T> Create(TRequest dto, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<T>(dto);
        return await _client.Create(_tableName, model, cancellationToken);
    }

    public async Task<IEnumerable<T>> Get(CancellationToken cancellationToken)
    {
        return await _client.Select<T>(_tableName, cancellationToken);
    }

    public async Task<T?> Get(string id, CancellationToken cancellationToken)
    {
        return await _client.Select<T>(RecordId.From(_tableName, id), cancellationToken);
    }

    public async Task<IEnumerable<T>> Update(T data, CancellationToken cancellationToken)
    {
        return await _client.Update<T>(_tableName, data, cancellationToken);
    }

    public async Task<bool> Delete(string id, CancellationToken cancellationToken)
    {
        return await _client.Delete(RecordId.From(_tableName, id), cancellationToken);
    }
}