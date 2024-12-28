using exercise_api.ExerciseContext;
using exercise_api.Repository;
using exercise_api.Service;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentVariables();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = Environment.GetEnvironmentVariable("API_DB_CONNECTION_STRING")
    ?? throw new InvalidOperationException("Database connection string is not set. Please configure 'API_DB_CONNECTION_STRING'.");

builder.Services.AddDbContext<ExerciseDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddTransient<IExerciseRepository, ExerciseRepository>();
builder.Services.AddTransient<IExerciseService, ExerciseService>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

var app = builder.Build();


if(Environment.GetEnvironmentVariable("AWS_EC2") == "true")
{
    app.Urls.Add("http://0.0.0.0:5000");
}


using (var scope = app.Services.CreateScope())
{
    var service = scope.ServiceProvider;

    try
    {
        var efMigrate = Environment.GetEnvironmentVariable("EF_MIGRATE");

        if (!string.IsNullOrEmpty(efMigrate) && efMigrate.ToLower() == "true")
        {
            Console.WriteLine("EF_MIGRATE is set to true. Applying migrations...");
            var context = service.GetRequiredService<ExerciseDbContext>();

            const int maxRetryCount = 5;
            const int delayMilliseconds = 5000;
            int retryCount = 0;

            while (retryCount < maxRetryCount)
            {
                try
                {
                    await context.Database.MigrateAsync();
                    Console.WriteLine("Migrations applied successfully.");
                    break; // Exit the retry loop if successful
                }
                catch (Exception ex)
                {
                    retryCount++;
                    Console.WriteLine($"Migration attempt {retryCount} failed: {ex.Message}");
                    if (retryCount == maxRetryCount)
                    {
                        Console.WriteLine("Max retry attempts reached. Migration failed.");
                        throw; // Re-throw the exception to stop the app from running
                    }
                    Console.WriteLine($"Retrying in {delayMilliseconds / 1000} seconds...");
                    await Task.Delay(delayMilliseconds);
                }
            }
        }
        else
        {
            Console.WriteLine("EF_MIGRATE is not set to true. Skipping migrations.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error applying migrations: {ex.Message}");
    }
}


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
