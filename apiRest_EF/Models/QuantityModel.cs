namespace apiRest.Models;

public class QuantityModel
{
    private string dishId;
    private int quantity;

    public QuantityModel(string id, int amount)
    {
        this.dishId = id;
        this.quantity = amount;
    }

    public string GetDishId()
    {
        return this.dishId;
    }

    public void SetUserId(string value)
    {
        dishId = value;
    }

    public int GetQuantity()
    {
        return quantity;
    }

    public void SetQuantity(int value)
    {
        quantity = value;
    }
}