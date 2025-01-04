namespace Vektorel.ClassDefinitions
{
    static class CarInformation
    {
        public static void Print(string brand, string model, string plate)
        {
            Console.WriteLine("{2} plakalı ve {0} markalı ve {1} modeli olan aracın plakası {2}", brand, model, plate);
        }
    }
}