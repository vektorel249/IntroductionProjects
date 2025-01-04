namespace Vektorel.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    numbers.Add(number);
                }
                else 
                { 
                    break; 
                }
            }

            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            Console.WriteLine("Sayıların Toplamı : " + sum);
        }

        private static void SumAllNumbers()
        {
            //İstenilen kadar sayıyı toplayan uygulama

            Console.Write("Kaç sayı toplamak istersiniz ? ");
            var count = int.Parse(Console.ReadLine());
            var numbers = new int[count];
            var sum = 0;
            for (int i = 0; i < count; i++)
            {
                Console.Write("{0}. sayıyı giriniz...: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
                if (i == numbers.Length - 1)
                {
                    Console.Write(" = ");
                }
                else
                {
                    Console.Write(" + ");
                }

                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }

        private static void SumEvenNumbers()
        {
            //İstenilen kadar sayıyı toplayan uygulama

            Console.Write("Kaç sayı toplamak istersiniz ? ");
            var count = int.Parse(Console.ReadLine());
            var numbers = new int[count];
            var sum = 0;
            for (int i = 0; i < count; i++)
            {
                Console.Write("{0}. sayıyı giriniz...: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            var evenNumberPrinted = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (evenNumberPrinted)
                    {
                        Console.Write(" + ");
                    }
                    Console.Write(numbers[i]);
                    evenNumberPrinted = true;
                    sum += numbers[i];
                }
            }
            if (sum == 0)
            {
                Console.Write("Çift sayı bulunamadı");
                return;
            }
            Console.Write(" = ");
            Console.WriteLine(sum);
        }

        private static void FetchMaturePeople()
        {
            var people = new Person[5];

            for (int i = 0; i < people.Length; i++)
            {
                Console.Write("Adı...............: ");
                var name = Console.ReadLine();

                Console.Write("Doğum Tarihi......: ");
                var age = int.Parse(Console.ReadLine());

                people[i] = new Person(name, age);
            }

            var currentYear = DateTime.Now.Year;
            foreach (var person in people)
            {
                var age = currentYear - person.birthYear;
                if (age >= 18)
                {
                    Console.WriteLine("Adı: {0}\tYaşı: {1}", person.name, age);
                }
            }
        }

        private static void AddDiscountToMaxTotalCustomer()
        {
            var customers = new Basket[10];
            customers[0] = new Basket("Can Perk", 254.56);
            customers[1] = new Basket("Arda Güler", 345.98);
            customers[2] = new Basket("Cenk Tosun", 109.54);
            customers[3] = new Basket("Barış Alper Yılmaz", 119.4);
            customers[4] = new Basket("Kenan Yıldız", 398.77);
            customers[5] = new Basket("Kerem Aktürkoğlu", 403.65);
            customers[6] = new Basket("Orkun Kökçü", 219.03);
            customers[7] = new Basket("Adbulkerim Bardakçı", 203.65);
            customers[8] = new Basket("Yunus Akgün", 299.98);
            customers[9] = new Basket("Mert Günok", 187.32);

            // En çok alışveriş yapan müşteriye % 10 indirimi sağlamak
            Basket discountCustomer = customers[0];
            foreach (var customer in customers)
            {
                if (discountCustomer.total < customer.total)
                {
                    discountCustomer = customer;
                }
                // sola dayalı -20 karakterden yazmaya başla
                Console.WriteLine("{0,-20}{1}", customer.person, customer.total);
            }

            Console.WriteLine();

            // indirimi hesapla ve 2 basamağa yuvarla
            var discount = Math.Round(discountCustomer.total * 0.9, 2);
            Console.WriteLine("En yüksek alışveriş yapan müşterimiz {0}, {1} TL tutar sonucunda %10 indirimle {2} TL ödeme yapacaktır", discountCustomer.person, discountCustomer.total, discount);
        }
    }

    record Person(string name, int birthYear);

    record Basket(string person, double total);
}


