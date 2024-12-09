using EaseeRisk.Model;
using System.Text.Json;

namespace EaseeRisk.Client;

public interface IRiskClient
{
    Task<List<Template>> GetTemplatesAsync();

    Task<bool> CreateTemplateAsync(Template template);

    Task<bool> UpdateTemplateAsync(Template template);

    Task<bool> DeleteTemplateAsync(Template template);
}

public class RiskClient : IRiskClient
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUrl;

    public RiskClient(HttpClient httpClient, string baseUrl)
    {
        _httpClient = httpClient;
        _baseUrl = baseUrl;
    }
    public async Task<List<Template>> GetTemplatesAsync()
    {
        var response = await _httpClient.GetAsync("https://api.example.com/items");
        response.EnsureSuccessStatusCode();
        var json = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<List<Template>>(json);
    }

    public async Task<bool> CreateTemplateAsync(Template template)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> UpdateTemplateAsync(Template template)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteTemplateAsync(Template template)
    {
        throw new NotImplementedException();
    }
}