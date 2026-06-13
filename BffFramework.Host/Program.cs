using BffFramework.Core.ServiceExtension;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddBff()
                .AddMockFeature();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
