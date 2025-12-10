using AbstracFactory;
using AdapterPattern;
using BuilderPattern;
using DecoratePattern;
using FactoryMethod;
using ProtoType;
using SingletonPattern;
using System.Diagnostics.Contracts;
namespace Desgin_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Creational Patterns

            Console.WriteLine("                     Factory Method Pattern            ");
            Console.WriteLine();

            #region Factory Method Pattern

            var circle = ShapeFactory.CreateShape(ShapeType.Circle);
            var square = ShapeFactory.CreateShape(ShapeType.Square);

            #endregion

            #region Abstract Factory Pattern

            CarFactory northAmericaFactory = new NorthAmericanCarFactory();
            var northAmericaCar = northAmericaFactory.CreateCar();
            var northAmericaSpec = northAmericaFactory.CreateCarSpecification();
            

            CarFactory europeFactory = new EuropeanCarFactory();
            var europeCar = europeFactory.CreateCar();
            var europeSpec = europeFactory.CreateCarSpecification();

            //Console.WriteLine(northAmericaCar);
            //Console.WriteLine(northAmericaSpec);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("                    Abstract Factory Pattern            ");
            Console.WriteLine();

            northAmericaCar.assemble();
            northAmericaSpec.display();
            Console.WriteLine("-----------------------------------");
            europeCar.assemble();
            europeSpec.display();
            #endregion

            #region Builder Pattern

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("                     Builder Pattern            ");
            Console.WriteLine();

            GamingComputerBuilder gamingComputerBuilder = new GamingComputerBuilder();
            Director director = new Director();
            director.Construct(gamingComputerBuilder);

            var gamingComputer = gamingComputerBuilder.GetComputer();

            gamingComputer.DisplayConfiguration();
            #endregion

            #region Prototype Pattern

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("                     Builder Pattern            ");
            Console.WriteLine();

            var textproto = new TextDocument("Text");

            var textclone = new TextClient(textproto).TextDocumentClone;
            
            Console.WriteLine($"Original Document Type: {textproto.Display()}");
            Console.WriteLine($"Cloned Document Type: {textclone.Display()}");

            #endregion

            #region Singleton Pattern

            // one check not thread safe
            var logBtOneCheck = Singleton.GetInstanceOneCheck();

            // two check thread safe
            var logBtTwoCheck = Singleton.GetInstanceTwoCheck();

            // lazy thread safe
            var logBtLazy = Singleton.GetInstanceByLazy();

            #endregion

            #endregion

            #region Structural Patterns


            #region Adapter Pattern

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("                     Adapter Pattern            ");
            Console.WriteLine();

            Adaptee adaptee = new Adaptee();

            var adapter = new Adapter(adaptee);

            adapter.Request();

            #endregion

            #region Decorator Pattern

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("                     Decorator Pattern            ");
            Console.WriteLine();
            var coffee = new SimpleCoffee();

            Console.WriteLine($"{coffee.GetDescription()} Cost: {coffee.GetCost()}");

            var milk = new MilkCoffee(coffee);
            Console.WriteLine($"{milk.GetDescription()} Cost: {milk.GetCost()}");

            var chocolate = new ChocolateCoffee(milk);
            Console.WriteLine($"{chocolate.GetDescription()} Cost: {chocolate.GetCost()}");

            #endregion

            #region 

            #endregion

            #endregion

            Console.ReadKey();
        }
    }
}
