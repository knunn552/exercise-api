# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy the API project file
COPY exercise-api.csproj ./ 

# Restore dependencies
RUN dotnet restore

# Copy the rest of the project files
COPY . . 

# Publish the app
RUN dotnet publish -c Release -o /out

# Use the ASP.NET Core runtime image for the final container
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copy the published API from the build stage
COPY --from=build /out . 

# Expose the port the app runs on
EXPOSE 5291

# Set the entry point to start the API
ENTRYPOINT ["dotnet", "exercise-api.dll"]
