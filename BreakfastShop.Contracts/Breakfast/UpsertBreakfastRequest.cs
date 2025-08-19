namespace BreakfastShop.Contracts.Breakfast;

public record UpsertBreakfastRequest(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    string[] Ingredients);