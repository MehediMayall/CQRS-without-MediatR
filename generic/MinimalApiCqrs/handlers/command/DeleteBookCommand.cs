namespace MinimalApiCqrs;

public class DeleteMovieCommand(IMovieWriteRepository repo){
    private readonly IMovieWriteRepository repo = repo;

    public async Task Handle(Guid Id){        
        await repo.Delete(Id);
    }
}