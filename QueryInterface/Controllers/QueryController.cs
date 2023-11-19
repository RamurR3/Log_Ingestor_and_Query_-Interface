// QueryInterface/Controllers/QueryController.cs

using Microsoft.AspNetCore.Mvc;
using QueryInterface.Models;
using QueryInterface.Services;

[ApiController]
[Route("[controller]")]
public class QueryController : ControllerBase
{
    private readonly IQueryService _queryService;

    public QueryController(IQueryService queryService)
    {
        _queryService = queryService;
    }

    [HttpGet]
    public IActionResult SearchLogs([FromQuery] QueryModel query)
    {
        var result = _queryService.SearchLogs(query);
        return Ok(result);
    }
}
