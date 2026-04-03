using Shared.API.Data;

// This namespace is usually required for Middleware extension methods

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSqlServer<DataContext>(builder.Configuration.GetConnectionString("LocalConnection"));

var app = builder.Build();

// --- HTTP Request Pipeline Section ---
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    // Modern aesthetic: Enable the Swagger UI in development mode
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();