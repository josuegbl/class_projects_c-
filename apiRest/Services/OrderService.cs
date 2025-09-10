using apiRest.Models;

namespace apiRest.Services;

public class OrderService
{
    public List<OrderModel> order;

    public OrderService() 
    { 
    }

    public float getTotalPrice(OrderModel order)
    {
        if (order.getTotalPrice() == null)
        {
            totalPrice = 0;

            foreach (string dishId in this.dishesList)
            {
                bool idFound = false;

                DishModel dish = DishService.getDishById(dishId);

                bool isEmpty = dish.Name == null && dish.Price == null;
                if (isEmpty)
                {
                    totalPrice = -1;
                    break;
                }
                else
                {
                    for (int i = 0; i < this.quantityList.Count; i++)
                    {
                        if (this.quantityList[i].GetDishId() == dish.Id)
                        {
                            totalPrice += dish.Price * this.quantityList[i].GetQuantity();
                            idFound = true;
                            break;
                        }
                    }

                    if (!idFound)
                    { totalPrice += dish.Price; }
                }
            }
            order.setTotalPrice(totalPrice);
        }
        return order.getTotalPrice();
    }

    public void fillOrderModel(OrderModelDTO orderModelDTO)
    {

    }

}
