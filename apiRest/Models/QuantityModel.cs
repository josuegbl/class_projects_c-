namespace apiRest.Models;

public class QuantityModel
{
    private string userId;
    private int quantity;

    public QuantityModel(string id, int amount)
    {
        this.userId = id;
        this.quantity = amount;
    }

    public string GetUserId()
    {
        return userId;
    }

    public void SetUserId(string value)
    {
        userId = value;
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