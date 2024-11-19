# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy the API project file (as Dockerfile is inside the 'exercise-api' folder)
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
COPY --from=build /out .

# Expose the port the app runs on
EXPOSE 5279

# Set the startup command
ENTRYPOINT ["dotnet", "exercise-api.dll"]
