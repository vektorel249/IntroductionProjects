using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.ClassDefinitions
{
    static class SimpleMath
    {

        #region 2. Aşama
        public static void SumAndPrintV2()
        {
            SumWithOutput(3, 5, "Toplam : ");
        }

        public static void SumAndPrintV2(int number1, int number2)
        {
            SumWithOutput(number1, number2, "Toplam : ");
        }

        //---------------------------------------------------------------------

        #endregion
        public static void SumAndPrint()
        {
            //var number1 = 3;
            //var number2 = 5;
            //var sum = number1 + number2;
            var sum = 3 + 5;
            Console.WriteLine("Toplam: {0}", sum);
        }

        public static void SumAndPrint(int number1, int number2)
        {
            var sum = number1 + number2;
            Console.WriteLine("Toplam: {0}", sum);
        }

        public static void SumAndPrint(double number1, double number2)
        {
            var sum = number1 + number2;
            Console.WriteLine("Toplam: {0}", sum);
        }

        public static void SumAndPrint(int number1, int number2, int number3)
        {
            var sum = number1 + number2 + number3;
            Console.WriteLine("Toplam: {0}", sum);
        }

        public static int JustSum(int a, int b)
        {
            // Varsayalım ki sayıların toplamı çok maliyetli ve uzun kodlarla yapılıyor
            //return a + b;
            var sum = a + b;
            return sum;
        }

        public static void SumWithOutput(int number1, int number2, string prefix)
        {
            int s = JustSum(number1, number2);
            Console.WriteLine(prefix + s);
        }

        public static void Sum5NumbersAndPrint(int number1, int number2, int number3, int number4, int number5)
        {
            var sum = JustSum(number1, number2);
            sum = JustSum(number3, sum);
            sum = JustSum(number4, sum);
            sum = JustSum(number5, sum);

            Console.WriteLine("Toplam: {0}", sum);
        }
    }
}

/*
 SOLID Principles
 */
