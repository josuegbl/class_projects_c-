using apiRest.Models;
using apiRest.Repository;

namespace apiRest.Services;

public class DishService
{

    public static DishRepository dishRepo;

    public DishService()
    {
        DishService.dishRepo = new DishRepository();
    }

    public List<DishModel> GetDishes()
    {
        return DishRepository.Dishes;
    }

    public static DishModel getDishById(string id)
    {
        DishModel result = new DishModel();

        foreach (DishModel dish in DishRepository.Dishes)
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
