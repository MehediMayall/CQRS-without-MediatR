namespace MinimalApiCqrs;

public class GetMovieQuery(IMovieReadRepository repo)
{
    private readonly IMovieReadRepository repo = repo;

    public async Task<List<Movie>> Handle() {
        return await repo.GetAll();
    }
}