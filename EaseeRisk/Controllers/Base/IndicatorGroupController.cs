using EaseeRisk.Model.Templates;
using EaseeRisk.Repository;
using EaseeRisk.Requests;
using Microsoft.AspNetCore.Mvc;

namespace EaseeRisk.Controllers.Base;

[ApiController]
[Route("/api/risk/indicator-groups")]
public class IndicatorGroupController(IRepository<IndicatorGroup, CreateRiskIndicatorGroupRequest> repository)
    : GeneralModelControllerBase<IndicatorGroup, CreateRiskIndicatorGroupRequest>(repository)
{
}