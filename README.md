# ReCap Backend — Car Rental API

A layered C# learning backend for car rental operations, with cars, brands, colors, customers, rentals, images, and authentication-related components.

Related client: [ReCap Frontend](https://github.com/Murat-Selim/Recap_Frontend).

## Architecture

| Folder | Responsibility |
| --- | --- |
| `WebAPI/` | HTTP controllers and application startup |
| `Business/` | Services, validation, and business rules |
| `DataAccess/` | Entity Framework repositories and `RentACarContext` |
| `Entities/` | Rental domain entities and DTOs |
| `Core/` | Shared infrastructure |
| `ConsoleUI/` | Console exercises |

## Local setup

The application targets .NET Core 3.1 and uses SQL Server. Use a matching development environment; update the legacy target before considering production deployment.

1. Prepare a development SQL Server database. Inspect `RentACar.sql` before importing it; do not run database scripts against an existing production database.
2. Adapt the connection configuration in `DataAccess/Concrete/EntityFramework/RentACarContext.cs` to your local `RentACar` database.
3. Review the application settings under `WebAPI/`, including any token settings. Keep real credentials out of commits.

```sh
git clone https://github.com/Murat-Selim/Recap_Backend.git
cd Recap_Backend
dotnet restore ReCapProject.sln
dotnet build ReCapProject.sln
dotnet run --project WebAPI/WebAPI.csproj
```

The `WebAPI` launch profile uses `https://localhost:5001` and `http://localhost:5000`. The related Angular client currently points at IIS Express port `44375`; use the matching launch profile or update the client service URLs.

## Usage and validation

Inspect `WebAPI/Controllers/` for endpoint routes and request formats. There is no dedicated automated test project in the repository. Build the solution and manually verify the affected API flow with development data; do not treat a successful build as end-to-end validation.

## License and attribution

No repository-wide license file is currently declared. Preserve original course and third-party notices when reusing the exercises.
