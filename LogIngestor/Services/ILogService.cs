// LogIngestor/Services/ILogService.cs 
 
using LogIngestor.Models; 
using System.Threading.Tasks; 
 
public interface ILogService 
{ 
    Task IngestLogAsync(LogModel log); 
} 
