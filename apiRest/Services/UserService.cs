using apiRest.Models;
using apiRest.Repository;

namespace apiRest.Services;

public class UserService
{
    private static UserRepository userRepo;

    public UserService()
    {
        UserService.userRepo = new UserRepository();
    }

    public UserServResponse getUsers()
    {
        // all business rules (i.e. banned users) are taken into account here.
        List<UserModel> result = UserRepository.getUsers();

        UserServResponse servResponse = createUserResponse(204, result, "");
        return servResponse;
    }
    public UserServResponse getDishById(string id)
    {

        List<UserModel> users = UserRepository.getUsers();

        List<UserModel> result = users.Where(user => user.Id == id).ToList();

        Console.WriteLine("user; " + result[0].ToString());

        UserServResponse servResponse = createUserResponse(204, result, "");

        return servResponse;
    }

    public UserServResponse createUserResponse(int code
                                           , List<UserModel> users
                                           , string sms)
    {
        UserServResponse servResponse = new UserServResponse();
        servResponse.Users = users;
        servResponse.IsOk = code;
        servResponse.Message = sms;

        return servResponse;
    }


}
