// LogIngestor/Controllers/LogController.cs 
 
using Microsoft.AspNetCore.Mvc; 
using LogIngestor.Models; 
using LogIngestor.Services; 
using System.Threading.Tasks; 
 
[ApiController] 
[Route("[controller]")] 
public class LogController : ControllerBase 
{ 
    private readonly ILogService _logService; 
 
    public LogController(ILogService logService) 
    { 
        _logService = logService; 
    } 
 
    [HttpPost] 
    { 
        await _logService.IngestLogAsync(log); 
        return Ok(); 
    } 
} 
