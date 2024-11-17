using EaseeRisk.Model;
using EaseeRisk.Store;

namespace EaseeRisk;


public static class RepoExtensions
{
    public static void AddRepository<T, TDto>(this IServiceCollection services)
    {
        services.AddSingleton<IRepository<T, TDto>, Repository<T, TDto>>();
    }
}