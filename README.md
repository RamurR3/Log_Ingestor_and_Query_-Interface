
```markdown
# Log and Query System

This repository contains two components: LogIngestor and QueryInterface, designed to manage and query logs.

## LogIngestor

The LogIngestor component is responsible for ingesting logs into the system. It exposes a simple API for log ingestion.

### Code Structure

- **Models**
  - `LogModel.cs`: Defines the structure of a log entry.
- **Services**
  - `ILogService.cs`: Service interface for log ingestion.
  - `LogService.cs`: Service implementation for log ingestion.
- **Repositories**
  - `ILogRepository.cs`: Repository interface for storing logs.
  - `LogRepository.cs`: Repository implementation for storing logs.
- **Controllers**
  - `LogController.cs`: API controller for log ingestion.
- **Startup**
  - `Startup.cs`: Configures and sets up the application.

### Usage

To ingest a log, send a POST request to `/Log` with a JSON payload following the defined LogModel structure.

```json
{
	"level": "error",
	"message": "Failed to connect to DB",
	"resourceId": "server-1234",
	"timestamp": "2023-09-15T08:00:00Z",
	"traceId": "abc-xyz-123",
	"spanId": "span-456",
	"commit": "5e5342f",
	"metadata": {
		"parentResourceId": "server-0987"
	}
}
```

## QueryInterface

The QueryInterface component provides an API for querying logs based on specified parameters.

### Code Structure

- **Models**
  - `QueryModel.cs`: Defines the structure of a query for log search.
- **Services**
  - `IQueryService.cs`: Service interface for log queries.
  - `QueryService.cs`: Service implementation for log queries.
- **Controllers**
  - `QueryController.cs`: API controller for log queries.
- **Startup**
  - `Startup.cs`: Configures and sets up the application.

### Usage

To search for logs, send a GET request to `/Query` with query parameters following the defined QueryModel structure.

```json
{
	"level": "error",
	"message": "Failed to connect to DB",
	"resourceId": "server-1234",
	"startTimestamp": "2023-09-01T00:00:00Z",
	"endTimestamp": "2023-09-30T23:59:59Z",
	"traceId": "abc-xyz-123",
	"spanId": "span-456",
	"commit": "5e5342f",
	"parentResourceId": "server-0987"
}
```

## Getting Started

1. Clone the repository:

```bash
git clone https://github.com/yourusername/your-repo.git
cd your-repo
```

2. Build and run the LogIngestor and QueryInterface components.

3. Ingest logs using LogIngestor API and query logs using QueryInterface API.

