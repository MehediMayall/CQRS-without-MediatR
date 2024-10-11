namespace MinimalApiCqrs;

public class InMemoryDatabase{
    public static readonly Dictionary<Guid, Movie> Movies = new();

}