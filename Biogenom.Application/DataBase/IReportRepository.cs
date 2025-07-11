using Biogenom.Domain.Entities.Reports;

namespace Biogenom.Application.DataBase;

public interface IReportRepository
{
    Task<Report?> GetLastReportAsync();
}