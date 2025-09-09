using apiRest.Models;
using apiRest.Repository;

namespace apiRest.Services;

public class DishService
{

    public static List<DishModel> dishes;

    public DishService()
    {
        LoadRepository repo = new LoadRepository();
    }

    public List<DishModel> GetDishes()
    {
        return LoadRepository.Dishes;
    }


}
