using apiRest.Models;
using apiRest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiRest.Controllers
{
    [Route("api/")]
    [ApiController]
    public class DishController : ControllerBase
    {
        ServicesGet servicesGet = new ServicesGet();

        [HttpGet("dishes")]
        public List<DishModel> GetDishes()
        {
            Console.WriteLine("getDishes");

            return Program.dishes;
        }

        [HttpGet("dishes/{id}")]
        public IActionResult getDisById(string id)
        {
            Console.WriteLine("getDishById");
            Console.WriteLine("La id del plato a buscar es " + id);

            DishModel result = new DishModel();
            bool isFound = false;

            foreach (DishModel dish in Program.dishes)
            {
                if (dish.getId() == id)
                {
                    Console.WriteLine("Plato con id " + id + " encontrado");
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

        [HttpGet("dishesByName/{name}")]
        public IActionResult getDisByName(string name)
        {
            Console.WriteLine("getDishByName");
            Console.WriteLine("El nombre del plato a buscar es " + name);

            name = name.Replace("_", " ").ToLower();

            Console.WriteLine("El nuevo nombre del plato a buscar es " + name);

            DishModel result = new DishModel();
            bool isFound = false;

            foreach (DishModel dish in Program.dishes)
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

            FoundObject foundDish = servicesGet.getById(id);

            if (foundDish.IsFound)
            {
                return Ok(foundDish.Dish);
            }
            else
                return BadRequest();


        }

        [HttpDelete("dishes/{id}")]

        public IActionResult deleteDish(string id)
        {
            Console.WriteLine("deleteDish");
            Console.WriteLine("La id del plato a borrar en param URL es " + id);
            int codeResult = 404;

            FoundObject foundDish = servicesGet.getById(id);

            if (foundDish.IsFound)
            {
                Program.dishes.Remove(foundDish.Dish);
                return Ok(foundDish.Dish);
            }
            else
                return BadRequest();
        }



    }
}
