using EaseeRisk.Model;

namespace EaseeRisk.Client;

public interface IRiskClient
{
    Task<List<Template>> GetTemplatesAsync();

    Task<bool> CreateTemplateAsync(Template template);

    Task<bool> UpdateTemplateAsync(Template template);

    Task<bool> DeleteTemplateAsync(Template template);
}