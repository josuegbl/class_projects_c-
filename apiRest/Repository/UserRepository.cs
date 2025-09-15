using System.ComponentModel.DataAnnotations;
using apiRest.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace apiRest.Repository;

public class UserRepository
{
    private static UserContext userContext;
    private static List<UserModel> users;


    public UserRepository()
    {
        if(users == null)
        {
            UserRepository.userContext = new UserContext();
            Console.WriteLine("genrero usuarios");
            genUsers();
        }

    }

    public static List<UserModel> getUsers()
    {
        return UserRepository.users;
    }

    public static void setUsers(List<UserModel> value)
    {
        UserRepository.users = value;
        if (UserRepository.userContext.Users == null)
        {
            UserRepository.users.ForEach(user => UserRepository.userContext.Add(user));
            UserRepository.userContext.SaveChanges();
        }

    }

    public static void addUser(UserModel value)
    {
        UserRepository.userContext.Users.Add(value);
        UserRepository.userContext.SaveChanges();
    }

    private void genUsers()
    {
        Random random = new Random();
        int maxLenght = random.Next(4, 7);
        List<string> namesList = ["Antonio", "Luis", "Claudia", "Guillermo", "Laura", "Maria"];
        List<UserModel> result = new List<UserModel>();

        for (int i = 0; i < maxLenght; i++)
        {
            result.Add(new UserModel(i.ToString()
                                   , namesList[random.Next(0, 6)]
                                   , random.Next(20, 80)));
        }
        setUsers(result);
    }

}
