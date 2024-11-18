using EaseeRisk.Model;
using EaseeRisk.Repository;
using EaseeRisk.Requests;
using Microsoft.AspNetCore.Mvc;

namespace EaseeRisk.Controllers.Base;

[ApiController]
[Route("/api/risk/assessments")]
public class RiskAssessmentController(IRepository<RiskAssesment, CreateRiskAssesmentRequest> repository)
    : GeneralModelControllerBase<RiskAssesment, CreateRiskAssesmentRequest>(repository)
{
}