namespace MinimalApiCqrs;

public class UpdateBookCommand(BookWriteRepository repo){
    private readonly BookWriteRepository repo = repo;

    public void Handle(Book book){        
        repo.Update(book);
    }
}