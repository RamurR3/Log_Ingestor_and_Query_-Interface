// LogIngestor/Repositories/ILogRepository.cs 
 
using LogIngestor.Models; 
using System.Threading.Tasks; 
 
public interface ILogRepository 
{ 
    Task IngestLogAsync(LogModel log); 
} 
