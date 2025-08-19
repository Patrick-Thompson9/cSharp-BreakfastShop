namespace BreakfastShop.Contracts.Breakfast;

public record CreateBreakfastRequest(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    string[] Ingredients);