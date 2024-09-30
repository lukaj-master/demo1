using System.Net;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHealthChecks();
var app = builder.Build();

app.MapHealthChecks("/healthz");
app.MapGet("/", () => "Zdravo iz " + Dns.GetHostName() + "!");

app.Run();
