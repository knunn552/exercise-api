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

using (var scope = app.Services.CreateScope())
{
    var service = scope.ServiceProvider;
    try
    {
        if (builder.Configuration["EF_MIGRATE"] == "true")
        {
            var context = service.GetRequiredService<ExerciseDbContext>();
            await context.Database.MigrateAsync();
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
