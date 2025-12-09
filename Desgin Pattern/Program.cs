using AbstracFactory;
using BuilderPattern;
using FactoryMethod;
using ProtoType;
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

            #endregion

            Console.ReadKey();
        }
    }
}
