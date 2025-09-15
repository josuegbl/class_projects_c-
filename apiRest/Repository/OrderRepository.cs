using apiRest.Models;

namespace apiRest.Repository;

public class OrderRepository
{
    private static List<OrderModel> orders;

    public static List<OrderModel> Orders { get => orders; set => orders = value; }

    public OrderRepository()
    {
        OrderRepository.Orders = OrderRepository.genOrders();
    }

    public static void addOrder(OrderModel value)
    {
        OrderRepository.Orders.Add(value);
    }

    private static List<OrderModel> genOrders()
    {
        List<OrderModel> result = new List<OrderModel>();
        return result;
    }


}
