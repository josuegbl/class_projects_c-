using apiRest.Models;

namespace apiRest.Repository;

public class DishRepository
{
    public static List<DishModel>? Dishes { get; set; }

    public DishRepository()
    {
        DishRepository.Dishes = DishRepository.genDishes();
    }

    public static void addDish(DishModel value)
    {
        DishRepository.Dishes.Add(value);

        Console.WriteLine("Agrego plato: " + DishRepository.Dishes.Count());
    }

    public static List<DishModel> genDishes()
    {
        List<DishModel> result = new List<DishModel>();

        result.Add(new DishModel("1", "Pulpo a la gallega", 15.50F));
        result.Add(new DishModel("2", "Paella Valenciana", 14.65F));
        result.Add(new DishModel("3", "Chuleton de Avila", 40.00F));

        return result;
    }

}
