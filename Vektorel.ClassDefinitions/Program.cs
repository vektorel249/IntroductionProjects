namespace Vektorel.ClassDefinitions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Console Cursor Game
            ConsoleGame.Run();
            #endregion
            #region MethodDefinitions
            SimpleMath.SumAndPrint();
            SimpleMath.SumAndPrint(12, 65);
            SimpleMath.SumAndPrint(12.5, 65.1);
            SimpleMath.SumAndPrint(21, 5, 6);

            var num1 = 4;
            var num2 = 14;
            var t = SimpleMath.JustSum(num1, num2);
            Console.WriteLine("{0} + {1} = {2}", num1, num2, t);

            SimpleMath.SumWithOutput(5, 7, "İki sayı toplamı:");

            SimpleMath.Sum5NumbersAndPrint(5, 7, 12, 87, 34);

            Console.ReadLine();
            #endregion
            #region String Format Denemeler
            var brand1 = "Mercedes";
            var model1 = "CLA200";
            var plate1 = "06AS123";

            var brand2 = "BMW";
            var model2 = "520";
            var plate2 = "06RF123";

            var brand3 = "Volvo";
            var model3 = "S90";
            var plate3 = "06YU123";

            

            Console.WriteLine("{2} plakalı ve {0} markalı ve {1} modeli olan aracın plakası {2}", brand1, model2, plate3);
            Console.WriteLine("{2} plakalı ve {0} markalı ve {1} modeli olan aracın plakası {2}", brand2, model3, plate1);
            Console.WriteLine("{2} plakalı ve {0} markalı ve {1} modeli olan aracın plakası {2}", brand3, model1, plate2);

            var output = plate1 + " plakalı ve " + brand1 + " markalı ve " + model1 + "modeli olan aracın plakası " + plate1;
            Console.WriteLine(output);
            Console.WriteLine("Ekranı temizlemek için bir tuşa bas");
            Console.ReadKey();
            Console.Clear();

            CarInformation.Print("Mercedes", "CLA200", "06AS123");
            CarInformation.Print("BMW", "520", "06RF123");
            CarInformation.Print("Volvo", "S90", "06YU123");
            #endregion

            //instance     => non-static
            //non-instance => static
        }
    }
}
