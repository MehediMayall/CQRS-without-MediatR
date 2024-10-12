// In this struct we have two interactions with the database.
// First, we have to retrieve the movie from the database.
// Second, we have to replace the old movie with the new one and update the movie in the database.
// This has to be done in loosely coupled way.

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