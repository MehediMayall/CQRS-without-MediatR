namespace MinimalApiCqrs;

public  class BookReadRepository{

    public List<Book> Get() =>
        InMemonryDatabase.Books.Values.ToList();

    public Book? GetById(Guid Id) =>
        InMemonryDatabase.Books.TryGetValue(Id, out var book) ? book : default;

}