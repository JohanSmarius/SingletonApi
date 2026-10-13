using SingletonApi;

var builder = WebApplication.CreateBuilder(args);

// Note: ValidateScopes is disabled to demonstrate runtime concurrency failures
// that occur in production environments where scope validation is turned off.
builder.Host.UseDefaultServiceProvider(options =>
{
    options.ValidateScopes = false;
    options.ValidateOnBuild = false;
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddTransient<NumberGenerator>();
builder.Services.AddTransient<SomeOtherGenerator>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();