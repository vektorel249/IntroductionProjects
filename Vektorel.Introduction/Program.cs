namespace Vektorel.Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hoşgeldiniz");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Vektörel'deki ilk mesajımız");
            File.WriteAllText("D:\\VA249\\mesaj.txt", "Bu da ilk dosya mesajı");

            for (int i = 0; i < 53; i++)
            {
                Course.Welcome();
                Course.AddSeparator();
            }

            


            //KISS: Keep It Simple and Stupid
            //SOLID: 
            /*
             S: Single Responsibility Principle
             O: Open Close Principle
             L: LiskovS Substitution Principle
             I: Interface Segregation Principle
             D: Dependency Inversion Principle
             */


            /*
             DİKKAT EDİLECEK HUSUSLAR:
            ===========================
            Kullanılan yapının ne olduğuna dikkat edilmeli. Örnek: Tanımla, Class'lar, Fonksiyonlar vs.


            Solution => Project => namespace => class, struct => Alt bileşenler (Fonksiyon, Değişken ve diğerleri)

             */
        }
    }
}