using apiRest.Models;

namespace apiRest
{
    public class Program
    {
        public static List<DishModel> dishes;
        public static void Main(string[] args)
        {
            Program.dishes = Program.getDishes();

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }

        private static List<UserModel> getUserModels()
        {
            List<UserModel>  result = new List<UserModel>();

            result.Add(new UserModel("1", "Nombre1", 20));
            result.Add(new UserModel("2", "Nombre2", 30));
            result.Add(new UserModel("3", "Nombre3", 40));

            return result;
        }

        private static List<DishModel> getDishes()
        {
            List<DishModel>  result = new List<DishModel>();

            result.Add(new DishModel("1", "Pulpo a la gallega", 15.50));
            result.Add(new DishModel("2", "Paella Valenciana", 14.65));
            result.Add(new DishModel("3", "Chuleton de Avila", 40.00));

            return result;
        }

    }
}
