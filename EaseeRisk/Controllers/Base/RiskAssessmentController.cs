using EaseeRisk.Model.Assessments;
using EaseeRisk.Repository;
using EaseeRisk.Requests;
using Microsoft.AspNetCore.Mvc;

namespace EaseeRisk.Controllers.Base;

[ApiController]
[Route("/api/risk/assessments")]
public class RiskAssessmentController(IRepository<RiskAssessment, CreateRiskAssesmentRequest> repository)
    : GeneralModelControllerBase<RiskAssessment, CreateRiskAssesmentRequest>(repository)
{
}