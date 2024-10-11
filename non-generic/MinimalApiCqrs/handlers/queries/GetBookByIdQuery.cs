namespace MinimalApiCqrs;

public class GetBookByIdQuery(BookReadRepository repo)
{
    private readonly BookReadRepository repo = repo;

    public Book? Handle(Guid Id) {
        return repo.GetById(Id);
    }
}