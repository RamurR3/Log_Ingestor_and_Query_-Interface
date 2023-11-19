// QueryInterface/Services/IQueryService.cs

using System.Collections.Generic;
using QueryInterface.Models;

public interface IQueryService
{
    IEnumerable<LogModel> SearchLogs(QueryModel query);
}
