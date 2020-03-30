using System;

namespace TheCoffeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Farabi Coffe Shop!");

            CoffePowder coffe = new CoffePowder(100);
            WaterGalon water = new WaterGalon(1000);
            Milk milk = new Milk(500);
            CoffeMachine yummyCoffe = new CoffeMachine(coffe, water, milk);

            //1st cup coffe
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            String result = yummyCoffe.makeEsspreso();
            Console.WriteLine("result " + result);

            //2nd cup coffe
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspreso();
            Console.WriteLine("result " + result);

            //3th cup coffe 
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeCappucino();
            Console.WriteLine("result " + result);

            //4th cup coffe
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeCappucino();
            Console.WriteLine("result " + result);

            //5th cup coffe 
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspreso();
            Console.WriteLine("result " + result);

            //6th cup coffe 
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspreso();
            Console.WriteLine("result " + result);
        }
    }
}
