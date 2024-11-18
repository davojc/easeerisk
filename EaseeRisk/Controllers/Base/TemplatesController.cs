using EaseeRisk.Model;
using EaseeRisk.Repository;
using EaseeRisk.Requests;
using Microsoft.AspNetCore.Mvc;

namespace EaseeRisk.Controllers.Base;

[ApiController]
[Route("/api/risk/templates")]
public class TemplatesController(IRepository<RiskAssessmentTemplate, CreateRiskAssessmentTemplate> repository)
    : GeneralModelControllerBase<RiskAssessmentTemplate, CreateRiskAssessmentTemplate>(repository)
{
}