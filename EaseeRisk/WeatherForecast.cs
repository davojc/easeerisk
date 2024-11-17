using EaseeRisk.Model;
using EaseeRisk.Repository;
using SurrealDb.Net.Models;

namespace EaseeRisk;


public static class RepoExtensions
{
    public static void AddRepository<T, TDto>(this IServiceCollection services) where T : Record
    {
        services.AddSingleton<IRepository<T, TDto>, Repository<T, TDto>>();
    }
}