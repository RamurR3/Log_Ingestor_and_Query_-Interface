// LogIngestor/Models/LogModel.cs 
 
using System; 
 
namespace LogIngestor.Models 
{ 
 
    public class LogModel 
    { 
        public string Level { get; set; } 
        public string Message { get; set; } 
        public string ResourceId { get; set; } 
        public DateTime Timestamp { get; set; } 
        public string TraceId { get; set; } 
        public string SpanId { get; set; } 
        public string Commit { get; set; } 
        public MetadataModel Metadata { get; set; } 
    } 
 
    public class MetadataModel 
    { 
        public string ParentResourceId { get; set; } 
    } 
} 
