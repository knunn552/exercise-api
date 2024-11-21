# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Install the EF Core tools
RUN dotnet tool install --global dotnet-ef

# Add the dotnet tools directory to PATH
ENV PATH="$PATH:/root/.dotnet/tools"

# Copy the API project file
COPY exercise-api.csproj ./ 

# Restore dependencies
RUN dotnet restore

# Copy the rest of the project files
COPY . . 

# Publish the app
RUN dotnet publish -c Release -o /out

# Create the EF migration bundle
RUN dotnet ef migrations bundle --self-contained -r linux-x64 -o /out/migrations

# Use the ASP.NET Core runtime image for the final container
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copy the published API and EF migration bundle from the build stage
COPY --from=build /out . 

# Expose the port the app runs on
EXPOSE 5291

# Create a shell script to run migrations and then start the app
RUN echo "#!/bin/sh \n\
    echo 'Running EF Migrations...'\n\
    ./migrations/efbundle && \n\
    echo 'Starting API...'\n\
    dotnet exercise-api.dll" > /entrypoint.sh

# Make the shell script executable
RUN chmod +x /entrypoint.sh

# Set the startup command to use the shell script
ENTRYPOINT ["/entrypoint.sh"]
