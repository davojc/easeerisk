using EaseeRisk.Model.Templates;
using EaseeRisk.Repository;
using EaseeRisk.Requests;
using Microsoft.AspNetCore.Mvc;

namespace EaseeRisk.Controllers.Base;

[ApiController]
[Route("/api/risk/templates")]
public class TemplatesController(IRepository<Template, CreateRiskAssessmentTemplateRequest> repository)
    : GeneralModelControllerBase<Template, CreateRiskAssessmentTemplateRequest>(repository)
{
}