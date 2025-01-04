namespace Vektorel.Initialisers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Country("Türkçe") { Name = "Türkiye" };
            c1.Continent = "Asia";
            c1.Population = 85;
            c1.Continent = "Europe";

            // init setter olduğu için sadece object init anında setlenebilir
            // c1.Name = "Turkey";

            // sadece constructor da setlenebilir sonrası mümkün değil
            //c1.Language = "Turkish";

            Console.WriteLine(c1.Population);
            Console.WriteLine(c1.Population);
            Console.WriteLine(c1.Population);
            Console.WriteLine(c1.Population);
        }
    }

    class Country
    {
        public Country(string language)
        {
            Language = language;
        }
        // Name değeri zorunlu olsun. Varan 1

        //public Country(string name)
        //{
        //    Name = name;
        //}
        private int population;
        public int Population 
        {
            get 
            { 
                return population; 
            } 
            set
            {
                population = value * 1_000_000;
            }
        }

        //Varan 2: Yalnızca initialise olduğu zaman setlemek zorundayız
        public string Name { get; init; }
        public string Continent { get; set; }
        public string Language { get; }
    }
}
