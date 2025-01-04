using System.ComponentModel.DataAnnotations;

namespace Vektorel.ConditionsAndLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StarTriangle();
            Console.ReadKey();

            BasicOperators();
            Console.ReadKey();

            Loops2();
            Console.ReadKey();

            ForceToAccept();
            Console.ReadKey();

            Loops();
            Console.ReadKey();

            ApplicationForm();
            Console.ReadKey();

            var vehicleName1 = "Mercedes";
            var horsePower1 = 175;
            var maxSpeed1 = 260;
            var isDiesel1 = false;
            var type1 = VehicleType.Sedan;

            var vehicleName2 = "BMW";
            var horsePower2 = 170;
            var maxSpeed2 = 280;
            var isDiesel2 = false;
            var type2 = VehicleType.HatchBack;

            #region IF

            if (horsePower1 == horsePower2)
            {
                Console.WriteLine("Mercedes ve BMW güç bakımından denk");
            }
            if (horsePower1 < horsePower2)
            {
                Console.WriteLine("BMW daha güçlü");
            }
            if (horsePower1 > horsePower2)
            {
                Console.WriteLine("Mercedes daha güçlü");
            }

            //Hız karşılaştırması
            if (maxSpeed1 > maxSpeed2)
            {
                Console.WriteLine("Mercedes daha hızlı");
            }
            if (maxSpeed1 == maxSpeed2)
            {
                Console.WriteLine("Mercedes ve BMW hız bakımından denk");
            }
            if (maxSpeed1 < maxSpeed2)
            {
                Console.WriteLine("BMW daha hızlı");
            }
            #endregion

            #region IF-ELSEIF-ELSE
            //Güç Karşılaştırması
            if (horsePower1 > 150 && horsePower2 > 150)
            {
                Console.WriteLine("Arabalar canavar");
            }
            if (horsePower1 > horsePower2)
            {
                Console.WriteLine("Mercedes daha güçlü");
            }
            else if (horsePower1 == horsePower2)
            {
                Console.WriteLine("Mercedes ve BMW güç bakımından denk");
            }
            else
            {
                Console.WriteLine("BMW daha güçlü");
            }

            //Hız karşılaştırması
            if (maxSpeed1 > maxSpeed2)
            {
                Console.WriteLine("Mercedes daha hızlı");
            }
            else if (maxSpeed1 == maxSpeed2)
            {
                Console.WriteLine("Mercedes ve BMW hız bakımından denk");
            }
            else
            {
                Console.WriteLine("BMW daha hızlı");
            }
            #endregion

            #region BOOLEANS
            if (isDiesel1)
            {
                Console.WriteLine("Mercedes dizel yakıt kullanıyor");
            }
            else
            {
                Console.WriteLine("Mercedes benzin yakıt kullanıyor");
            }

            if (maxSpeed2 > 300)
            {

            }

            if (type1 == VehicleType.HatchBack)
            {

            }

            #endregion

            #region Kurban Kod
            ////Güç Karşılaştırması
            //if (horsePower1 > 150 && horsePower2 > 150)
            //{
            //    Console.WriteLine("Arabalar canavar");
            //}
            //if (horsePower1 > horsePower2)
            //{
            //    Console.WriteLine("Mercedes daha güçlü");
            //}
            //else if (horsePower1 == horsePower2)
            //{
            //    Console.WriteLine("Mercedes ve BMW güç bakımından denk");
            //}
            //else
            //{
            //    Console.WriteLine("BMW daha güçlü");
            //}

            ////Hız karşılaştırması
            //if (maxSpeed1 > maxSpeed2)
            //{
            //    Console.WriteLine("Mercedes daha hızlı");
            //}
            //else if (maxSpeed1 == maxSpeed2)
            //{
            //    Console.WriteLine("Mercedes ve BMW hız bakımından denk");
            //}
            //else
            //{
            //    Console.WriteLine("BMW daha hızlı");
            //} 
            #endregion

        }

        static void ApplicationForm()
        {
            // Kişinin adını ve doğum yılını istedikten sonra cinsiyetini de tek harf E veya K diye isteyelim
            // Kişi 18'den büyükse medeni halini soralım ve E ve B şeklinde cevap bekleyelim
            // Kişi Erkek ise Askerlik durumunu Evet Hayır Muaf şeklinde tek harf isteyelim

            //Çıktı: 
            /*
                Can Bey, henüz 17 yaşında
                Can Bey, 24 yaşında ve bekar. Askerliğini yapmadı
                Canan Hanım, 22 yaşında ve evli
                Canan Hanım, henüz 15 yaşında
                Can Bey, 30 yaşında ve evli. Askerliğini yaptı
             */

            Console.Write("Adınız......................: ");
            var name = Console.ReadLine();
            var output = name + " ";
            Console.Write("Doğum Yılınız...............: ");
            var year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cinsiyetiniz................: ");
            var gender = Convert.ToChar(Console.ReadLine());
            if (gender == 'E')
            {
                output = output + "Bey, ";
            }
            else if (gender == 'K')
            {
                output = output + "Hanım, ";
            }
            var age = DateTime.Now.Year - year;
            if (age >= 18)
            {
                output = output + age + " yaşında ";
                Console.Write("Medeni Durumunuz....E-B.....: ");
                var status = Convert.ToChar(Console.ReadLine());

                if (status == 'E')
                {
                    output = output + "ve evli. ";
                }
                else if (status == 'B')
                {
                    output = output + "ve bekar. ";
                }
            }
            else
            {
                output = output + " henüz " + age + " yaşında.";
            }

            if (gender == 'E' && age >= 21)
            {
                Console.Write("Askerlik Durumunuz..E-H-M...: ");
                var milStatus = Convert.ToChar(Console.ReadLine());
                if (milStatus == 'E')
                {
                    output = output + "Askerliğini yaptı.";
                }
                else if (milStatus == 'H')
                {
                    output = output + "Askerliğini yapmadı.";
                }
                else if (milStatus == 'M')
                {
                    output = output + "Askerlikten muaf.";
                }
                else
                {
                    output = output + "Askerlik bilgisi bilinmiyor.";
                }
            }
            Console.WriteLine(output);
        }

        static void Loops()
        {
            var canContinue = true;
            int capacity = 5;
            Console.Title = "Kalan Kapasite : " + capacity;
            #region SEÇENEK 1
            while (canContinue)
            {
                Console.Write("Adınızı ve Yaşınızı Giriniz.....: ");
                Console.ReadLine();
                capacity = capacity - 1;
                Console.Title = "Kalan Kapasite : " + capacity;
                if (capacity == 0)
                {
                    break; // Döngüden çık
                }
            }

            #region MyRegion
            while (canContinue && capacity > 0)
            {
                Console.Write("Adınızı ve Yaşınızı Giriniz.....: ");
                Console.ReadLine();
                capacity = capacity - 1;
                Console.Title = "Kalan Kapasite : " + capacity;
            }
            #endregion
            #endregion
            Console.Title = "Kapasite doldu. İlginiz için teşekkürler";
            Console.WriteLine("Konferans Başladı!");
        }

        static void ForceToAccept()
        {
            Console.ForegroundColor = ConsoleColor.White;
            var value = 0;
            var canContinue = true;
            while (canContinue)
            {
                Console.Write("Ne kadar zam istiyorsunuz? (0-100)....: ");
                var input = Console.ReadLine();
                var accepted = int.TryParse(input, out value);

                if (!accepted)
                {
                    Console.ForegroundColor = ConsoleColor.Red; 
                    Console.WriteLine("Lütfen ciddi olalım");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue; // Döngü değişkenine sormaya git
                }
                if (value > 0 && value <= 100)
                {
                    canContinue = false;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tebrikler! Maaşınıza ek " + value + " TL zam aldınız.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Loops2()
        {
            var sum = 0;
            //for (var index = 0; index < 5; index++) => Bkz. Aşağıda örnek var
            for (var index = 0; index < 5; index = index + 1)
            {
                Console.Write("Sayı Giriniz....: ");
                var number = Convert.ToInt32(Console.ReadLine());
                sum = sum + number; 
            }

            Console.WriteLine("Sayıların Toplamı....: " + sum);
        }

        static void BasicOperators()
        {
            var toplam = 4;
            var sayi1 = 12;

            toplam = toplam + sayi1;
            toplam += sayi1;

            toplam = toplam - sayi1;
            toplam -= sayi1;

            toplam = toplam + 1;
            toplam += 1;
            toplam++;
            ++toplam;

            toplam = toplam - 1;
            toplam -= 1;
            toplam--;
            --toplam;

            var n1 = 3;
            var n2 = 5;
            

            if (++n1 == --n2)
            {
                Console.WriteLine("Sayılar Eşit");
            }

            Console.WriteLine(n1);
            Console.WriteLine(++n1);
            Console.WriteLine(n1++);
        }

        static void StarTriangle()
        {
            /*
             
             *
             **
             ***
             ****
             *****
             ******
             *******
             ********
             *********
             **********
             
             */
            for (var row = 1; row <= 10; row++)
            {
                for (var column = 0; column < row; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (var row = 9; row >= 0; row--)
            {
                for (var column = 0; column < row; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }

    enum VehicleType
    {
        Sedan,
        HatchBack,
        Coupe
    }
}
