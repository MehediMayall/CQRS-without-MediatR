namespace MinimalApiCqrs;

public abstract class EntityBase {
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime UpdatedOn { get; set; }

}