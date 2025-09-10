using apiRest.Services;

namespace apiRest.Models;

public class OrderModel
{
    private string id;
    private string userId;
    private float? totalPrice;
    private List<string> dishesList;
    private List<QuantityModel> quantityList;

    public OrderModel()
    {

    }

    public OrderModel(string id, string userId, List<string> dishesList, List<QuantityModel> quantityList)
    {
        this.Id = id;
        this.UserId = userId;
        this.dishesList = dishesList;
        this.quantityList = quantityList;

    }

    public string Id { get => id; set => id = value; }
    public string UserId { get => userId; set => userId = value; }
    public List<string> DishesList { get => dishesList; set => dishesList = value; }
    public List<QuantityModel> QuantityList { get => quantityList; set => quantityList = value; }

    public void setTotalPrice(int totalPrice)
    {
        this.totalPrice = totalPrice;
    }

    public float getTotalPrice()
    {
        return this.totalPrice;
    }
        
}
