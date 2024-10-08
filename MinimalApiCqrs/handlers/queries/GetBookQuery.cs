namespace MinimalApiCqrs;

public class GetBookQuery(BookReadRepository repo)
{
    private readonly BookReadRepository repo = repo;

    public List<Book> Handle() {
        return repo.Get();
    }
}