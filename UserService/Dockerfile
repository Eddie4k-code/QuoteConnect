FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

# Copy solution file and individual project files for dependency restoration
COPY UserService.sln .
COPY UserService.Domain/UserService.Domain.csproj UserService.Domain/
COPY UserService.Infrastructure/UserService.Infrastructure.csproj UserService.Infrastructure/
COPY UserService.Application/UserService.Application.csproj UserService.Application/
COPY UserService.UnitTests/UserService.UnitTests.csproj UserService.UnitTests/
RUN dotnet restore

# Copy the entire project files and build the app
COPY . ./
WORKDIR /source/UserService.Application
RUN dotnet publish -c release -o /app --no-restore

# Final stage (optional, uncomment if publishing)
# FROM mcr.microsoft.com/dotnet/aspnet:8.0
# WORKDIR /app
# COPY --from=build /app ./
# ENTRYPOINT ["dotnet", "UserService.dll"]
