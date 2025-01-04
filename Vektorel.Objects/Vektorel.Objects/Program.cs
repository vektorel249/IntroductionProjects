namespace Vektorel.Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cp1 = new Can.Tipler.Person();
            var p1 = new Person();
            //cp1 = p1;
            var a1 = new Animal("Corç");
            var c1 = new Car();

            Person p2 = new Person();
            Person p3 = new();

            object p4 = new Person() { Name = "Caner" };
            object a2 = new Animal("Sergen");
            object c2 = new Car();

            var convertedP4 = p4 as SpeedCar;
            //Aşağıdaki if çalışmaz çünkü Person ile SpeedCard arasındqa bir bağ yok
            if (convertedP4 != null)
            {
                Console.WriteLine(convertedP4.MaxSpeed);
            }

            //Eğer p4'ün tipi Person ise onu p4v2 diye bir değişkene at. Uzun hali bkz aşağıda
            if (p4 is Person p4v2)
            {
                Console.WriteLine(p4v2.Name);
            }

            //Çalışmaz
            if (a2 is Person p4v3)
            {
                Console.WriteLine(p4v3.Name);
            }

            /*
             var isPerson = p4 is Person;
             if (isPerson)
             {
                 var p4v2 = p4 as Person;
                 Console.WriteLine(p4v2.Name);
             }
             */

            var sc = new SpeedCar
            {
                Brand = "BMW",
                Model = "520",
                MaxSpeed = 220,
                Year = 2024
            };

            sc.Year = 2025;

            p1.Name = "Can";
            p2.Name = "Can";
            p3.Name = "Cenk";

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);
            Console.WriteLine();
            Console.WriteLine(a1);

            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("P1 Ortak Özellikler");
            Console.WriteLine("GetType: " + p1.GetType());
            Console.WriteLine("GetHashCode: " + p1.GetHashCode());
            Console.WriteLine("ToString: " + p1.ToString());

            Console.WriteLine();
            Console.WriteLine("P2 Ortak Özellikler");
            Console.WriteLine("GetType: " + p2.GetType());
            Console.WriteLine("GetHashCode: " + p2.GetHashCode());
            Console.WriteLine("ToString: " + p2.ToString());

            Console.WriteLine(a1.ToString());
            Console.WriteLine(sc);
            Console.WriteLine(sc.ToString());
        }
    }

    class Person
    {
        public string Name;

        public override string ToString()
        {
            return Name;
        }
    }

    record Animal(string Name);

    struct Car
    {
        public string Name;
    }

    class SpeedCar
    {
        public string Brand;
        public string Model;
        public int Year;
        public int MaxSpeed;

        public override string ToString()
        {
            return Brand + " " + Model + " " + Year;
        }
    }
}


namespace Can.Tipler
{
    public class Person
    {
        public string Name;
    }
}