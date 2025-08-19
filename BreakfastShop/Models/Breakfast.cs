namespace BreakfastShop.Models;

public class Breakfast
{
    public Guid Id { get; }
    public string Name { get; }
    public string Description { get; }
    public DateTime CreatedAt { get; }
    public DateTime UpdatedAt { get; }
    public DateTime LastUpdated { get; }
    public string[] Ingredients { get; }

    public Breakfast(
        Guid id,
        string name,
        string description,
        DateTime createdAt,
        DateTime updatedAt,
        DateTime lastUpdated,
        string[] ingredients)
    {
        Id = id;
        Name = name;
        Description = description;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
        LastUpdated = lastUpdated;
        Ingredients = ingredients;
    }

}