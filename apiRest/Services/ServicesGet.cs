using apiRest.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace apiRest.Services;

public class ServicesGet
{
    public ServicesGet()
    {
    }

    public FoundObject getById(string id)
    {
        DishModel result = new DishModel();
        bool isFound = false;

        foreach (DishModel dish in Program.dishes)
        {
            if (dish.getId() == id)
            {
                Console.WriteLine("Plato con id " + id + " encontrado");
                result = dish;
                isFound = true;
                break;
            }
        }

        return new FoundObject(result, isFound);

    }

}
