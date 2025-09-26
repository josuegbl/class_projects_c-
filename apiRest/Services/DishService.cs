using apiRest.Models;
using apiRest.Repository;
using Microsoft.AspNetCore.Identity;

namespace apiRest.Services;

public class DishService
{

    public DishService()
    {
        Console.WriteLine("paso por el constructor del servicio");
        if (DishRepository.Dishes == null)
        {
            DishRepository.Dishes = DishRepository.genDishes();
        }
    }

    public List<DishModel> GetDishes()
    {
        Console.WriteLine("cuantos dishes: " + DishRepository.Dishes.Count());
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

    public void createDish(DishModel dish)
    {
        DishRepository.addDish(dish);
    }

}
