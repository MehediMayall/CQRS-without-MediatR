namespace MinimalApiCqrs;

public class UpdateMovieCommand(IMovieWriteRepository repo, IMovieReadRepository readRepo){
    private readonly IMovieWriteRepository repo = repo;
    private readonly IMovieReadRepository readRepo = readRepo;

    public async Task Handle(Movie movie){   
        Movie? existingMovie =  await readRepo.GetById(movie.Id);    

        if (existingMovie is null)
            throw new Exception("Movie not found with Id: " + movie.Id);

        existingMovie.Name = movie.Name;
        existingMovie.Country = movie.Country;
        existingMovie.Director = movie.Director;
        existingMovie.Rating = movie.Rating;

        await repo.Update(existingMovie);
    }
}