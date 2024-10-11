namespace MinimalApiCqrs;

public  class InMemoryDatabase{
    public static readonly Dictionary<Guid, Book> Books = new();

}