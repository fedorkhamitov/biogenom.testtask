using Biogenom.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Biogenom.Api.Controllers;

[ApiController]
[Route("api")]
public class ReportController : ControllerBase
{
    [HttpGet("report")]
    public async Task<ActionResult> GetLastReport([FromServices] ReportService reportService)
    {
        var reportDto = await reportService.GetLastReportAsync();
        return reportDto == null ? NotFound() : Ok(reportDto);
    }
}