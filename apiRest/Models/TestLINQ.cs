using System.Runtime.InteropServices;
using apiRest.Repository;

namespace apiRest.Models
{
    public class TestLINQ
    {
        public static void testLINQ()
        {
            Console.WriteLine("testLINQ");
            LoadRepository repo = new LoadRepository();

            Console.WriteLine("Query SYNTAX");
            List<UserModel> result =
                (from user in LoadRepository.Users
                 where user.Age == 40
                 select user).ToList();
            List<string> resultName =
                (from user in LoadRepository.Users
                 where user.Age == 40
                 select user.Name).ToList();

            result.ForEach(
                user => Console.WriteLine(user));


            //-------------------
            Console.WriteLine("METHOD SYNTAX");

            result = LoadRepository.Users.Select(user => user).ToList();

            result.ForEach(user => Console.WriteLine(user));

            result =
                LoadRepository.Users
                .Select(user => user)
                .Where(user => user.Name == "Nombre1")
                .ToList();

            List<string> dishName =
                LoadRepository.Dishes
                .Where(dish => dish.Name.Contains('a') && dish.Price >= 30)
                .Select(dish => dish.Name)
                .ToList();

            dishName.ForEach(dish => Console.WriteLine(dish));

            List<DishModel> dishesOrdered =
                LoadRepository.Dishes
                .Select(user => user) //optional
                .Where(dish => dish.Id == "1" || dish.Id == "2")
                .OrderByDescending(dish => dish.Price)
                .ToList();

            dishesOrdered.ForEach(
                dish => Console.WriteLine(dish));


            int UserCount =
                LoadRepository.Users
                .Select(user => user)
                .Count();

            Console.WriteLine("hay " + UserCount + " usuarios");

            int UserMaxAge =
                LoadRepository.Users
                .Select(user => user)
                .Where(user => user.Name.Contains('o'))
                .Max(user => user.Age);

            float sumDishPrice =
                LoadRepository.Dishes
                .Select(dish => dish)
                .Where(dish => dish.Name.Contains('o'))
                .Sum(dish => (float)dish.Price);
            Console.WriteLine("suma platos " + sumDishPrice);

            float avgDishPrice =
                LoadRepository.Dishes
                .Select(dish => dish)
                .Where(dish => dish.Name.Contains('o'))
                .Average(dish => (float)dish.Price);
            Console.WriteLine("el promedio de los precios es " + avgDishPrice);

            float sumDishPriceAggregated =
                LoadRepository.Dishes
                .Select(dish => dish)
                .Aggregate(
                    0F, (sum, dish) => sum += (float)dish.Price
                    );

            Console.WriteLine("TRANSFORMACION");

            var dishNamesProj =
                LoadRepository.Dishes
                .Where(dish => dish.Name.Contains('a') && dish.Price >= 10)
                .Select(dish => new { dish.Name })
                .ToList();

            dishNamesProj.ForEach(
                dishName => Console.WriteLine(dishName)
                );
            Console.WriteLine(dishNamesProj);


            Dictionary<string, DishModel> dishNamesProjDic =
                LoadRepository.Dishes
                .Select(dish => dish)
                .ToDictionary(
                    dish => dish.Name
                    );

            foreach(string dishNam in dishNamesProjDic.Keys)
            {
                Console.WriteLine(dishNam);
            }

            foreach(DishModel dish in dishNamesProjDic.Values)
            {
                Console.WriteLine(dish);
            }

        }

    }
}
