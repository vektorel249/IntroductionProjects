namespace Vektorel.MethodUsage
{
    class Lottery649
    {
        public static int[] RollAndGiveNumbers()
        {
            var numbers = new int[6];
            var currentIndex = 0;
            while (true)
            {
                var chosen = Random.Shared.Next(1, 10);
                for(var i = 0; i <= currentIndex; i++)
                {
                    if (chosen == numbers[i])
                    {
                        break;
                    }

                    if (i == currentIndex)
                    {
                        numbers[i] = chosen;
                        currentIndex++;
                        break;
                    }
                }
                if (currentIndex == numbers.Length)
                {
                    break;
                }
            }

            return numbers;
        }
    }
}
