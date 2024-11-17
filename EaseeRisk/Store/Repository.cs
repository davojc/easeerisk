using AutoMapper;
using SurrealDb.Net;
using SurrealDb.Net.Models;

namespace EaseeRisk.Store;

public class Repository<T, TDto> : IRepository<T, TDto>
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
            cfg.CreateMap<TDto, T>();
        });

        _mapper = configuration.CreateMapper();
    }

    public async Task<T> Create(TDto dto, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<T>(dto);
        return await _client.Create(_tableName, model, cancellationToken);
    }

    public Task<IEnumerable<T>> Get(CancellationToken cancellationToken)
    {
        return _client.Select<T>(_tableName, cancellationToken);
    }

    public Task<T?> Get(string id, CancellationToken cancellationToken)
    {
        return _client.Select<T>(RecordId.From(_tableName, id), cancellationToken);
    }
}