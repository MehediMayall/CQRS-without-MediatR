namespace MinimalApiCqrs;

public static class Books {

    public static void AddBooksEndpoints(this IEndpointRouteBuilder app) {

        app.MapGet("books", (BookReadRepository repo) =>{
            return Results.Ok(
                new GetBookQuery(repo).Handle()
            );
        });

        app.MapGet("books/{id}", (Guid id, BookReadRepository repo) =>{
            return Results.Ok(
                new GetBookByIdQuery(repo).Handle(id)
            );
        });

        app.MapPost("books", (Book book, BookWriteRepository repo) =>{
            new AddBookCommand(repo).Handle(book);
            return Results.Ok();
        });

        app.MapPut("books", (Book book, BookWriteRepository repo) =>{
            new UpdateBookCommand(repo).Handle(book);
            return Results.NoContent();
        });

        app.MapDelete("books/{id}", (Guid id, BookWriteRepository repo) =>{
            new DeleteBookCommand(repo).Handle(id);
            return Results.NoContent();
        });        

    }
}