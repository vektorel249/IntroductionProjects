namespace Vektorel.Introduction
{
    internal class Course
    {
        public static void Welcome()
        {
            Console.WriteLine();
            Console.WriteLine("Bugün ilk dersimizi yaptık");
            Console.WriteLine("İlk başta tanıştık");
            Console.WriteLine("Sonra sohbet ettik");
            Console.WriteLine("Teknolojik ilerlemeler ve C# ve .Net'in pozisyonunu tartıştık");
        }

        public static void Salute()
        {
            Console.WriteLine("Hadi görüşürüz");
        }

        public static void AddSeparator()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}