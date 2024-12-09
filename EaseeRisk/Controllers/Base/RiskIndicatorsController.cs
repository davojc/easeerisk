using EaseeRisk.Model.Templates;
using EaseeRisk.Repository;
using EaseeRisk.Requests;
using Microsoft.AspNetCore.Mvc;

namespace EaseeRisk.Controllers.Base;

[ApiController]
[Route("/api/risk/riskindicators")]
public class RiskIndicatorsController(IRepository<Indicator, CreateRiskIndicatorRequest> repository)
    : GeneralModelControllerBase<Indicator, CreateRiskIndicatorRequest>(repository)
{
}