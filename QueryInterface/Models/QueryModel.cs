// QueryInterface/Models/QueryModel.cs

using System;

public class QueryModel
{
    public string Level { get; set; }
    public string Message { get; set; }
    public string ResourceId { get; set; }
    public DateTime StartTimestamp { get; set; }
    public DateTime EndTimestamp { get; set; }
    public string TraceId { get; set; }
    public string SpanId { get; set; }
    public string Commit { get; set; }
    public string ParentResourceId { get; set; }
}
