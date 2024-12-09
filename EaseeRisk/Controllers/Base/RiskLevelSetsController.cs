using EaseeRisk.Model.Templates;
using EaseeRisk.Repository;
using EaseeRisk.Requests;
using Microsoft.AspNetCore.Mvc;

namespace EaseeRisk.Controllers.Base;

[ApiController]
[Route("/api/risk/risklevelsets")]
public class RiskLevelSetsController(IRepository<RiskLevelSet, CreateRiskLevelSetRequest> repository)
    : GeneralModelControllerBase<RiskLevelSet, CreateRiskLevelSetRequest>(repository)
{
}