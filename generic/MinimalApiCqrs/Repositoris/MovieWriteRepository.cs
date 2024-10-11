namespace MinimalApiCqrs;

public class MovieWriteRepository : IMovieWriteRepository{

    public async Task Add(Movie Movie) =>
        InMemoryDatabase.Movies.Add(Movie.Id, Movie);

    public async Task Update(Movie Movie){
        if ( !InMemoryDatabase.Movies.ContainsKey(Movie.Id) )
            throw new Exception("Movie not found with Id: " + Movie.Id);

        Movie.UpdatedOn = DateTime.Now;
        InMemoryDatabase.Movies[Movie.Id] = Movie;            
    } 


    public async Task Delete(Guid id) =>
        InMemoryDatabase.Movies.Remove(id);
}