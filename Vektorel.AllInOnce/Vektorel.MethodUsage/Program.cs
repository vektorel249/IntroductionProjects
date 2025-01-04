using System.ComponentModel.DataAnnotations;

namespace Vektorel.MethodUsage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Static - NonStatic
            StaticNonStaticComparison.WriteToStatic(5);
            //instance
            var lo = new StaticNonStaticComparison();
            StaticNonStaticComparison.WriteToStatic(12);
            lo.Write(45);
            var le = new StaticNonStaticComparison();
            StaticNonStaticComparison.WriteToStatic(18);
            le.Write(67);
            lo.Write(4);
            le.Write(7);
            #endregion

            while (true)
            {
                var luckyNumbers = Lottery649.RollAndGiveNumbers();
                for (int i = 0; i < luckyNumbers.Length; i++)
                {
                    Console.Write("{0} ", luckyNumbers[i]);
                }
                Console.WriteLine();
                Console.ReadLine();
            }

            // ---

            while (true)
            {
                Console.Write("{0} ", LotteryForOneNumber.RollAndGiveNumber());
                Console.Write("{0} ", LotteryForOneNumber.RollAndGiveNumber());
                Console.Write("{0} ", LotteryForOneNumber.RollAndGiveNumber());
                Console.Write("{0} ", LotteryForOneNumber.RollAndGiveNumber());
                Console.Write("{0} ", LotteryForOneNumber.RollAndGiveNumber());
                Console.Write("{0} ", LotteryForOneNumber.RollAndGiveNumber());
                Console.WriteLine();
                Console.ReadLine();
                LotteryForOneNumber.Reset();
            }
        }
    }
}
