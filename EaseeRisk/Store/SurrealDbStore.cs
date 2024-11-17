using System.Reflection;
using AutoMapper;
using EaseeRisk.Model;
using SurrealDb.Net;
using SurrealDb.Net.Models;

namespace EaseeRisk.Store;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public class TableAttribute(string name) : Attribute
{
    public string Name { get; } = name;
}

internal static class Tables
{
    public const string RiskAssessmentTemplate = "riskassessmenttemplate";
    public const string RiskIndicatorGroup = "riskindicatorgroup";
    public const string TemplateGroups = "risktemplategroups";
}

public class TemplateIndicatorRelation : Record
{

}

public class SurrealDbStore : IRiskAssessmentStore
{
    private readonly ISurrealDbClient _client;
    private readonly IMapper _mapper;

    public SurrealDbStore(ISurrealDbClient client)
    {
        _client = client;

        var configuration = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<CreateRiskAssessmentTemplate, RiskAssessmentTemplate>();
            cfg.CreateMap<CreateRiskIndicatorGroup, RiskIndicatorGroup>();
        });

        _mapper = configuration.CreateMapper();
    }


    public async Task<RiskAssessmentTemplate> AddRiskAssessmentTemplate(CreateRiskAssessmentTemplate createRiskAssessmentTemplate, CancellationToken cancellationToken)
    {
        var riskAssTemp = _mapper.Map<RiskAssessmentTemplate>(createRiskAssessmentTemplate);
        return await _client.Create(Tables.RiskAssessmentTemplate, riskAssTemp, cancellationToken);
    }

    public Task<IEnumerable<RiskAssessmentTemplate>> GetAssessmentTemplates(CancellationToken cancellationToken)
    {
        return _client.Select<RiskAssessmentTemplate>(Tables.RiskAssessmentTemplate, cancellationToken);
    }

    public async Task<RiskIndicatorGroup> AddRiskIndicatorGroup(CreateRiskIndicatorGroup createRiskIndicatorGroup, string templateId, CancellationToken cancellationToken)
    {
        var model = new RiskIndicatorGroup
        {
            Name = createRiskIndicatorGroup.Name,
        };

        var result = await _client.Create(Tables.RiskIndicatorGroup, model, cancellationToken);

        var parentId = RecordId.From(Tables.RiskAssessmentTemplate, templateId);

        var relation = _client.Relate<TemplateIndicatorRelation>(Tables.TemplateGroups, parentId, result.Id, cancellationToken);

        return await Task.FromResult(result);
    }

    public RiskAssessmentTemplate GetAssessmentTemplateById(string id)
    {
        throw new NotImplementedException();
    }
}