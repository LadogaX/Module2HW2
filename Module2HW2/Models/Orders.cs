namespace Module2HW2.Models
{
    public class Orders
    {
        public Orders(int capacity)
        {
            DataOrders = new Device[capacity];
        }

        public Device[] DataOrders { get; set; }
    }
}
