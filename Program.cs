using exercise_api.ExerciseContext;
using exercise_api.Repository;
using exercise_api.Service;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ExerciseDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddTransient<IExerciseRepository, ExerciseRepository>();
builder.Services.AddTransient<IExerciseService, ExerciseService>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

var app = builder.Build();

// Explicitly bind the app to port 5000
app.Urls.Add("http://0.0.0.0:5000");

using (var scope = app.Services.CreateScope())
{
    var service = scope.ServiceProvider;
    try
    {
        if (configuration["EF_MIGRATE"] == "true")
        {
            Console.WriteLine("Applying migrations...");
            var context = service.GetRequiredService<ExerciseDbContext>();
            await context.Database.MigrateAsync();
        }
        else
        {
            Console.WriteLine("EF Migration skipped.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error applying migrations: {ex.Message}");
    }
}



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
