clean-run: cleanup restore tests run

cleanup:
	dotnet clean src/ScoreService.API
	dotnet clean test/ScoreService.IntegrationTests
	dotnet clean test/ScoreService.Tests

restore:
	dotnet restore src/ScoreService.API
	dotnet restore test/ScoreService.IntegrationTests
	dotnet restore test/ScoreService.Tests

build:
	dotnet build src/ScoreService.API
	dotnet build test/ScoreService.IntegrationTests
	dotnet build test/ScoreService.Tests

run:
	dotnet run -p src/ScoreService.API/ScoreService.API.csproj

tests:
	dotnet test test/ScoreService.IntegrationTests/ScoreService.IntegrationTests.csproj
	dotnet test test/ScoreService.Tests/ScoreService.Tests.csproj
