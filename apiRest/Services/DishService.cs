//using apiRest.Models;
//using apiRest.Repository;

//namespace apiRest.Services;

//public class DishService
//{

//    public static List<DishModel> dishes;

//    public DishService()
//    {
//        OrderRepository repo = new LoadRepository();
//    }

//    public List<DishModel> GetDishes()
//    {
//        return OrderRepository.Dishes;
//    }

//    public static DishModel getDishById(string id)
//    {
//        DishModel result = new DishModel();

//        foreach (DishModel dish in OrderRepository.Dishes)
//        {
//            if (dish.getId() == id)
//            {
//                Console.WriteLine("Plato con id " + id + " encontrado");
//                result = dish;
//                break;
//            }
//        }
        
//        return result;
//    }

//}
