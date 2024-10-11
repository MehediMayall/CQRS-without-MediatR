using MinimalApiCqrs;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddTransient<IMovieReadRepository, MovieReadRepository>();
builder.Services.AddTransient<IMovieWriteRepository, MovieWriteRepository>();


var app = builder.Build();

app.MapGet("/", () => { return Results.Ok("Lookes everything is ok"); });

app.UseHttpsRedirection();
app.AddMoviesEndpoints();

app.Run();
