//using Vektorel.SimpleMath.Complex;
//using Vektorel.SimpleMath.Simple;
namespace Vektorel.SimpleMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number1 = 123;
            var number2 = 456;

            var sum = number1 + number2;
            Console.WriteLine("Toplam: " + sum);

            Complex.Circle.GetRadius();
            Simple.Circle.GetRadius();
        }
    }
}