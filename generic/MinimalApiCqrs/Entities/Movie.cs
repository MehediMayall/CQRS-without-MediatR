namespace MinimalApiCqrs;


public sealed class Movie : EntityBase {
    public string Name { get; set; }
    public string Director { get; set; }
    public string Country { get; set; }
    public float Rating { get; set; }
}