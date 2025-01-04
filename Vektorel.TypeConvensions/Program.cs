namespace Vektorel.TypeConvensions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console
            //Write, WriteLibe, ReadKey, ReadLine
            //Veri tipleri
            //  -> char, string, bool, byte, short, int, long, float, double, decimal
            //  -> sbyte, ushort, uint, ulong

            // Boxing, Unboxing, Converting
            // int a = (int)5.6;


            /*
			 .NET içinde kullanılan TİPLER
			 => class
			 => struct
			 => enum
			 => event
			 => delegate
			 */

            /*
			 İSİMLENDİRME STANDARTLARI - NAMING CONVENSIONS

			 PascalCase : Genelde class ve metodlar gibi tiplerde kullanılır. Her kelime başlangıcı büyük harf, diğerleri küçük harf
			   => DateTime, Customer, CalculateField, MakeCurrentUserAsAuthorizedPerson
			 CamelCase: Genelde değişkenlerde kullanılır. ilk harf küçük, kalanı Pascal case gibi davranır
			   => currencyRate, dailyUsageInformation
			 SnakeCase: Genelde constant (sabitlerde kullanılır) Kelime ayraçları _'dir
			   => CONNECTION_INFORMATION, birth_date, horse_power_ratio
			 KebabCase: C# desteklemiyor. - ile kelime ayrımı yapar. css işaretleme standarı bu standardı kabul eder.
			   => user-type, horse-power-ratio
			 */

            ConditionsStep1();
            Console.WriteLine("Koşul bitti. Dikdörtgen hesabı için bir tuşa basınız.");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            CurrencyCalculator();
            Console.WriteLine("Kur hesabı bitti. Kur hesabı için bir tuşa basınız.");
            Console.ReadKey();
            Console.Clear();

            CalculateField();
            Console.WriteLine("Hesaplama işlemi bitti. Yaş hesabı için bir tuşa basınız.");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Adınız.............: ");
            var firstName = Console.ReadLine();
            Console.Write("Doğum Tarihiniz....: ");
            var birthDateString = Console.ReadLine();

            var birthDate = Convert.ToDateTime(birthDateString);
            PrintAgeInformation(birthDate);

            var c = "Male";
            var g = Gender.Male;

            Console.ReadKey();
        }

        static void ConditionsStep1()
        {
            var name = "Canan";
            var password = "123";
            var age = 23;
            var gender = Gender.Male;
            if (password == "123")
            {
                if (age > 18)
                {
                    if (gender == Gender.Male)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Merhaba" + name + " Bey, bir yetişkin olarak aramızdasın.");
                    }
                    else if (gender == Gender.Female)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Merhaba " + name + " Hanım, bir yetişkin olarak aramızdasın.");
                    }
                }
                else
                {
                    if (gender == Gender.Male)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if (gender == Gender.Female)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    Console.WriteLine("Genç arkadaşımız " + name + " aramızda.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("YETKİSİZ GİRİŞ");
            }
        }

        static void PrintAgeInformation(DateTime dateInformation)
        {
            var difference = DateTime.Now - dateInformation;
            Console.WriteLine("Doğduğunuz gün...........: " + dateInformation.DayOfWeek);
            Console.WriteLine("Toplam Yaşadığınız Gün...: " + Math.Round(difference.TotalDays, 2));
            Console.WriteLine("Tam Yaşınız..............: " + (int)(difference.TotalDays / 365.0));
        }

        static void CalculateField()
        {
            //Ekrandan 2 kenar bilgisi alarak dikdörtgenin alanı ve çevresini hesaplayınız.
            Console.Write("1. Kenar Uzunluğu....: ");
            double edge1 = double.Parse(Console.ReadLine());
            Console.Write("2. Kenar Uzunluğu....: ");
            double edge2 = Convert.ToDouble(Console.ReadLine());

            var area = edge1 * edge2;
            var circumference = 2 * (edge1 + edge2);

            Console.WriteLine("Alan......: " + area);
            Console.WriteLine("Çevre.....: " + circumference);
        }

        static void CurrencyCalculator()
        {
            // İki farklı tarihin ilgili tarihteki döviz kurunu karşılayacak şekilde
            // girildiği senaryoda. Bakiye olarak belirtilen değeri iki tarih arasındaki
            // değişimi miktar ve yüzde bakımında ekranda yazınız

            /*
			 Referans Tarihi..: 20/11/2024
			 Referans Kuru....: 35.45
			 
			 Kontrol Tarihi...: 30/11/2024
			 Kontrol Kuru.....: 33.89

			 Bakiye...........: 1000

			 10 gün içindeki değişim
			 =============================
			 -1560 TL tutar ve -4.41 % oran hesap değişimi
			 */

            Console.Write("Referans Tarihi.......: ");
            DateTime refDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Referans Kuru.........: ");
            decimal refCurrency = decimal.Parse(Console.ReadLine());

            Console.Write("Kontrol Tarihi........: ");
            var checkDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Kontrol Kuru..........: ");
            var checkCurrency = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Döviz Bakiyesi........: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            var dateDifference = checkDate - refDate;
            var refAmount = amount * refCurrency;
            var checkAmount = amount * checkCurrency;
            var amountDifference = checkAmount - refAmount;
            //var amountDifference = (amount * refCurrency) - (amount * checkCurrency);

            // Yuvarlama
            var rate = Math.Round((checkCurrency - refCurrency) / refCurrency * 100, 2);

            Console.WriteLine("______________________________________");
            Console.WriteLine(dateDifference.Days + " gün içindeki değişim özeti");
            Console.WriteLine("______________________________________");

            Console.WriteLine(amountDifference + " TL bakiye değişimi oldu. Oransal değişim: %" + rate);
        }

        //static void CurrencyCalculatorRealWorld()
        //{
        //          var refDate = new DateTime(2023, 11, 9); // Kullanıcıdan iste
        //          var refCurrency = GetCurrencyFromBank(); // Merkez bankasında oku

        //	var checkDate = DateTime.Now;
        //          var checkCurrency = GetCurrencyFromBank(); // Merkez bankasında oku

        //	decimal amount = 1000; // Kullanıcı bakiyesi veritababnından oku
        //          var dateDifference = checkDate - refDate;
        //          var refAmount = amount * refCurrency;
        //          var checkAmount = amount * checkCurrency;
        //          var amountDifference = checkAmount - refAmount;
        //          //var amountDifference = (amount * refCurrency) - (amount * checkCurrency);

        //          // Yuvarlama
        //          var rate = Math.Round((checkCurrency - refCurrency) / refCurrency * 100, 2);

        //          Console.WriteLine("______________________________________");
        //          Console.WriteLine(dateDifference.Days + " gün içindeki değişim özeti");
        //          Console.WriteLine("______________________________________");

        //          Console.WriteLine(amountDifference + " TL bakiye değişimi oldu. Oransal değişim: %" + rate);
        //      }

        //static decimal GetCurrencyFromBank()
        //{
        //	return 33.45M;
        //}

    }

    enum Gender
    {
        Male,
        Female,
        NotSet
    }
}