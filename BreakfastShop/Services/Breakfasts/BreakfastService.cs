using BreakfastShop.Models;

namespace BreakfastShop.Services.Breakfasts;

public class BreakfastService : IBreakfastService
{
    private static readonly Dictionary<Guid, Breakfast> _breakfasts = new();
    public void CreateBreakfast(Breakfast breakfast)
    {
        _breakfasts.Add(breakfast.Id, breakfast);
    }

    public Breakfast GetBreakfast(Guid id)
    {
        return _breakfasts[id];
    }

    public Breakfast UpsertBreakfast(Breakfast breakfast)
    {
        _breakfasts[breakfast.Id] = breakfast;
        return breakfast;
    }

    public void DeleteBreakfast(Guid id)
    {
        _breakfasts.Remove(id);
    }
}