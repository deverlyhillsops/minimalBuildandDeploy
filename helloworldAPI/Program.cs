var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/wibble", () => "wibble!");
app.MapGet("/wobble", () => "wobble!");

app.Run();
