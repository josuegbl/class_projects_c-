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

    public static DishModel getDishById(string id)
    {
        DishModel result = new DishModel();

        foreach (DishModel dish in LoadRepository.Dishes)
        {
            if (dish.getId() == id)
            {
                Console.WriteLine("Plato con id " + id + " encontrado");
                result = dish;
                break;
            }
        }
        
        return result;
    }

}
