namespace MinimalApiCqrs;

public interface IWriteRepository<T> where T : class
{
    Task Add(T entity);
    Task Update(T entity);
    Task Delete(Guid id);
}