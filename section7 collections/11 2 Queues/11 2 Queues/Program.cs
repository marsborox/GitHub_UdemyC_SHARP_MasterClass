namespace _11_2_Queues
{
    internal class Program
    {
        class Order
        {
            public int OrderId { get; set; }
            public int OrderQuantity { get; set; }
            public Order(int id, int orderQuantity)
            {
                this.OrderId = id;
                this.OrderQuantity = orderQuantity;
            }
            public void ProcessOrder()
            {
                Console.WriteLine($"Order {OrderId} processed!");
            }
        }
        static void Main(string[] args)
        {
            Queue<Order> ordersQueue = new Queue<Order>();
            foreach (Order o in ReceiveOrdersFromBranch1())
            {
                //add each order to the queue
                ordersQueue.Enqueue(o);
            }
            foreach (Order o in ReceiveOrdersFromBranch2())
            {
                //add each order to the queue
                ordersQueue.Enqueue(o);
            }
            while (ordersQueue.Count > 0)
            {
                //remove the order At the front of the queue
                //and store it in a variable called currentOrder
                Order currentOrder = ordersQueue.Dequeue();
                //process the order
                currentOrder.ProcessOrder();

            }


        }
        static Order[] ReceiveOrdersFromBranch1()
        {
            Order[] orders = new Order[]
            //creating new orders array
                {new Order (1,5),
                new Order (2,4),
                new Order (6,10)
                };
            return orders;
        }
        static Order[] ReceiveOrdersFromBranch2()
        {
            //creating new orders array and initializing it with some objects of type Order
            Order[] orders = new Order[]
                {new Order (3,5),
                new Order (4,4),
                new Order (5,10)
                };
            //return the array of orders that we created
            return orders;
        }
    }
    class Order
    {
        //Order ID
    public int OrderId { get; set; }
        //quantity of the Order
    public int OrderQuantity { get; set; }
        //simple constructor
        public Order(int id, int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;
        }
        public void ProcessOrder()
        {
            Console.WriteLine($"Order {OrderId} processed!");
        }
    }
}
