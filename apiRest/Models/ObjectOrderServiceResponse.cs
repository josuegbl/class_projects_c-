namespace apiRest.Models
{
    public class ObjectOrderServiceResponse
    {
        bool isOk;
        OrderModel order;
        string message;

        public ObjectOrderServiceResponse()
        { 
        }

        public bool IsOk { get => isOk; set => isOk = value; }
        public OrderModel Order { get => order; set => order = value; }
        public string Message { get => message; set => message = value; }
    }
}
