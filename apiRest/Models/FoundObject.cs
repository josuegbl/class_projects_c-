namespace apiRest.Models;

public class FoundObject
{
    DishModel dish;
    bool isFound;
    public FoundObject()
    {
    }

    public FoundObject(DishModel dish, bool isFound)
    {
        this.dish = dish;
        this.isFound = isFound;
    }
    public DishModel Dish { get => dish; set => dish = value; }
    public bool IsFound { get => isFound; set => isFound = value; }

}
