// LogIngestor/Services/LogService.cs 
 
using LogIngestor.Models; 
using LogIngestor.Repositories; 
using System.Threading.Tasks; 
 
public class LogService : ILogService 
{ 
    private readonly ILogRepository _logRepository; 
 
    public LogService(ILogRepository logRepository) 
    { 
        _logRepository = logRepository; 
    } 
 
    public async Task IngestLogAsync(LogModel log) 
    { 
        await _logRepository.IngestLogAsync(log); 
    } 
} 
