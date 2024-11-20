using EaseeRisk.Model;
using EaseeRisk.Repository;
using EaseeRisk.Requests;
using Microsoft.AspNetCore.Mvc;

namespace EaseeRisk.Controllers.Base;

[ApiController]
[Route("/api/risk/indicator-groups")]
public class IndicatorGroupController(IRepository<RiskIndicatorGroup, CreateRiskIndicatorGroupRequest> repository)
    : GeneralModelControllerBase<RiskIndicatorGroup, CreateRiskIndicatorGroupRequest>(repository)
{
}