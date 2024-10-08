namespace MinimalApiCqrs;

public class AddBookCommand(BookWriteRepository repo){
    private readonly BookWriteRepository repo = repo;

    public void Handle(Book book){
        book.Id = Guid.NewGuid();
        repo.Add(book);
    }
}