namespace Vektorel.Welcome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunStep5();
        }

        static void RunStep1()
        {
            //Satıra yaz ve al satıra geç
            Console.WriteLine("Kodlama Egzersizi");
            //Satıra yaz ve bekle
            Console.Write("Can");
            Console.Write("Perk");
            Console.WriteLine();
            Console.Write("Başka Metin");
            Console.Write("Aşağı İnmeli\n");
            Console.Write("Neden aynı satırdayız");
            //-----------------------------------------------------
            Console.ReadKey(); // Bir tuşa basana kadar bekle
            Console.Clear();

            Console.Write("Adı........: ");
            Console.Write("Can");
            Console.WriteLine();
            Console.Write("Soyadı.....: ");
            Console.Write("Perk");
            Console.WriteLine();
            Console.Write("Şehir......: ");
            Console.Write("Ankara");
            Console.WriteLine();

            Console.ReadKey();
        }

        static void RunStep2()
        {
            Console.Write("Adınız........: ");
            string firstName = Console.ReadLine(); // Enter'a basana kadar ekranı beklet
            Console.Write("Soyadınız.....: ");
            string lastName = Console.ReadLine(); // Enter'a basana kadar ekranı beklet
            Console.Write("Yaşınız.......: ");
            string age = Console.ReadLine(); // Enter'a basana kadar ekranı beklet
            Console.Write("Şehriniz......: ");
            string city = Console.ReadLine(); // Enter'a basana kadar ekranı beklet

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=======================================");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Merhaba " + firstName + " " + lastName + ", şu anda " + age + " yaşındasınız ve " + city + " şehrinde ikamet ediyorsunuz...");
        }

        static void RunStep3()
        {
            /*
             C# dili;
                - Type safe bir dildir
                - Nullable özelliği olan bir dildir
                - Case Sensitive bir dildir
             */

            //Aşağıdaki adresi null değerine değiştirip tekrar deneyin
            string address = "GMK Bulvarı No: 232 Çankaya";

            Console.WriteLine(address.ToUpper());

            string name = "Can";
            string surname = "Perk";
            double weight = 82.34;

            byte age = 36;
            short length = 12327;
            int population = 86446534;

            float value1 = 2345.6568754566745665453227F;
            double value2 = 2345.6568754566745665453227D;
            decimal value3 = 2345.6568754566745665453227M;

            bool isOpen = true;

            //"true"
            string a = true.ToString();

            Console.WriteLine("Float : " + value1);
            Console.WriteLine("Double : " + value2);
            Console.WriteLine("Decimal : " + value3);

            //Aşağıdaki değerleri f, d, m karşılığı olarak deneyin
            double sum1 = 0.1d + 0.2d;
            Console.WriteLine("Sıfır Üç: " + sum1);

            var result = 10.0F / 3.0F;
            Console.WriteLine("Bölüm: " + result);

            int nextAge = age + 1;
            double expectedWeight = weight - 1.5;

            Console.WriteLine(name + " " + surname);
            Console.WriteLine(nextAge);
            Console.WriteLine(expectedWeight);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*************** CONVERT **************************");
            Console.ForegroundColor = ConsoleColor.White;
            //--------------------------------------------------
            //*************** CONVERT **************************

            var floatingNumber = 43.57;
            var number1 = (int)floatingNumber;
            var weightByString = "56,98";
            var plusValue = "8,24";
            var newWeight = double.Parse(weightByString) + double.Parse(plusValue);

            Console.WriteLine(floatingNumber);
            Console.WriteLine(number1);
            Console.WriteLine(newWeight);

            /*
             * Sorgu: "ankara"
             * - ANKARA
             * - Ankara
             * - ankara
             * - ANKara
            */
            var city1 = "ANKARA";
            var CITY1 = "Ankara";

            char oneCharacterLength = 'E';
            string oneCharacterLength2 = "E";

            bool isEqual = (city1 == CITY1);

            Console.WriteLine("Değer Eşitliği: " + isEqual);
        }

        static void RunStep4()
        {
            Console.Write("Bir Sayı Giriniz...: ");
            string inputValue1 = Console.ReadLine(); // 17
            int number1 = int.Parse(inputValue1); 

            Console.Write("Bir Sayı Giriniz...: ");
            int number2 = int.Parse(Console.ReadLine()); // 13

            int sum = number1 + number2;

            Console.WriteLine("İki Sayı Toplamı...: " + sum);
        }

        static void RunStep5()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Bir Sayı Giriniz...: ");
            var inputValue1 = Console.ReadLine();
            Console.Write("Bir Sayı Giriniz...: ");
            var inputValue2 = Console.ReadLine();

            // değeri int'e çevirmeye çalış, çevirebilirsen true de ve number1' de sayıyı at,
            // çeviremezsen false de ve number1'e karışma
            bool isInputValue1Valid = int.TryParse(inputValue1, out var number1);
            if (isInputValue1Valid == false) // true olursa scope'a gir
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(inputValue1 + " değeri sayı olmadığından uygulama kapatılıyor!");
                return;
            }
            bool isInputValue2Valid = int.TryParse(inputValue2, out var number2);
            if (isInputValue2Valid == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(inputValue2 + " değeri sayı olmadığından uygulama kapatılıyor!");
                return;
            }

            int sum = number1 + number2;

            Console.WriteLine("İki Sayı Toplamı...: " + sum);
        }
    }
}