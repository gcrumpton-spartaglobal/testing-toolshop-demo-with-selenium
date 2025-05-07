# Use a base image with .NET 8 SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory
WORKDIR /app

# Copy the project file and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the rest of the application files
COPY . .

# Build the application
RUN dotnet publish -c Release -o /app/publish

# Use a smaller runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final

# Set the working directory
WORKDIR /app

# Copy the published application from the build stage
COPY --from=build /app/publish .

# Run tests
RUN dotnet test "testing-toolshop-demo-with-selenium.csproj"

# Set the entry point for the application
ENTRYPOINT ["dotnet", "testing-toolshop-demo-with-selenium.dll"]