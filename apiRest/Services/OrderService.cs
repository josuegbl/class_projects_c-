//using apiRest.Models;
//using apiRest.Repository;

//namespace apiRest.Services;

//public class OrderService
//{
//    public List<OrderModel> orders;

//    public OrderService() 
//    {
//        OrderRepository repo = new OrderRepository();

//    }

//    public List<OrderModel> GetOrders()
//    {
//       return OrderRepository.Orders;
//    }

//    private void getTotalPrice(OrderModel order)
//    {
//        float totalPrice = 0;

//        foreach (string dishId in order.DishesList)
//        {
//            bool idFound = false;

//            DishModel dish = DishService.getDishById(dishId);

//            for (int i = 0; i < order.QuantityList.Count; i++)
//            {
//                if (order.QuantityList[i].GetDishId() == dish.Id)
//                {
//                    if (dish.Price != null)
//                    {
//                        totalPrice += (float)dish.Price * order.QuantityList[i].GetQuantity();
//                        idFound = true;
//                        break;
//                    }
//                }
//            }

//            if (!idFound)
//            { totalPrice += (float)dish.Price; }
//        }
//        order.Price = totalPrice;
//    }

//    private OrderModel fillOrderModel(OrderModelDTO orderModelDTO)
//    {
//        List<OrderModel> orderList = OrderRepository.Orders;

//        int intId = OrderRepository.Orders.Count;

//        List<QuantityModel> amountList = new List<QuantityModel>();

//        for (int i = 0; i < orderModelDTO.QuantityList.Count; i++)
//        {
//            QuantityModel amountObj = new QuantityModel(orderModelDTO.DishesList[i]
//                                                        , orderModelDTO.QuantityList[i]);
//            amountList.Add(amountObj);
//        }
//        string orderId = intId.ToString();


//        OrderModel order = new OrderModel(orderId
//                                        , orderModelDTO.UserId
//                                        , -1
//                                        , orderModelDTO.DishesList
//                                        , amountList);

//        getTotalPrice(order);
//        OrderRepository.addOrder(order);
//        return order;
//    }

//    private OrderModel getOrderById(string id)
//    {
//        OrderModel result = new OrderModel();

//        foreach (OrderModel order in OrderRepository.Orders)
//        {
//            if (order.Id == id)
//            {
//                Console.WriteLine("Plato con id " + id + " encontrado");
//                result = order;
//                break;
//            }
//        }
//        return result;
//    }

//    public ObjectOrderServiceResponse createobjectOrderServiceResponse(OrderModel order)
//    {
//        ObjectOrderServiceResponse objOrderService = new ObjectOrderServiceResponse();
//        objOrderService.Order = order;
//        objOrderService.IsOk = true;

//        return objOrderService;

//    }

//    public ObjectOrderServiceResponse createOrderService(OrderModelDTO orderModelDTO)
//    {
//        OrderModel order = fillOrderModel(orderModelDTO);
//        ObjectOrderServiceResponse objOrderService = createobjectOrderServiceResponse(order);

//        return objOrderService;
//    }

//}
