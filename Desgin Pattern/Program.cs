using FactoryMethod;

namespace Desgin_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Creational Patterns

            #region Factory Method Pattern

            var circle = ShapeFactory.CreateShape(ShapeType.Circle);
            var square = ShapeFactory.CreateShape(ShapeType.Square);

            #endregion

            #endregion

            Console.ReadKey();
        }
    }
}
