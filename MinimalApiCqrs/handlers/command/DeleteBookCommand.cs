namespace MinimalApiCqrs;

public class DeleteBookCommand(BookWriteRepository repo){
    private readonly BookWriteRepository repo = repo;

    public void Handle(Guid Id){        
        repo.Delete(Id);
    }
}