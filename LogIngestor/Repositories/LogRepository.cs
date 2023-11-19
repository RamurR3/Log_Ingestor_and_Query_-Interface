// LogIngestor/Repositories/LogRepository.cs 
 
using LogIngestor.Models; 
using System; 
using System.Threading.Tasks; 
 
public class LogRepository : ILogRepository 
{ 
    public async Task IngestLogAsync(LogModel log) 
    { 
        Console.WriteLine($"Log Ingested: Level: {log.Level}, Message: {log.Message}, Timestamp: {log.Timestamp}"); 
        // You can extend this method to store logs in a more persistent storage like a database 
        await Task.CompletedTask; 
    } 
} 
