using apiRest.Models;
using apiRest.Repository;
using apiRest.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiRest.Controllers
{
    [Route("api/")]
    [ApiController]
    public class DishController : ControllerBase
    {
        DishService dishService = new DishService();
        [EnableCors]
        [HttpGet("dishes")]
        public List<DishModel> GetDishes()
        {
            Console.WriteLine("getDishes");

            return dishService.GetDishes();
        }

        [EnableCors]
        [HttpPost("dishes")]

        public IActionResult updateDish([FromBody] DishModel dish)
        {
            Console.WriteLine("create dish");

            dishService.createDish(dish);

            bool isEmpty = dish.Name == null && dish.Id == null;

            return Ok(dish);
        }



        [HttpGet("dishes/{id}")]
        public IActionResult getDisById(string id)
        {
            Console.WriteLine("getDishById");
            Console.WriteLine("La id del plato a buscar es " + id);

            DishModel dish = DishService.getDishById(id);
            bool isEmpty = dish.Name == null && dish.Id == null;

            if (!isEmpty)
            {
                return Ok(dish);
            }
            else
            {
                return new BadRequestResult();
            }
        }

        [HttpGet("dishesByName/{name}")]
        public IActionResult getDisByName(string name)
        {
            Console.WriteLine("getDishByName");
            Console.WriteLine("El nombre del plato a buscar es " + name);

            name = name.Replace("_", " ").ToLower();

            Console.WriteLine("El nuevo nombre del plato a buscar es " + name);

            DishModel result = new DishModel();
            bool isFound = false;

            foreach (DishModel dish in dishService.GetDishes())
            {
                string nameToCompare = dish.getName().ToLower();
                if (name == nameToCompare)
                {
                    Console.WriteLine("Plato con nombre " + name + " encontrado");
                    result = dish;
                    isFound = true;
                }
            }

            if (isFound)
            {
                return Ok(result);
            }
            else
            {
                return new BadRequestResult();
            }
        }

        [HttpPut("dishes/{id}")]

        public IActionResult updateDish([FromBody] DishModel dish, string id)
        {
            Console.WriteLine("updateDish");
            Console.WriteLine("La id del plato en param URL es " + id);

            DishModel origDish = DishService.getDishById(id);
            bool isEmpty = dish.Name == null && dish.Id == null;

            if (!isEmpty)
            {
                return Ok(dish);
            }
            else
                return BadRequest();
        }

        [HttpDelete("dishes/{id}")]

        public IActionResult deleteDish(string id)
        {
            Console.WriteLine("deleteDish");
            Console.WriteLine("La id del plato a borrar en param URL es " + id);

            DishModel origDish = DishService.getDishById(id);
            bool isEmpty = origDish.Name == null && origDish.Id == null;

            if (!isEmpty)
            {
                // reimplement this in a service. Im not sure if works right now
                dishService.GetDishes().Remove(origDish);
                return Ok(origDish);
            }
            else
                return BadRequest();
        }



    }
}
