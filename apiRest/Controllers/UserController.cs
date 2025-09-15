using apiRest.Models;
using apiRest.Services;
using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace apiRest.Controllers;

[Route("api/")]
[ApiController]
public class UserController : ControllerBase
{
    UserService userService = new UserService();

    [HttpGet("users")]
    public IActionResult getUsers()
    {
        Console.WriteLine("getUsers");

        UserServResponse servResponse = userService.getUsers();
        return Ok(servResponse.Users.ToList());
    }

    [HttpGet("users/{id}")]
    public IActionResult GetUserById(string id)
    {
        Console.WriteLine("getUserById");
        Console.WriteLine("La id del usuario a buscar es " + id);

        UserServResponse servResponse = userService.getDishById(id);

        return Ok(servResponse.Users.ToList());
    }

    //[HttpPost("users")]

    //public UserModel createUser(
    //    [FromBody] UserModel user
    //)
    //{
    //    Console.WriteLine("createUser");
    //    Console.WriteLine("La id del user es " + user.getId());
    //    Console.WriteLine("el name del user es " + user.getName());
    //    Console.WriteLine("La  age del user es " + user.getAge());

    //    Program.users.Add(user);

    //    return user;
    //}

    //[HttpPut("users/{id}")]

    //public UserModel updateUser(
    //[FromBody] UserModel user, string id
    //)
    //{
    //    Console.WriteLine("updateUser");
    //    Console.WriteLine("La id del user en param URL es " + id);
    //    Console.WriteLine("La id del user en update es " + user.getId());
    //    Console.WriteLine("el name del user en update  es " + user.getName());
    //    Console.WriteLine("La  age del user  en update es " + user.getAge());

    //    foreach (UserModel userInList in Program.users)
    //    {
    //        if (userInList.getId() == id)
    //        {
    //            Console.WriteLine("Usuario con id " + id + " encontrado, actulizando");
    //            userInList.setId(user.getId());
    //            userInList.setName(user.getName());
    //            userInList.setAge(user.getAge());
    //        }
    //    }


    //    return user;
    //}

    //[HttpPatch("users/{id}")]

    //public UserModel updatePatchUser([FromBody] UpdateUserModel updateUser, string id)
    //{
    //    Console.WriteLine("patchUser");
    //    Console.WriteLine("La id del user en param URL es " + id);

    //    UserModel userUpdated = new UserModel();

    //    foreach (UserModel user in Program.users)
    //    {
    //        if (user.getId() == id)
    //        {
    //            Console.WriteLine("Usuario con id " + id + " encontrado, actualizando");
    //            if (updateUser.Name != null)
    //            {
    //                user.setName(updateUser.Name);
    //            }
    //            if (updateUser.Age > 0)
    //            {
    //                user.setAge(updateUser.Age.Value);
    //            }
    //            userUpdated = user;
    //        }
    //    }

    //    Console.WriteLine("el name del user en update  es " + userUpdated.getName());
    //    Console.WriteLine("La  age del user  en update es " + userUpdated.getAge());


    //    return userUpdated;
    //}


    //[HttpDelete("users/{id}")]

    //public IActionResult deleteUser(string id)
    //{
    //    int codeResult = 404;
    //    Console.WriteLine("deleteUser");
    //    Console.WriteLine("La id del user a borrar en param URL es " + id);

    //    UserModel userToRemove = new UserModel();

    //    foreach (UserModel user in Program.users)
    //    {
    //        if (user.getId() == id)
    //        {
    //            userToRemove = user;
    //            Program.users.Remove(userToRemove);
    //            codeResult = 204;
    //            Console.WriteLine("Usuario con id " + id + " encontrado");
    //            break;

    //        }
    //    }
    //    return new StatusCodeResult(codeResult);
    //}




}
