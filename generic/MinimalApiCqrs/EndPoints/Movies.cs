using Microsoft.AspNetCore.Mvc;

namespace MinimalApiCqrs;

public static class Movies {

    public static void AddMoviesEndpoints(this IEndpointRouteBuilder app) {

        // GET ALL MOVIES
        app.MapGet("Movies", async (IMovieReadRepository repo) =>{
            List<Movie> movies = await new GetMovieQuery(repo).Handle();
            return movies is null ? Results.NotFound() :  Results.Ok(movies);
        });

        // GET MOVIE BY ID
        app.MapGet("Movies/{id}", async (Guid id, IMovieReadRepository repo) =>{
            Movie? movie = await new GetMovieByIdQuery(repo).Handle(id);
            return movie is null ? Results.NotFound() :  Results.Ok(movie);
        });

        // ADD MOVIE
        app.MapPost("Movies", async ([FromBody] Movie Movie, IMovieWriteRepository repo) =>{
            var id = await new AddMovieCommand(repo).Handle(Movie);
            return Results.Ok(new { id = id });
        });

        // UPDATE MOVIE
        app.MapPut("Movies", async ([FromBody] Movie movie, IMovieWriteRepository repo, IMovieReadRepository readRepo) =>{
            await new UpdateMovieCommand(repo, readRepo).Handle(movie);
            return Results.NoContent();
        });

        // DELETE MOVIE
        app.MapDelete("Movies/{id}", async (Guid id, IMovieWriteRepository repo) =>{
            await new DeleteMovieCommand(repo).Handle(id);
            return Results.NoContent();
        });        

    }
}