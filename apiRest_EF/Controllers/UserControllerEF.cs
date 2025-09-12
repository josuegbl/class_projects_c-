using apiRest.Models;
using apiRest_EF.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiRest_EF.Controllers;

[Route("api/ef/")]
[ApiController]
public class UserControllerEF : ControllerBase
{
    [HttpGet("users")]
    public List<UserModel> getUsers()
    {
        Console.WriteLine("getUsers");

        UserContext userContext = new UserContext();

        return userContext.Users.ToList();
    }


    [HttpGet("users/{id}")]
    public UserModel GetUserById(string id)
    {
        Console.WriteLine("getUserById");
        Console.WriteLine("el usuario a buscar es " + id);

        UserContext userContext = new UserContext();

        UserModel result = userContext.Users.Find(id);

        if (result == null)
        {
            result = new UserModel();
        }
        else
        {
            Console.WriteLine("Usuario con id " + id + " encontrado");
        }

        return result;
    }

    [HttpPut("users/{id}")]

    public UserModel updateUser([FromBody] UserModel user, string id)
    {
        Console.WriteLine("updateUser");
        Console.WriteLine("La id del user en param URL es " + id);
        Console.WriteLine("La id del user en update es " + user.getId());
        Console.WriteLine("el name del user en update  es " + user.getName());
        Console.WriteLine("La  age del user  en update es " + user.getAge());

        UserContext userContext = new UserContext();

        UserModel result = userContext.Users.Find(id);

        if (result == null)
        {

            Console.WriteLine("Usuario no encontrado");
        }
        else
        {
            Console.WriteLine("Usuario con id " + id + " encontrado");
            result.setName(user.getName());
            result.setAge(user.getAge());

            userContext.SaveChanges();
        }

        return result;


    }


    [HttpPost("users")]
    public UserModel createUser([FromBody] UserModel user)
    {
        Console.WriteLine("createUser");
        Console.WriteLine("La id del user es " + user.getId());
        Console.WriteLine("el name del user es " + user.getName());
        Console.WriteLine("La  age del user es " + user.getAge());

        UserContext userContext = new UserContext();

        userContext.Users.Add(user);
        userContext.SaveChanges();

        return user;
    }

    [HttpDelete("users/{id}")]

    public UserModel deleteUser(string id)
    {
        int codeResult = 404;
        Console.WriteLine("deleteUser");
        Console.WriteLine("La id del user a borrar en param URL es " + id);

        UserContext userContext = new UserContext();

        UserModel result = userContext.Users.Find(id);

        if (result == null)
        {

            Console.WriteLine("Usuario no encontrado");
        }
        else
        {
            Console.WriteLine("Usuario con id " + id + " borrando");
            userContext.Users.Remove(result);

            userContext.SaveChanges();
        }

        return result;
    }
}

