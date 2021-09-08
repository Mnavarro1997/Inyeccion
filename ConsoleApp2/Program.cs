using DependencyInyection;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Enter your product");
            var product = string.Empty;
            var orderManager = new OrderManagerService();
            while (product != "exit")
            {
                Console.WriteLine(@"Enter your product
            Keyboard = 0,
            Mouse = 1,
            Mic = 2,
            Speaker = 3
                            ");
                product = Console.ReadLine();
                try
                {
                    if (Enum.TryParse(product, out Product productEnum))
                    {
                        Console.WriteLine("Please enter a valid payment method: XXXXXXXXXXXXXXXX;MMYY");
                        var paymentMethod = Console.ReadLine();
                        if (string.IsNullOrEmpty(paymentMethod) || paymentMethod.Split(";").Length != 2)
                            throw new Exception("Invalid payment method");
                        //producto que le hemos pasado, el numero de tarjeta y la fecha de la tarjeta.
                        orderManager.Submit(productEnum, paymentMethod.Split(";")[0], paymentMethod.Split(";")[1]);
                        Console.WriteLine($"{productEnum.ToString()} has been shipped");
                    }
                    else
                    {
                        Console.WriteLine("Invalid product");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine(Environment.NewLine);
            }
        }

    }
}
