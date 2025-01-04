namespace Vektorel.MethodUsage
{
    class LotteryForOneNumber
    {
        private static int[] numbers = new int[6];
        private static int currentIndex = 0;
        public static void Reset()
        {
            currentIndex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 0;
            }
        }

        /// <summary>
        /// Bu method bize daha önce kullanılmamış bir adet sayı bulur
        /// </summary>
        /// <returns>denemeler sonucu ortaya çıkan benzersiz değer</returns>
        public static int RollAndGiveNumber()
        {
            //Bu yöntemi de kullanabiliriz ama neden bu şekilde kullanmamalıyız?
            //var random = new Random();
            //return random.Next(1, 50);

            if (currentIndex >= numbers.Length)
            {
                return 0;
            }
            var canContinue = true;
            var chosen = 0;
            while (canContinue)
            {
                chosen = Random.Shared.Next(1, 50);
                for (var i = 0; i <= currentIndex; i++)
                {
                    if (chosen == numbers[i])
                    {
                        break;
                    }
                    if (i == currentIndex)
                    {
                        numbers[i] = chosen; // İşlem tamam sayı bulundu
                        canContinue = false; // Bkz: while döngü değişkeni.
                        currentIndex++;
                        break;
                    }
                }
            }
            return chosen;
        }
    }
}
