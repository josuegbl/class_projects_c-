using apiRest.Models;

namespace apiRest.Repository;

public class LoadRepository
{
    private static List<OrderModel> orders;
    private static List<DishModel> dishes;
    private static List<UserModel> users;

    public static List<OrderModel> Orders { get => orders; set => orders = value; }
    public static List<DishModel> Dishes { get => dishes; set => dishes = value; }
    public static List<UserModel> Users { get => users; set => users = value; }

    public LoadRepository()
    {
        LoadRepository.Users = LoadRepository.genUsers();
        LoadRepository.Dishes = LoadRepository.genDishes();
        LoadRepository.Orders = LoadRepository.genOrders();
    }

    public static void addOrder(OrderModel value)
    {
        LoadRepository.Orders.Add(value);
    }
    public static void addDish(DishModel value)
    {
        LoadRepository.Dishes.Add(value);
    }
    public static void addUser(UserModel value)
    {
        LoadRepository.Users.Add(value);
    }

    private static List<UserModel> genUsers()
    {
        List<UserModel> result = new List<UserModel>();

        result.Add(new UserModel("1", "Nombre1", 20));
        result.Add(new UserModel("2", "Nombre2", 30));
        result.Add(new UserModel("3", "Nombre3", 40));

        return result;
    }

    private static List<DishModel> genDishes()
    {
        List<DishModel> result = new List<DishModel>();

        result.Add(new DishModel("1", "Pulpo a la gallega", 15.50F));
        result.Add(new DishModel("2", "Paella Valenciana", 14.65F));
        result.Add(new DishModel("3", "Chuleton de Avila", 40.00F));

        return result;
    }

    private static List<OrderModel> genOrders()
    {
        List<OrderModel> result = new List<OrderModel>();
        return result;
    }


}
