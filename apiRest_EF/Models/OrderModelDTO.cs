namespace apiRest.Models;

public class OrderModelDTO
{

    public string UserId { get; set; }
    public List<string> DishesList { get; set; }
    public List<int>? QuantityList { get; set; }

    public OrderModelDTO()
    {
    }

}
