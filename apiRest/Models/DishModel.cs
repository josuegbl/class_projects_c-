namespace apiRest.Models;

public class DishModel
{
    private string id;
    private string name;
    private float price;

    public string Id
    {
        get => id; set => id = value;
    }
    public string Name
    {
        get => name; set => name = value;
    }
    public float Price
    {
        get => price; set => price = value;
    }

    public DishModel()
    {
    }

    public DishModel(string id, string name, float price)
    {
        this.id = id;
        this.name = name;
        this.price = price;
    }

    public void setId(string id)
    {
        this.id = id;
    }
    public void setName(string name)
    {
        this.name = name;
    }
    public void setPrice(float price)
    {
        this.price = price;
    }
    public string getId()
    {
        return this.id;
    }
    public string getName()
    {
        return this.name;
    }
    public float getPrice()
    {
        return this.price;
    }
}
