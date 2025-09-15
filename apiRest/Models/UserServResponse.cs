namespace apiRest.Models
{
    public class UserServResponse
    {
        private int isOk;
        private List<UserModel> users;
        private string message;

        public UserServResponse()
        {
        }

        public int IsOk { get => isOk; set => isOk = value; }
        public List<UserModel> Users { get => users; set => users = value; }
        public string Message { get => message; set => message = value; }

    }
}
