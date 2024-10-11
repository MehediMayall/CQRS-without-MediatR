namespace MinimalApiCqrs;

public class AddMovieCommand(IMovieWriteRepository repo){
    private readonly IMovieWriteRepository repo = repo;

    public async Task<Guid> Handle(Movie movie){
        movie.Id = Guid.NewGuid();
        await repo.Add(movie);
        return movie.Id ;
    }
}