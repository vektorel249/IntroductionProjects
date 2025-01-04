namespace Vektorel.GenericLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var odds = new int[] { 3, 7, 11, 93, 31, 13, 1 };

            var names = new string[] { "Can", "Mücahit", "Arda", "Gürkan" };

            var fruits = new string[4];
            fruits[0] = "Elma";
            fruits[1] = "Armut";
            fruits[2] = "Kiraz";
            fruits[3] = "Erik";

            //<T> T => Type => herhangi bir tip
            var evens = new List<int>() { 2, 4, 10, 20, 16, 8 };
            
            var cities = new List<string>() { "Ankara", "İstanbul", "İzmir", "Kars" };

            var vegetables = new List<string>();
            vegetables.Add("Patlıcan");
            vegetables.Add("Karnıbahar");
            vegetables.Add("Kabak");
            vegetables.Add("Ispanak");
            vegetables.Add("Lahana");

            vegetables.Remove("Ispanak");

            #region Açıklamalar
            //Array.Resize(ref fruits, 4); Belirlenen dizinin boyutunu değiştirir
            //Array.Clear(fruits); Dizinin değerlerini varsayılan değere çeker (0, null, vb)
            //Array.Copy(names, fruits, 4); // Bir diziyi diğerine kopyalar
            //Bkz. Array classı (F12) 
            #endregion


        }
    }
}
