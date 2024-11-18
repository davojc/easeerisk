using EaseeRisk.Model;
using EaseeRisk.Repository;
using EaseeRisk.Requests;
using Microsoft.AspNetCore.Mvc;

namespace EaseeRisk.Controllers.Base;

[ApiController]
[Route("/api/risk/riskindicators")]
public class RiskIndicatorsController(IRepository<RiskIndicator, CreateRiskIndicatorRequest> repository)
    : GeneralModelControllerBase<RiskIndicator, CreateRiskIndicatorRequest>(repository)
{
}