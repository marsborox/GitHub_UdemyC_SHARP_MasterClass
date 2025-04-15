using System.Diagnostics;

namespace ConsoleApp1
{
    public interface IPaymentProcessor
    {//normally interface is in its own script / file
        void ProcessPayment(decimal ammount)
        {
            Console.WriteLine($"Processing ammount of unknown origin {ammount}");
        }
    }
    public class UnknownOrigin : IPaymentProcessor
    { // will use default}
    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal ammount)
        {//will override
            Console.WriteLine($"Processing credit card payment of ammount  { ammount}");
            //implement credit card logic
        }
    }
    public class PaypalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal ammount)
        {
            Console.WriteLine($"Processing Paypal payment of ammount  {ammount}");
            //implement credit card logic
        }
    }
    public class PaymentService
    { 
        private readonly IPaymentProcessor _processor;

        public PaymentService(IPaymentProcessor processor)
        { //during creation of my class pass me a processor
            _processor = processor;
        }
        public void ProcessOrderPayment(decimal amount)
        { 
            _processor.ProcessPayment(amount);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessor creditCardProcessor = new CreditCardProcessor();//pick creditCard
            PaymentService paymentService = new PaymentService(creditCardProcessor);
            paymentService.ProcessOrderPayment(100.00m);

            IPaymentProcessor paypalProcessor = new PaypalProcessor();//pick paypal
            paymentService = new PaymentService(paypalProcessor);
            paymentService.ProcessOrderPayment(200.00m);

            IPaymentProcessor unknownOrigin = new UnknownOrigin();
            paymentService = new PaymentService(unknownOrigin);
            paymentService.ProcessOrderPayment(500.00m);

            //we are basicallz passing InterfaceReference as input parameter to switch between interfaces
            //to the constructor
        }
    }
}
