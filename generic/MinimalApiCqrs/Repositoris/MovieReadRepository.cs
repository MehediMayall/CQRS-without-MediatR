namespace MinimalApiCqrs;

public  class MovieReadRepository : IMovieReadRepository{

    public async Task<List<Movie>> GetAll() =>
        InMemoryDatabase.Movies.Values.ToList();

    public async Task<Movie?> GetById(Guid Id) =>
        InMemoryDatabase.Movies.TryGetValue(Id, out var Movie) ? Movie : default;

}