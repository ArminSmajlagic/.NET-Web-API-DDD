# .NET DDD Web API - Currently under development!

## Description
This is anBanking Web API developed in .NET 7 &amp; C# 11. 

Main objective:
- Use DDD, SOLID and DRY principles
- Create reusable elements with aid of design patterns and OOP
- Offer variaty of technologies such as : 
  - SQL/NoSQL 
  - gRPC/WebSockets/HTTP 
  - Caching 
  - Messeging Queue 
  - Tests 
  - and so mucm more
- provide the user with :
  - Abillity to have an account
  - Create transfers (transaction)
  - Take loans
  - Perform billing on the accounts

## Design Patterns that are used to implement the project

- CQRS/Repository
- Unit Of Work (Transactions)
- Command (Undo/Redo)
- Observer (Notifications)
- Mediator (Orchestrator)
- Template methode (Startup Init)
- Factory (Creation)
- Singleton (Creation)
- Transient (Creation)
- Scoped (Creation)

## Technologies that system deppends on

<b>Databases technologies:</b>
- MongoDB 
- Mongo Express/MongoDB Shell (Querying & Management tools)
- MS SQL
- SQL Server
- Entity Framework 6/Dapper

<b>DevOps:</b>
- Docker + Kubernetes
- Teraform + Azure (CI/CD)
- MongoDB Atlas (Deployment to cloud)

<b>Internet protocols:</b>
- gRPC
- HTTP
- WebSocket

<b>Other:</b>
- XUnit tests
- Azure MQ
- Redis/In-Memory Caching
- ELK + Serilog (Logging - > Ingestion -> Transforming -> Visualazing)
- OpenAPI 2.0 with Swagger UI

# Including best C# features up to version 11 :
- Records
- Async/IProgress<>/CancellationToken
- Locks
- LINQ expressions
- Span<> & Memory<>
- IDisposable & Finalizer 
- ICollection & IQueryable
- Tuples & Deconstructing
- Default Interfaces
- Extension Methodes
- Generics
- Covariance & Contravariance
- Lambdas
- Pattern matching
- Custom Filters
- Custom Attributes
- Custom Midlewere

## Useful Links

- Base application url: http://localhost:8000
- Swagger Documentation : http://localhost:8000/swagger-ui/index.html
- Redis commander: http://localhost:8081
- CloudBeaver: http://localhost:8082
- MongoExpress:  http://localhost:8083

## Diagram

Coming Soon UML documentation & system block diagram!

Author: Armin Smajlagic



