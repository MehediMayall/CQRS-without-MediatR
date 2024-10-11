namespace MinimalApiCqrs;

public interface IReadRepository<T> where T : class
{
    Task<List<T>> GetAll();
    Task<T?> GetById(Guid id);
}