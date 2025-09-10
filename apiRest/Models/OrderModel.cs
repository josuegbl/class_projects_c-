using apiRest.Services;

namespace apiRest.Models;

public class OrderModel
{
    private string id;
    private string userId;
    private float price;
    private List<string> dishesList;
    private List<QuantityModel> quantityList;

    public OrderModel()
    {

    }

    public OrderModel(string id, string userId, float price,  List<string> dishesList, List<QuantityModel> quantityList)
    {
        this.Id = id;
        this.UserId = userId;
        this.price = price;
        this.dishesList = dishesList;
        this.quantityList = quantityList;

    }

    public string Id { get => id; set => id = value; }
    public string UserId { get => userId; set => userId = value; }
    public float Price { get => price; set => price = value; }
    public List<string> DishesList { get => dishesList; set => dishesList = value; }
    public List<QuantityModel> QuantityList { get => quantityList; set => quantityList = value; }
}
