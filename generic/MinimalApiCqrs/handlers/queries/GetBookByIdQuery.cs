namespace MinimalApiCqrs;

public class GetMovieByIdQuery(IMovieReadRepository repo)
{
    private readonly IMovieReadRepository repo = repo;

    public async Task<Movie?> Handle(Guid Id) {
        return await repo.GetById(Id);
    }
}